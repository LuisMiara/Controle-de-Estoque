﻿using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALProduto
    {
        private DALConexao conexao;

        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into produto(pro_nome, pro_descricao, pro_foto, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod) values" + 
                "(@nome, @descricao, @foto, @valorpago, @valorvenda, @qtde, @undmedcod, @catcod, @scatcod); select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }else
            {
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@undmedcod", modelo.ProUmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.ProCatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ProScatCod);
            conexao.Conectar();
            modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloProduto modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update produto set pro_nome = @nome, pro_descricao = @descricao, pro_foto = @foto, pro_valorpago = @valorpago, pro_valorvenda = @valorvenda," + 
                "pro_qtde = @qtde, umed_cod = @umedcod, cat_cod = @catcod, scat_cod = @scatcod where pro_cod = @procodigo";

            cmd.Parameters.AddWithValue("@nome", modelo.ProNome);
            cmd.Parameters.AddWithValue("@descricao", modelo.ProDescricao);
            cmd.Parameters.Add("@foto", System.Data.SqlDbType.Image);
            if (modelo.ProFoto == null)
            {
                cmd.Parameters["@foto"].Value = DBNull.Value;
            }
            else
            {
                cmd.Parameters["@foto"].Value = modelo.ProFoto;
            }
            cmd.Parameters.AddWithValue("@valorpago", modelo.ProValorPago);
            cmd.Parameters.AddWithValue("@valorvenda", modelo.ProValorVenda);
            cmd.Parameters.AddWithValue("@qtde", modelo.ProQtde);
            cmd.Parameters.AddWithValue("@umedcod", modelo.ProUmedCod);
            cmd.Parameters.AddWithValue("@catcod", modelo.ProCatCod);
            cmd.Parameters.AddWithValue("@scatcod", modelo.ProScatCod);
            cmd.Parameters.AddWithValue("@procodigo", modelo.ProCod);
            conexao.Conectar();
            modelo.ProCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from produto where pro_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_foto, p.pro_valorpago, p.pro_valorvenda, p.pro_qtde,"+
                " p.umed_cod, p.cat_cod, p.scat_cod, u.umed_nome, c.cat_nome, sc.scat_nome from Produto p inner join undmedida u on p.umed_cod = u.umed_cod inner join"+
                " categoria c on p.cat_cod = c.cat_cod inner join subcategoria sc on p.scat_cod = sc.scat_cod where p.pro_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "select * from produto where pro_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ProCod = Convert.ToInt32(registro["pro_cod"]);
                modelo.ProNome = Convert.ToString(registro["pro_nome"]);
                modelo.ProDescricao = Convert.ToString(registro["pro_descricao"]);
                try
                {
                    modelo.ProFoto = (byte[])registro["pro_foto"];
                }
                catch { }
                modelo.ProValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                modelo.ProValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                modelo.ProQtde = Convert.ToInt32(registro["pro_qtde"]);
                modelo.ProUmedCod = Convert.ToInt32(registro["umed_cod"]);
                modelo.ProCatCod = Convert.ToInt32(registro["cat_cod"]);
                modelo.ProScatCod = Convert.ToInt32(registro["scat_cod"]);

            }
            conexao.Desconectar();
            return modelo;
        }

    }
}
