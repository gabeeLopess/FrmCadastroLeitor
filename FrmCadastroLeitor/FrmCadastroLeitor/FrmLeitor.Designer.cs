namespace FrmCadastroLeitor
{
    partial class FrmCadastroLeitor
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblRg = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEnderecoNome = new System.Windows.Forms.Label();
            this.lblTelefoneCelular = new System.Windows.Forms.Label();
            this.lblEnderecoBairro = new System.Windows.Forms.Label();
            this.lblEnderecoCidade = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.lblEnderecoNumero = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.MaskedTextBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtUf = new System.Windows.Forms.ComboBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.gridLayout = new System.Windows.Forms.DataGridView();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExlcuir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uftxt = new System.Windows.Forms.Label();
            this.colCodLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoBairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoCidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoCep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoUf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnderecoNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(31, 17);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(46, 15);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(218, 19);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(41, 15);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(31, 43);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(35, 15);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(218, 110);
            this.lblDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(102, 15);
            this.lblDataNascimento.TabIndex = 2;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(31, 70);
            this.lblCpf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(30, 15);
            this.lblCpf.TabIndex = 5;
            this.lblCpf.Text = "CPF";
            // 
            // lblRg
            // 
            this.lblRg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(220, 70);
            this.lblRg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(25, 15);
            this.lblRg.TabIndex = 4;
            this.lblRg.Text = "RG";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(220, 41);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(404, 70);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(55, 15);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEnderecoNome
            // 
            this.lblEnderecoNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnderecoNome.AutoSize = true;
            this.lblEnderecoNome.Location = new System.Drawing.Point(404, 52);
            this.lblEnderecoNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoNome.Name = "lblEnderecoNome";
            this.lblEnderecoNome.Size = new System.Drawing.Size(60, 15);
            this.lblEnderecoNome.TabIndex = 9;
            this.lblEnderecoNome.Text = "Endereço";
            // 
            // lblTelefoneCelular
            // 
            this.lblTelefoneCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTelefoneCelular.AutoSize = true;
            this.lblTelefoneCelular.Location = new System.Drawing.Point(597, 70);
            this.lblTelefoneCelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefoneCelular.Name = "lblTelefoneCelular";
            this.lblTelefoneCelular.Size = new System.Drawing.Size(97, 15);
            this.lblTelefoneCelular.TabIndex = 8;
            this.lblTelefoneCelular.Text = "Telefone Celular";
            // 
            // lblEnderecoBairro
            // 
            this.lblEnderecoBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnderecoBairro.AutoSize = true;
            this.lblEnderecoBairro.Location = new System.Drawing.Point(31, 52);
            this.lblEnderecoBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoBairro.Name = "lblEnderecoBairro";
            this.lblEnderecoBairro.Size = new System.Drawing.Size(40, 15);
            this.lblEnderecoBairro.TabIndex = 7;
            this.lblEnderecoBairro.Text = "Bairro";
            // 
            // lblEnderecoCidade
            // 
            this.lblEnderecoCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnderecoCidade.AutoSize = true;
            this.lblEnderecoCidade.Location = new System.Drawing.Point(404, 23);
            this.lblEnderecoCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoCidade.Name = "lblEnderecoCidade";
            this.lblEnderecoCidade.Size = new System.Drawing.Size(46, 15);
            this.lblEnderecoCidade.TabIndex = 6;
            this.lblEnderecoCidade.Text = "Cidade";
            // 
            // lblUf
            // 
            this.lblUf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(-18, 117);
            this.lblUf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(23, 15);
            this.lblUf.TabIndex = 14;
            this.lblUf.Text = "UF";
            // 
            // lblEnderecoNumero
            // 
            this.lblEnderecoNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEnderecoNumero.AutoSize = true;
            this.lblEnderecoNumero.Location = new System.Drawing.Point(31, 76);
            this.lblEnderecoNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnderecoNumero.Name = "lblEnderecoNumero";
            this.lblEnderecoNumero.Size = new System.Drawing.Size(52, 15);
            this.lblEnderecoNumero.TabIndex = 13;
            this.lblEnderecoNumero.Text = "Número";
            // 
            // lblCep
            // 
            this.lblCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(218, 29);
            this.lblCep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 15);
            this.lblCep.TabIndex = 12;
            this.lblCep.Text = "CEP";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(96, 14);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 15;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNome.Location = new System.Drawing.Point(282, 12);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(528, 20);
            this.txtNome.TabIndex = 16;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCpf.Location = new System.Drawing.Point(96, 67);
            this.txtCpf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(100, 21);
            this.txtCpf.TabIndex = 17;
            this.txtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // txtRg
            // 
            this.txtRg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRg.Location = new System.Drawing.Point(282, 67);
            this.txtRg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRg.Mask = "00000000000000000000000000000000000000000000000000";
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(100, 21);
            this.txtRg.TabIndex = 18;
            this.txtRg.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // txtSexo
            // 
            this.txtSexo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.txtSexo.Location = new System.Drawing.Point(96, 38);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(100, 23);
            this.txtSexo.TabIndex = 19;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Location = new System.Drawing.Point(282, 36);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(528, 20);
            this.txtEmail.TabIndex = 21;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTelefone.Location = new System.Drawing.Point(467, 67);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(111, 21);
            this.txtTelefone.TabIndex = 22;
            // 
            // txtCelular
            // 
            this.txtCelular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCelular.Location = new System.Drawing.Point(712, 67);
            this.txtCelular.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(98, 21);
            this.txtCelular.TabIndex = 23;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCidade.Location = new System.Drawing.Point(472, 21);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Multiline = true;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(343, 20);
            this.txtCidade.TabIndex = 25;
            // 
            // txtUf
            // 
            this.txtUf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUf.FormattingEnabled = true;
            this.txtUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.txtUf.Location = new System.Drawing.Point(96, 20);
            this.txtUf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(100, 23);
            this.txtUf.TabIndex = 26;
            this.txtUf.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEndereco.Location = new System.Drawing.Point(472, 49);
            this.txtEndereco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(343, 20);
            this.txtEndereco.TabIndex = 27;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBairro.Location = new System.Drawing.Point(96, 47);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Multiline = true;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(286, 20);
            this.txtBairro.TabIndex = 28;
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNumero.Location = new System.Drawing.Point(96, 73);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumero.Multiline = true;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(286, 20);
            this.txtNumero.TabIndex = 29;
            // 
            // gridLayout
            // 
            this.gridLayout.AllowUserToAddRows = false;
            this.gridLayout.AllowUserToDeleteRows = false;
            this.gridLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLayout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLayout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLayout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodLeitor,
            this.colNome,
            this.colCpf,
            this.colSexo,
            this.colRg,
            this.colEmail,
            this.colTelefone,
            this.colCelular,
            this.colEnderecoNome,
            this.colEnderecoBairro,
            this.colEnderecoCidade,
            this.colEnderecoCep,
            this.colEnderecoUf,
            this.colDataNascimento,
            this.colEnderecoNumero});
            this.gridLayout.Location = new System.Drawing.Point(12, 296);
            this.gridLayout.Name = "gridLayout";
            this.gridLayout.ReadOnly = true;
            this.gridLayout.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.gridLayout.Size = new System.Drawing.Size(835, 334);
            this.gridLayout.TabIndex = 30;
            this.gridLayout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridLayout.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridLayout_CellContentDoubleClick);
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCep.Location = new System.Drawing.Point(282, 21);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCep.Mask = "00000-0000";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(100, 21);
            this.txtCep.TabIndex = 31;
            this.txtCep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCep_MaskInputRejected);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSalvar.Location = new System.Drawing.Point(331, 268);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 22);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExlcuir
            // 
            this.btnExlcuir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExlcuir.Location = new System.Drawing.Point(437, 268);
            this.btnExlcuir.Name = "btnExlcuir";
            this.btnExlcuir.Size = new System.Drawing.Size(75, 22);
            this.btnExlcuir.TabIndex = 33;
            this.btnExlcuir.Text = "Excluir";
            this.btnExlcuir.UseVisualStyleBackColor = true;
            this.btnExlcuir.Click += new System.EventHandler(this.btnExlcuir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDataNascimento);
            this.groupBox1.Controls.Add(this.lblCodigo);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.txtSexo);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblCpf);
            this.groupBox1.Controls.Add(this.txtCpf);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.lblRg);
            this.groupBox1.Controls.Add(this.txtTelefone);
            this.groupBox1.Controls.Add(this.txtRg);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblTelefoneCelular);
            this.groupBox1.Controls.Add(this.lblDataNascimento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 137);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(353, 110);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(180, 21);
            this.txtDataNascimento.TabIndex = 24;
            this.txtDataNascimento.ValueChanged += new System.EventHandler(this.txtDataNascimento_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uftxt);
            this.groupBox2.Controls.Add(this.txtCep);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Controls.Add(this.lblEnderecoCidade);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblEnderecoNome);
            this.groupBox2.Controls.Add(this.txtUf);
            this.groupBox2.Controls.Add(this.txtNumero);
            this.groupBox2.Controls.Add(this.txtEndereco);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblEnderecoBairro);
            this.groupBox2.Controls.Add(this.lblEnderecoNumero);
            this.groupBox2.Location = new System.Drawing.Point(12, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 107);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // uftxt
            // 
            this.uftxt.AutoSize = true;
            this.uftxt.Location = new System.Drawing.Point(31, 23);
            this.uftxt.Name = "uftxt";
            this.uftxt.Size = new System.Drawing.Size(17, 15);
            this.uftxt.TabIndex = 32;
            this.uftxt.Text = "uf";
            // 
            // colCodLeitor
            // 
            this.colCodLeitor.HeaderText = "Id";
            this.colCodLeitor.Name = "colCodLeitor";
            this.colCodLeitor.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            // 
            // colCpf
            // 
            this.colCpf.HeaderText = "Cpf";
            this.colCpf.Name = "colCpf";
            this.colCpf.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            this.colSexo.Visible = false;
            // 
            // colRg
            // 
            this.colRg.HeaderText = "Rg";
            this.colRg.Name = "colRg";
            this.colRg.ReadOnly = true;
            this.colRg.Visible = false;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Visible = false;
            // 
            // colTelefone
            // 
            this.colTelefone.HeaderText = "Telefone";
            this.colTelefone.Name = "colTelefone";
            this.colTelefone.ReadOnly = true;
            this.colTelefone.Visible = false;
            // 
            // colCelular
            // 
            this.colCelular.HeaderText = "Celular";
            this.colCelular.Name = "colCelular";
            this.colCelular.ReadOnly = true;
            this.colCelular.Visible = false;
            // 
            // colEnderecoNome
            // 
            this.colEnderecoNome.HeaderText = "Endereço";
            this.colEnderecoNome.Name = "colEnderecoNome";
            this.colEnderecoNome.ReadOnly = true;
            this.colEnderecoNome.Visible = false;
            // 
            // colEnderecoBairro
            // 
            this.colEnderecoBairro.HeaderText = "Bairro";
            this.colEnderecoBairro.Name = "colEnderecoBairro";
            this.colEnderecoBairro.ReadOnly = true;
            this.colEnderecoBairro.Visible = false;
            // 
            // colEnderecoCidade
            // 
            this.colEnderecoCidade.HeaderText = "Cidade";
            this.colEnderecoCidade.Name = "colEnderecoCidade";
            this.colEnderecoCidade.ReadOnly = true;
            this.colEnderecoCidade.Visible = false;
            // 
            // colEnderecoCep
            // 
            this.colEnderecoCep.HeaderText = "Cep";
            this.colEnderecoCep.Name = "colEnderecoCep";
            this.colEnderecoCep.ReadOnly = true;
            this.colEnderecoCep.Visible = false;
            // 
            // colEnderecoUf
            // 
            this.colEnderecoUf.HeaderText = "Uf";
            this.colEnderecoUf.Name = "colEnderecoUf";
            this.colEnderecoUf.ReadOnly = true;
            // 
            // colDataNascimento
            // 
            this.colDataNascimento.HeaderText = "Data Nascimento";
            this.colDataNascimento.Name = "colDataNascimento";
            this.colDataNascimento.ReadOnly = true;
            // 
            // colEnderecoNumero
            // 
            this.colEnderecoNumero.HeaderText = "Número";
            this.colEnderecoNumero.Name = "colEnderecoNumero";
            this.colEnderecoNumero.ReadOnly = true;
            this.colEnderecoNumero.Visible = false;
            // 
            // FrmCadastroLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExlcuir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gridLayout);
            this.Controls.Add(this.lblUf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmCadastroLeitor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Leitor";
            this.Load += new System.EventHandler(this.FrmCadastroLeitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLayout)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEnderecoNome;
        private System.Windows.Forms.Label lblTelefoneCelular;
        private System.Windows.Forms.Label lblEnderecoBairro;
        private System.Windows.Forms.Label lblEnderecoCidade;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.Label lblEnderecoNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtRg;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.ComboBox txtUf;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.DataGridView gridLayout;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExlcuir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker txtDataNascimento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label uftxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCelular;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoBairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoCidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoCep;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoUf;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnderecoNumero;
    }
}

