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
    public class DALUnidadeDeMedida
    {
        private DALConexao conexao;

        public DALUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "insert into undmedida(umed_nome) values (@nome); select @@IDENTITY";
                cmd.Parameters.AddWithValue("@nome", modelo.Umed_nome);
                conexao.Conectar();
                modelo.Umed_cod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }


        }

        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "update undmedida set umed_nome = @nome where umed_cod = @codigo;";
                cmd.Parameters.AddWithValue("@nome", modelo.Umed_nome);
                cmd.Parameters.AddWithValue("@codigo", modelo.Umed_cod);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public void Excluir(int codigo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "delete from undmedida where umed_cod = @codigo;";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw new Exception("O registro não pode ser excluido!\nO Registro tem dependências.");

            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from undmedida where umed_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "Select * from undmedida where umed_cod = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                conexao.Conectar();
                SqlDataReader registro = cmd.ExecuteReader();
                if (registro.HasRows)
                {
                    registro.Read();
                    modelo.Umed_cod = Convert.ToInt32(registro["umed_cod"]);
                    modelo.Umed_nome = Convert.ToString(registro["umed_nome"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            conexao.Desconectar();
            return modelo;
        }
    }
}

