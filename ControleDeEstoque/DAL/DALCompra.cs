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
    public class DALCompra
    {
        private DALConexao conexao;

        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into compra(com_data, com_nfiscal, com_total, com_nparcela, com_status, for_cod, tpa_cod) values (@data, @nfiscal, @total, @nparcela, @status); select @@IDENTITY";
            cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@data", modelo.ComData);
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            conexao.Conectar();
            modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCompra modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update compra set com_data = @data, com_nfiscal = @nfiscal, com_total = @total, com_nparcela = @nparcela, com_status = @status, for_cod = @forcod, tpa_cod = @tpacod where com_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.ComCod);
            cmd.Parameters.Add("@data", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@data", modelo.ComData);
            cmd.Parameters.AddWithValue("@nfiscal", modelo.ComNFiscal);
            cmd.Parameters.AddWithValue("@total", modelo.ComTotal);
            cmd.Parameters.AddWithValue("@nparcelas", modelo.ComNParcelas);
            cmd.Parameters.AddWithValue("@status", modelo.ComStatus);
            cmd.Parameters.AddWithValue("@forcod", modelo.ForCod);
            cmd.Parameters.AddWithValue("@tpacod", modelo.TpaCod);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from compra where com_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from compra where for_cod = "+ codigo , conexao.StringConexao);
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod"
                + "where f.for_cod = "  + codigo.ToString(), conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(String nome)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod"
                + "where f.for_nome = like '%" +  nome + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable Localizar(DateTime DataInicial, DateTime DataFinal)
        {
      
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select c.com_cod, c.com_data, c.com_nfiscal, c.com_nparcelas, c.com_total, c.com_status, c.for_cod, c.tpa_cod, f.for_nome from compra c inner join fornecedor f on c.for_cod = f.for_cod"
                + "where c.com_data between @datainicial and @datafinal";

            cmd.Parameters.Add("@datainicial", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@datainicial", DataInicial);

            cmd.Parameters.Add("@datafinal", System.Data.SqlDbType.DateTime);
            cmd.Parameters.AddWithValue("@datafinal", DataFinal);
            conexao.Conectar();
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabela);
            conexao.Desconectar();
            return tabela;
            
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from compra where com_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                modelo.ComNFiscal = Convert.ToInt32(registro["com_nfiscal"]);
                modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                modelo.ComNParcelas = Convert.ToInt32(registro["com_nparcelas"]);
                modelo.ComStatus = Convert.ToString(registro["com_status"]);
                modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
