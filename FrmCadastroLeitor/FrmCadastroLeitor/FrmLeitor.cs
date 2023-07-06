using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCadastroLeitor
{
    public partial class FrmCadastroLeitor : Form
    {
        public FrmCadastroLeitor()
        {
            InitializeComponent();
        }

        private void FrmCadastroLeitor_Load(object sender, EventArgs e)
        {
            CarregarUsuariosGrid();
            CarregarUltimoId_Load();
        }

        private void CarregarUsuariosGrid()
        {
            gridLayout.Rows.Clear();   
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                LeitorDAO dao = new LeitorDAO(connection);
                List<LeitorModel> leitores = dao.GetLeitores();
                foreach (LeitorModel codLeitor in leitores)
                {
                    DataGridViewRow row = gridLayout.Rows[gridLayout.Rows.Add()];

                    row.Cells[colCodLeitor.Index].Value = codLeitor.CodLeitor;
                    row.Cells[colNome.Index].Value = codLeitor.Nome;
                    row.Cells[colSexo.Index].Value = codLeitor.Sexo;
                    row.Cells[colDataNascimento.Index].Value = codLeitor.DataNascimento;
                    row.Cells[colCpf.Index].Value = codLeitor.Cpf;
                    row.Cells[colRg.Index].Value = codLeitor.Rg;
                    row.Cells[colEmail.Index].Value = codLeitor.Email;
                    row.Cells[colTelefone.Index].Value = codLeitor.Telefone;
                    row.Cells[colCelular.Index].Value = codLeitor.TelefoneCelular;
                    row.Cells[colEnderecoNome.Index].Value = codLeitor.EnderecoNome;
                    row.Cells[colEnderecoBairro.Index].Value = codLeitor.EnderecoBairro;
                    row.Cells[colEnderecoCidade.Index].Value = codLeitor.EnderecoCidade;
                    row.Cells[colEnderecoCep.Index].Value = codLeitor.EnderecoCep;
                    row.Cells[colEnderecoUf.Index].Value = codLeitor.EnderecoUf;
                    row.Cells[colEnderecoNumero.Index].Value = codLeitor.EnderecoNumero;
                    btnExlcuir.Enabled = false;
                }
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
          
            using (SqlConnection connection = DaoConnection.GetConexao())
            {

            }

            if (!validarCampos())
            {
                return;
            }



            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    LeitorDAO dao = new LeitorDAO(connection);
                    LeitorModel leitor = new LeitorModel()
                    {
                        CodLeitor = txtCodigo.Text,
                        Nome = txtNome.Text,
                        Sexo = txtSexo.Text,
                        DataNascimento = txtDataNascimento.Value.Date.ToString(),
                        Cpf = txtCpf.Text.Replace(".", "").Replace(".", "").Replace("-", ""),
                        Rg = txtRg.Text,
                        Email = txtEmail.Text,
                        Telefone = txtTelefone.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                        TelefoneCelular = txtCelular.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", ""),
                        EnderecoNome = txtEndereco.Text,
                        EnderecoBairro = txtBairro.Text,
                        EnderecoCidade = txtCidade.Text,
                        EnderecoCep = txtCep.Text.Replace("-", ""),
                        EnderecoUf = txtUf.Text,
                        EnderecoNumero = txtNumero.Text

                    };

                    bool registroExistente = dao.VerificaRegistroBanco(leitor);
                    {

                        if (registroExistente)
                        {
                            dao.Atualizar(leitor);
                            MessageBox.Show("Leitor atualizado com sucesso");

                        }
                        else
                        {
                            dao.Salvar(leitor);
                            MessageBox.Show("Leitor salvo com sucesso");

                        }

                        CarregarUsuariosGrid();
                        CarregarUltimoId_Load();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar ou atualizar o leitor\n{ex.Message}");
            }
        }

        private void btnExlcuir_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                return;
            }


            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            try
            {

                if (confirmacao == DialogResult.Yes)
                {
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        LeitorDAO dao = new LeitorDAO(connection);
                        dao.Excluir(new LeitorModel()
                        {
                            CodLeitor = txtCodigo.Text

                        });

                        MessageBox.Show("Leitor excluido com sucesso!");
                        CarregarUsuariosGrid();
                        CarregarUltimoId_Load();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluido o leitor\n{ex.Message}!");
            }
        }

        public bool validarCampos()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Informe o campo Nome");

                return false;
            }
            else if (string.IsNullOrEmpty(txtSexo.Text))
            {
                MessageBox.Show("Informe o campo Sexo");

                return false;
            }
            else if (string.IsNullOrEmpty(txtDataNascimento.Value.Date.ToString()))
            {
                MessageBox.Show("Informe o campo data de nascimento");

                return false;
            }
            else if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Informe o campo Cpf");

                return false;
            }
            else if (string.IsNullOrEmpty(txtRg.Text))
            {
                MessageBox.Show("Informe o campo Rg");

                return false;
            }
            else if (string.IsNullOrEmpty(txtUf.Text))
            {
                MessageBox.Show("Informe o campo uf");

                return false;
            }

            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Informe o campo email");

                return false;
            }
            else if (string.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Informe o campo telefone");
                return false;
            }
            
            else if (string.IsNullOrEmpty(txtCelular.Text))
            {
                MessageBox.Show("Informe o campo celular");

                return false;
            }
            else if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("Informe o campo endereço");

                return false;
            }
            else if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("Informe o campo bairro");

                return false;
            }
            else if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("Informe o campo cidade");

                return false; ;
            }
            else if (string.IsNullOrEmpty(txtCep.Text))
            {
                MessageBox.Show("Informe o campo Cep");

                return false;
            }
            else if (string.IsNullOrEmpty(txtNumero.Text))
            {
                MessageBox.Show("Informe o campo número");

                return false;
            }
            return true;
        }

        private void CarregarUltimoId_Load()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {

                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('MvtBIBLeitor') + 1", connection);
                int proximoID = Convert.ToInt32(command.ExecuteScalar());

                txtNome.Text = string.Empty;
                txtSexo.Text = string.Empty;
                txtDataNascimento.Text = string.Empty;
                txtCpf.Text = string.Empty;
                txtRg.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtTelefone.Text = string.Empty;
                txtCelular.Text = string.Empty;
                txtEndereco.Text = string.Empty;
                txtBairro.Text = string.Empty;
                txtCidade.Text = string.Empty;
                txtCep.Text = string.Empty;
                txtUf.Text = string.Empty;
                txtNumero.Text = string.Empty;
    

                txtCodigo.Text = proximoID.ToString();
            }
        }




        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        
       

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridLayout_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodigo.Text = gridLayout.Rows[e.RowIndex].Cells[colCodLeitor.Index].Value + "";
                txtNome.Text = gridLayout.Rows[e.RowIndex].Cells[colNome.Index].Value + "";
                txtSexo.Text = gridLayout.Rows[e.RowIndex].Cells[colSexo.Index].Value + "";
                txtDataNascimento.Text = gridLayout.Rows[e.RowIndex].Cells[colDataNascimento.Index].Value + "";
                txtCpf.Text = gridLayout.Rows[e.RowIndex].Cells[colCpf.Index].Value + "";
                txtRg.Text = gridLayout.Rows[e.RowIndex].Cells[colRg.Index].Value + "";
                txtEmail.Text = gridLayout.Rows[e.RowIndex].Cells[colEmail.Index].Value + "";
                txtTelefone.Text = gridLayout.Rows[e.RowIndex].Cells[colTelefone.Index].Value + "";
                txtCelular.Text = gridLayout.Rows[e.RowIndex].Cells[colCelular.Index].Value + "";
                txtEndereco.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoNome.Index].Value + "";
                txtBairro.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoBairro.Index].Value + "";
                txtCidade.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoCidade.Index].Value + "";
                txtCep.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoCep.Index].Value + "";
                txtUf.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoUf.Index].Value + "";
                txtNumero.Text = gridLayout.Rows[e.RowIndex].Cells[colEnderecoNumero.Index].Value + "";
                btnExlcuir.Enabled = true;
            }
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
