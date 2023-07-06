using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmCadastroLeitor
{
    public class LeitorDAO
    {
        private SqlConnection Connection { get; }

        public LeitorDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(LeitorModel codLeitor)
        {
            using(SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                try
                {
                   

                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO MvtBIBLeitor (leitor, sexo, dataNasciemento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro,  enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero) VALUES (@leitor, @sexo, @dataNasciemento, @cpf, @rg, @email, @telefone, @telefoneCelular, @enderecoNome, @enderecoBairro, @enderecoCidade, @enderecoCEP, @enderecoUF, @enderecoNumero)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@leitor", codLeitor.Nome));
                    command.Parameters.Add(new SqlParameter("@sexo", codLeitor.Sexo));
                    command.Parameters.Add(new SqlParameter("@dataNasciemento", codLeitor.DataNascimento));
                    command.Parameters.Add(new SqlParameter("@cpf", codLeitor.Cpf));
                    command.Parameters.Add(new SqlParameter("@rg", codLeitor.Rg));
                    command.Parameters.Add(new SqlParameter("@email", codLeitor.Email));
                    command.Parameters.Add(new SqlParameter("@telefone", codLeitor.Telefone));
                    command.Parameters.Add(new SqlParameter("@telefoneCelular", codLeitor.TelefoneCelular));;
                    command.Parameters.Add(new SqlParameter("@enderecoNome", codLeitor.EnderecoNome));
                    command.Parameters.Add(new SqlParameter("@enderecoBairro", codLeitor.EnderecoBairro));
                    command.Parameters.Add(new SqlParameter("@enderecoCidade", codLeitor.EnderecoCidade));
                    command.Parameters.Add(new SqlParameter("@enderecoCEP", codLeitor.EnderecoCep));
                    command.Parameters.Add(new SqlParameter("@enderecoUF", codLeitor.EnderecoUf));
                    command.Parameters.Add(new SqlParameter("@enderecoNumero", codLeitor.EnderecoNumero));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }

        }
        public void Atualizar(LeitorModel codLeitor)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlTransaction t = connection.BeginTransaction();
                try
                {
                    using(SqlCommand command = connection.CreateCommand())
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("UPDATE MvtBIBLeitor SET leitor = @leitor, sexo = @sexo, dataNasciemento = @dataNasciemento, cpf = @cpf, rg = @rg, email = @email, telefone = @telefone, telefoneCelular = @telefoneCelular, enderecoNome = @enderecoNome, enderecoBairro = @enderecoBairro, enderecoCidade = @enderecoCidade, enderecoCEP = enderecoCEP, enderecoUF = @enderecoUF, enderecoNumero = @enderecoNumero  WHERE codLeitor = @CodLeitor");
                        command.CommandText = sql.ToString();
                        command.Parameters.AddWithValue("@leitor", codLeitor.Nome);
                        command.Parameters.AddWithValue("@sexo", codLeitor.Sexo);
                        command.Parameters.AddWithValue("@dataNasciemento", codLeitor.DataNascimento);
                        command.Parameters.AddWithValue("@cpf", codLeitor.Cpf);
                        command.Parameters.AddWithValue("@rg", codLeitor.Rg);
                        command.Parameters.AddWithValue("@email", codLeitor.Email);
                        command.Parameters.AddWithValue("@telefone", codLeitor.Telefone);
                        command.Parameters.AddWithValue("@telefoneCelular", codLeitor.TelefoneCelular); ;
                        command.Parameters.AddWithValue("@enderecoNome", codLeitor.EnderecoNome);
                        command.Parameters.AddWithValue("@enderecoBairro", codLeitor.EnderecoBairro);
                        command.Parameters.AddWithValue("@enderecoCidade", codLeitor.EnderecoCidade);
                        command.Parameters.AddWithValue("@enderecoCEP", codLeitor.EnderecoCep);
                        command.Parameters.AddWithValue("@enderecoUF", codLeitor.EnderecoUf);
                        command.Parameters.AddWithValue("@enderecoNumero", codLeitor.EnderecoNumero);
                        command.Parameters.AddWithValue("@CodLeitor", codLeitor.CodLeitor);
                        command.Transaction = t;
                        command.ExecuteNonQuery();
         
                    }
                    t.Commit();
                }
                catch(Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
         
            }
        }
        public void Excluir(LeitorModel codLeitor, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                if (t != null)
                {
                    command.Transaction = t;
                }
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM MvtBIBLeitor WHERE codLeitor=@CodLeitor");
                command.CommandText = sql.ToString();
                command.Parameters.Add(new SqlParameter("@CodLeitor", codLeitor.CodLeitor));

                command.ExecuteNonQuery();
            }
        }
        public List<LeitorModel> GetLeitores()
        {
            List<LeitorModel> leitores = new List<LeitorModel>(); 
            using(SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codLeitor, leitor, sexo, dataNasciemento, cpf, rg, email, telefone, telefoneCelular, enderecoNome, enderecoBairro, enderecoCidade, enderecoCEP, enderecoUF, enderecoNumero FROM MvtBIBLeitor");
                command.CommandText = sql.ToString();
                using(SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        leitores.Add(PopulateDr(dr));
                    }
                }
            }
            return leitores;    
        }

        public bool VerificaRegistroBanco(LeitorModel codLeitor)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {

                command.CommandText = ($"SELECT COUNT(codLeitor) FROM MvtBIBLeitor WHERE codLeitor=@CodLeitor");
                command.Parameters.AddWithValue("@CodLeitor", codLeitor.CodLeitor);

                int count = (int)command.ExecuteScalar();
                return count > 0;

            }
        }

        private LeitorModel PopulateDr(SqlDataReader dr)
        {
            string codLeitor = "";
            string leitor = "";
            string sexo = "";
            string dataNascimento = "";
            string cpf = "";
            string rg = "";
            string email = "";
            string telefone = "";
            string telefoneCelular = "";
            string enderecoNome = "";
            string enderecoBairro = "";
            string enderecoCidade = "";
            string enderecoCEP = "";
            string enderecoUF = "";
            string enderecoNumero = "";
            
            if(DBNull.Value != dr["codLeitor"])
            {
                codLeitor = dr["codLeitor"] + "";
            }
            if (DBNull.Value != dr["leitor"])
            {
                leitor = dr["leitor"] + "";
            }
            if (DBNull.Value != dr["sexo"])
            {
                sexo = dr["sexo"] + "";
            }
            if (DBNull.Value != dr["dataNasciemento"])
            {
                dataNascimento = dr["dataNasciemento"] + "";
            }
            if (DBNull.Value != dr["cpf"])
            {
                cpf = dr["cpf"] + "";
            }
            if (DBNull.Value != dr["rg"])
            {
                rg = dr["rg"] + "";
            }
            if (DBNull.Value != dr["email"])
            {
                email = dr["email"] + "";
            }
            if (DBNull.Value != dr["telefone"])
            {
                telefone = dr["telefone"] + "";
            }
            if (DBNull.Value != dr["telefoneCelular"])
            {
                telefoneCelular = dr["telefoneCelular"] + "";
            }
            if (DBNull.Value != dr["enderecoNome"])
            {
                enderecoNome = dr["enderecoNome"] + "";
            }
            if (DBNull.Value != dr["enderecoBairro"])
            {
                enderecoBairro = dr["enderecoBairro"] + "";
            }
            if (DBNull.Value != dr["enderecoCidade"])
            {
                enderecoCidade = dr["enderecoCidade"] + "";
            }
            if (DBNull.Value != dr["enderecoCEP"])
            {
                enderecoCEP = dr["enderecoCEP"] + "";
            }
            if (DBNull.Value != dr["enderecoUF"])
            {
                enderecoUF = dr["enderecoUF"] + "";
            }
            if (DBNull.Value != dr["enderecoNumero"])
            {
                enderecoNumero = dr["enderecoNumero"] + "";
            }

            return new LeitorModel()
            {

                CodLeitor = codLeitor,
                Nome = leitor,
                Sexo = sexo,
                DataNascimento = dataNascimento,
                Cpf = cpf,
                Rg = rg,
                Email = email,
                Telefone = telefone,
                TelefoneCelular = telefoneCelular,
                EnderecoNome = enderecoNome,
                EnderecoBairro = enderecoBairro,
                EnderecoCidade = enderecoCidade,
                EnderecoCep = enderecoCEP,
                EnderecoUf = enderecoUF,
                EnderecoNumero = enderecoNumero,
           
            };
        }
    }
}
