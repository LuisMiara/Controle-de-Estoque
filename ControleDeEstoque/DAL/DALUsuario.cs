using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALUsuario
    {
        private DALConexao conexao;

        public DALUsuario(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into usuario(us_nome, us_senha) values (@nome, @senha); select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", modelo.UsNome);
            cmd.Parameters.AddWithValue("@senha", modelo.UsSenha);
            conexao.Conectar();
            modelo.UsCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloUsuario modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update usuario set us_nome = @nome, us_senha = @senha where us_cod = @codigo;";
            cmd.Parameters.AddWithValue("@nome", modelo.UsNome);
            cmd.Parameters.AddWithValue("@codigo", modelo.UsNome);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from usuario where us_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from usuario where us_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUsuario CarregaModeloUsuario(int codigo)
        {
            ModeloUsuario modelo = new ModeloUsuario();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where us_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.UsCod = Convert.ToInt32(registro["us_cod"]);
                modelo.UsNome = Convert.ToString(registro["us_nome"]);
                modelo.UsSenha = Convert.ToString(registro["us_senha"]);
            }
            conexao.Desconectar();
            return modelo;
        }

        public Boolean Autenticar(String usuario, String senha)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from usuario where us_nome = @nome and us_senha = @senha";
            cmd.Parameters.AddWithValue("@nome", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                return true;
            }else
            {
                return false;
            }
            
        }
    }
}
