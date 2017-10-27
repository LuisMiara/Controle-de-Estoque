using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLUsuario
    {
        private DALConexao conexao;

        public BLLUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            if (modelo.UsNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            if (modelo.UsSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário é obrigatório.");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloUsuario modelo)
        {
            if (modelo.UsCod <= 0)
            {
                throw new Exception("O código do usuário é obrigatório.");
            }
            if (modelo.UsNome.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }

            if (modelo.UsSenha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário é obrigatório.");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            DALobj.Excluir(codigo);

        }

        public DataTable Localizar(String valor)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Localizar(valor);

        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.CarregaModeloUsuario(codigo);

        }

        public Boolean Autenticar(String usuario, String senha)
        {
            if(usuario.Trim().Length == 0)
            {
                throw new Exception("O nome do usuário é obrigatório.");
            }
            if (senha.Trim().Length == 0)
            {
                throw new Exception("A senha do usuário é obrigatório.");
            }

            DALUsuario DALobj = new DALUsuario(conexao);
            return DALobj.Autenticar(usuario, senha);

        }
    }
}

