namespace AirSystem.Views
{
    partial class frmTelaUser
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
            this.btnGerenciarRelatorio = new System.Windows.Forms.Button();
            this.btnGerenciarCompanhia = new System.Windows.Forms.Button();
            this.btnListarAviao = new System.Windows.Forms.Button();
            this.btnGerenciarAviao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerenciarRelatorio
            // 
            this.btnGerenciarRelatorio.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarRelatorio.Location = new System.Drawing.Point(299, 128);
            this.btnGerenciarRelatorio.Name = "btnGerenciarRelatorio";
            this.btnGerenciarRelatorio.Size = new System.Drawing.Size(114, 87);
            this.btnGerenciarRelatorio.TabIndex = 8;
            this.btnGerenciarRelatorio.Text = "Gerenciar Relatórios";
            this.btnGerenciarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarCompanhia
            // 
            this.btnGerenciarCompanhia.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarCompanhia.Location = new System.Drawing.Point(299, 221);
            this.btnGerenciarCompanhia.Name = "btnGerenciarCompanhia";
            this.btnGerenciarCompanhia.Size = new System.Drawing.Size(114, 87);
            this.btnGerenciarCompanhia.TabIndex = 7;
            this.btnGerenciarCompanhia.Text = "Gerenciar Companhia";
            this.btnGerenciarCompanhia.UseVisualStyleBackColor = true;
            // 
            // btnListarAviao
            // 
            this.btnListarAviao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarAviao.Location = new System.Drawing.Point(419, 128);
            this.btnListarAviao.Name = "btnListarAviao";
            this.btnListarAviao.Size = new System.Drawing.Size(114, 87);
            this.btnListarAviao.TabIndex = 6;
            this.btnListarAviao.Text = "Listar Aviões";
            this.btnListarAviao.UseVisualStyleBackColor = true;
            // 
            // btnGerenciarAviao
            // 
            this.btnGerenciarAviao.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerenciarAviao.Location = new System.Drawing.Point(419, 221);
            this.btnGerenciarAviao.Name = "btnGerenciarAviao";
            this.btnGerenciarAviao.Size = new System.Drawing.Size(114, 87);
            this.btnGerenciarAviao.TabIndex = 5;
            this.btnGerenciarAviao.Text = "Gerenciar Avião";
            this.btnGerenciarAviao.UseVisualStyleBackColor = true;
            // 
            // frmTelaUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerenciarRelatorio);
            this.Controls.Add(this.btnGerenciarCompanhia);
            this.Controls.Add(this.btnListarAviao);
            this.Controls.Add(this.btnGerenciarAviao);
            this.Name = "frmTelaUser";
            this.Text = "Tela Principal - AirSystem";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnGerenciarRelatorio;
        private System.Windows.Forms.Button btnGerenciarCompanhia;
        private System.Windows.Forms.Button btnListarAviao;
        private System.Windows.Forms.Button btnGerenciarAviao;
    }
}