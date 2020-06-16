using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    public class UsuarioRepository
    {
        private static List<Usuario> usuarios;
        private static int id = 1;

        public UsuarioRepository()
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();
            }
        }

        public bool Cadastrar(Usuario usuario)
        {
            usuario.Id = id;
            usuarios.Add(usuario);
            id++;
            return true;
        }

        public List<Usuario> BuscarTodos()
        {
            return usuarios;
        }

        public Usuario BuscarId(int id)
        {
            foreach (var item in usuarios)
            {
                if (item.Id == id)
                {
                    Usuario user    = new Usuario();
                    user.Id         = item.Id;
                    user.Nome       = item.Nome;
                    user.Sobrenome  = item.Sobrenome;
                    user.Senha      = item.Sobrenome;
                    user.Endereco   = item.Endereco;
                    user.Username   = item.Username;
                    user.Senha      = item.Senha;
                    user.DataNascimento = item.DataNascimento;

                    return user;
                }
            }
            return null;
        }

        public void Deletar(int id)
        {
            Usuario usuario = usuarios.Find(x => x.Id == id);
            usuarios.Remove(usuario);
        }

        public void Salvar(Usuario userGrid)
        {
            Usuario u   = usuarios.Find(x => x.Id == userGrid.Id);
            int posicao = usuarios.IndexOf(u);
            usuarios[posicao] = userGrid;
        }
    }
}
