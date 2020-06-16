namespace AirSystem.Views
{
    partial class frmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbxAdm = new System.Windows.Forms.CheckBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblSenhaAviso = new System.Windows.Forms.Label();
            this.pcbUserFoto = new System.Windows.Forms.PictureBox();
            this.lblSenhaRegex = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxNendereco = new AirSystem.MarkedWaterTextBox();
            this.tbxEndereco = new AirSystem.MarkedWaterTextBox();
            this.tbxSobrenome = new AirSystem.MarkedWaterTextBox();
            this.tbxNome = new AirSystem.MarkedWaterTextBox();
            this.tbxSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxConfirmarSenha = new AirSystem.MarkedWaterTextBox();
            this.tbxUsuario = new AirSystem.MarkedWaterTextBox();
            this.markedWaterTextBox1 = new AirSystem.MarkedWaterTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(41, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(41, 71);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(71, 19);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(41, 110);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(88, 19);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(533, 248);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 19);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(533, 193);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 19);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(498, 283);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(114, 19);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirma Senha";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(652, 392);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(537, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Adicionar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(537, 41);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Excluir";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbxAdm
            // 
            this.cbxAdm.AutoSize = true;
            this.cbxAdm.Location = new System.Drawing.Point(618, 219);
            this.cbxAdm.Name = "cbxAdm";
            this.cbxAdm.Size = new System.Drawing.Size(89, 17);
            this.cbxAdm.TabIndex = 10;
            this.cbxAdm.Text = "Administrador";
            this.cbxAdm.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(156, 106);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(145, 21);
            this.dtpNascimento.TabIndex = 16;
            this.dtpNascimento.ValueChanged += new System.EventHandler(this.dtpNascimento_ValueChanged);
            this.dtpNascimento.Enter += new System.EventHandler(this.Focus_enter);
            this.dtpNascimento.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // lblSenhaAviso
            // 
            this.lblSenhaAviso.AutoSize = true;
            this.lblSenhaAviso.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAviso.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSenhaAviso.Location = new System.Drawing.Point(12, 283);
            this.lblSenhaAviso.Name = "lblSenhaAviso";
            this.lblSenhaAviso.Size = new System.Drawing.Size(183, 14);
            this.lblSenhaAviso.TabIndex = 17;
            this.lblSenhaAviso.Text = "**As senhas precisam ser idênticas";
            // 
            // pcbUserFoto
            // 
            this.pcbUserFoto.Location = new System.Drawing.Point(618, 12);
            this.pcbUserFoto.Name = "pcbUserFoto";
            this.pcbUserFoto.Size = new System.Drawing.Size(170, 157);
            this.pcbUserFoto.TabIndex = 26;
            this.pcbUserFoto.TabStop = false;
            this.pcbUserFoto.Click += new System.EventHandler(this.pcbUserFoto_Click);
            // 
            // lblSenhaRegex
            // 
            this.lblSenhaRegex.AutoSize = true;
            this.lblSenhaRegex.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaRegex.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblSenhaRegex.Location = new System.Drawing.Point(12, 251);
            this.lblSenhaRegex.Name = "lblSenhaRegex";
            this.lblSenhaRegex.Size = new System.Drawing.Size(380, 14);
            this.lblSenhaRegex.TabIndex = 18;
            this.lblSenhaRegex.Text = "*A senha deve ter: pelo menos 8 caracteres, 1 letra maiúscula e 1 Número";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxSenha);
            this.panel1.Controls.Add(this.tbxConfirmarSenha);
            this.panel1.Controls.Add(this.tbxUsuario);
            this.panel1.Controls.Add(this.pcbUserFoto);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.lblSenhaAviso);
            this.panel1.Controls.Add(this.cbxAdm);
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.dtpNascimento);
            this.panel1.Controls.Add(this.lblSenhaRegex);
            this.panel1.Controls.Add(this.lblConfirmarSenha);
            this.panel1.Controls.Add(this.lblUsuario);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tbxNendereco
            // 
            this.tbxNendereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxNendereco.Location = new System.Drawing.Point(392, 68);
            this.tbxNendereco.Name = "tbxNendereco";
            this.tbxNendereco.Size = new System.Drawing.Size(91, 20);
            this.tbxNendereco.TabIndex = 22;
            this.tbxNendereco.Text = "N°";
            this.tbxNendereco.WaterMarkText = "N°";
            this.tbxNendereco.TextChanged += new System.EventHandler(this.tbxNendereco_TextChanged);
            this.tbxNendereco.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxNendereco.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.ForeColor = System.Drawing.Color.Gray;
            this.tbxEndereco.Location = new System.Drawing.Point(156, 68);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(230, 20);
            this.tbxEndereco.TabIndex = 21;
            this.tbxEndereco.Text = "Digite seu endereço";
            this.tbxEndereco.WaterMarkText = "Digite seu endereço";
            this.tbxEndereco.TextChanged += new System.EventHandler(this.tbxEndereco_TextChanged);
            this.tbxEndereco.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxEndereco.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.ForeColor = System.Drawing.Color.Gray;
            this.tbxSobrenome.Location = new System.Drawing.Point(307, 30);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(145, 20);
            this.tbxSobrenome.TabIndex = 20;
            this.tbxSobrenome.Text = "Digite seu sobrenome";
            this.tbxSobrenome.WaterMarkText = "Digite seu sobrenome";
            this.tbxSobrenome.TextChanged += new System.EventHandler(this.tbxSobrenome_TextChanged);
            this.tbxSobrenome.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxSobrenome.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxNome
            // 
            this.tbxNome.ForeColor = System.Drawing.Color.Gray;
            this.tbxNome.Location = new System.Drawing.Point(156, 30);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(145, 20);
            this.tbxNome.TabIndex = 19;
            this.tbxNome.Text = "Digite seu nome";
            this.tbxNome.WaterMarkText = "Digite seu nome";
            this.tbxNome.TextChanged += new System.EventHandler(this.tbxNome_TextChanged);
            this.tbxNome.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxNome.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxSenha
            // 
            this.tbxSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxSenha.Location = new System.Drawing.Point(618, 248);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxSenha.TabIndex = 24;
            this.tbxSenha.Text = "Insira sua senha";
            this.tbxSenha.WaterMarkText = "Insira sua senha";
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            this.tbxSenha.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxSenha.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.ForeColor = System.Drawing.Color.Gray;
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(618, 283);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxConfirmarSenha.TabIndex = 25;
            this.tbxConfirmarSenha.Text = "Confirme sua senha";
            this.tbxConfirmarSenha.WaterMarkText = "Confirme sua senha";
            this.tbxConfirmarSenha.TextChanged += new System.EventHandler(this.tbxConfirmarSenha_TextChanged);
            this.tbxConfirmarSenha.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxConfirmarSenha.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.ForeColor = System.Drawing.Color.Gray;
            this.tbxUsuario.Location = new System.Drawing.Point(618, 193);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(145, 20);
            this.tbxUsuario.TabIndex = 23;
            this.tbxUsuario.Text = "Insira seu usuario";
            this.tbxUsuario.WaterMarkText = "Insira seu usuario";
            this.tbxUsuario.Enter += new System.EventHandler(this.Focus_enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.Focus_leave);
            // 
            // markedWaterTextBox1
            // 
            this.markedWaterTextBox1.ForeColor = System.Drawing.Color.Gray;
            this.markedWaterTextBox1.Location = new System.Drawing.Point(169, 218);
            this.markedWaterTextBox1.Name = "markedWaterTextBox1";
            this.markedWaterTextBox1.Size = new System.Drawing.Size(145, 20);
            this.markedWaterTextBox1.TabIndex = 23;
            this.markedWaterTextBox1.WaterMarkText = null;
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNendereco);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro Usuário - AirSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCadastroUsuario_FormClosing);
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pcbUserFoto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.CheckBox cbxAdm;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblSenhaAviso;
        private System.Windows.Forms.Label lblSenhaRegex;
        private MarkedWaterTextBox tbxNome;
        private MarkedWaterTextBox tbxSobrenome;
        private MarkedWaterTextBox tbxEndereco;
        private MarkedWaterTextBox tbxNendereco;
        private MarkedWaterTextBox tbxUsuario;
        private MarkedWaterTextBox markedWaterTextBox1;
        private MarkedWaterTextBox tbxSenha;
        private MarkedWaterTextBox tbxConfirmarSenha;
        private System.Windows.Forms.Panel panel1;
    }
}