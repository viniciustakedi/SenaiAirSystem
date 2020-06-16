using AirSystem.Models;
using AirSystem.Repositories;
using AirSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmListarUsuarios : Form
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        Usuario userGrid = new Usuario();
        string idioma = "";

        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        public frmListarUsuarios(string idioma)
        {
            InitializeComponent();

            //traduçao form
            if (idioma == "Inglish")
            {
                this.idioma = idioma;

                lblNome.Text = "First Name";
                lblSobrenome.Text = "Last Name";
                lblEndereco.Text = "Adress";
                lblNascimento.Text = "Birthday";
                lblSenha.Text = "Password";
                lblUsuario.Text = "Username";
                label1.Text = "Name";

                cbxAdm.Text = "Administrator";
                btnSalvar.Text = "Save";
                btnDeletar.Text = "Delete";
                btnNovoUser.Text = "New User";
                btnVoltar.Text = "Return";


            }

        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            List<Usuario> usuarios = usuarioRepository.BuscarTodos();
            atualizaLista();
        }

        private void atualizaLista()
        {
            dgvListaUsuario.DataSource = null;

            List<Usuario> usuarios = usuarioRepository.BuscarTodos();

            List<UsuarioViewModel> userFiltro = new List<UsuarioViewModel>();

            foreach (var item in usuarios)
            {
                UsuarioViewModel usuarioFiltro = new UsuarioViewModel
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    IsAdm = item.IsAdmin
                };

                userFiltro.Add(usuarioFiltro);
            }

            dgvListaUsuario.DataSource = userFiltro;

            Contador();
        }

        private void Contador()
        {
            if (idioma != "Inglês")
            {
                lblQuantidade.Text = $"{dgvListaUsuario.RowCount} itens de {usuarioRepository.BuscarTodos().Count}"; 
            }
            else
            {
                lblQuantidade.Text = $"{dgvListaUsuario.RowCount} items of {usuarioRepository.BuscarTodos().Count}";

            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = usuarioRepository.BuscarTodos().
                FindAll(x => x.Nome.ToUpper().Contains(tbxFiltro.Text.ToUpper()));

            Contador();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmTelaAdm().Show();

            this.Close();

        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuario().ShowDialog();

            atualizaLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                usuarioRepository.Deletar(userGrid.Id);
                atualizaLista();
            }

        }

        private void dgvListaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];
                Usuario usuario = new Usuario
                {
                    Id = Convert.ToInt32(linha.Cells[0].Value.ToString())
                };

                Usuario userSelect = usuarioRepository.BuscarId(usuario.Id);
                userSelect.Id = usuario.Id;

                tbxNome.Text = userSelect.Nome;
                tbxSobrenome.Text = userSelect.Sobrenome;
                tbxUsuario.Text = userSelect.Username;
                tbxSenha.Text = userSelect.Senha;
                dtpNascimento.Value = userSelect.DataNascimento;

                cbxAdm.Checked = userSelect.IsAdmin;

                string[] stringSplitada = userSelect.Endereco.Split(',');
                tbxEndereco.Text = stringSplitada[0];
                tbxNendereco.Text = stringSplitada[1];

                userGrid = userSelect;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja salvar?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                userGrid.Nome = tbxNome.Text;
                userGrid.Sobrenome = tbxSobrenome.Text;
                var adress = $"{tbxEndereco.Text}, {tbxNendereco.Text}";

                userGrid.Endereco = adress;
                userGrid.DataNascimento = Convert.ToDateTime(dtpNascimento.Text);
                userGrid.Username = tbxUsuario.Text;
                userGrid.Senha = tbxSenha.Text;
                userGrid.IsAdmin = cbxAdm.Checked;

                usuarioRepository.Salvar(userGrid);

                atualizaLista();
            }
        }

 
    }
}
