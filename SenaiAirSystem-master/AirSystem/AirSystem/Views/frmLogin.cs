using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void InvisibleLabel(Label labelName)
        {
            labelName.Parent = pcbBackground;
            labelName.BackColor = Color.Transparent;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InvisibleLabel(lblLogo);
            InvisibleLabel(lblUsuario);
            InvisibleLabel(lblSenha);
            InvisibleLabel(lblIdioma);
            InvisibleLabel(lblTempo);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            lblTempo.Text = time;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxIdioma.Text))
            {
                    frmCadastroUsuario frmCadastro = new frmCadastroUsuario();
                    frmCadastro.Show();
                
            }
            else
            {
                MessageBox.Show(this, "Escolha um Idioma / Choose a language", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxIdioma.Text))
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                List<Usuario> usuarios = usuarioRepository.BuscarTodos();

                foreach (var item in usuarios)
                {
                    if (item.Username == tbxUsuario.Text && item.Senha == tbxSenha.Text)
                    {
                        if (item.IsAdmin)
                        {
                            if (cbxIdioma.Text != "Inglish")
                            {
                                frmTelaAdm frm = new frmTelaAdm();
                                frm.Show();
                                this.WindowState = FormWindowState.Minimized;
                            }
                            else
                            {
                                frmTelaAdm frm = new frmTelaAdm(cbxIdioma.Text);
                                frm.Show();

                            }
                        }
                        else
                        {
                            if (cbxIdioma.Text != "Inglish")
                            {
                                frmTelaUser frm = new frmTelaUser();
                                frm.Show();
                                this.WindowState = FormWindowState.Minimized;
                            }
                            else
                            {

                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(this, "Escolha um Idioma / Select a language", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você realmente quer sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void pcbBackground_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblTempo_Click(object sender, EventArgs e)
        {

        }
    }
}
