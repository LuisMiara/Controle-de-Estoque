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
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "insert into cliente(cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial, cli_tipo, cli_cep, cli_endereco," 
                + "cli_bairro, cli_fone, cli_cel, cli_email, cli_endnumero, cli_cidade, cli_estado) values (@nome, @cpfcnpj, @rgie, @rsocial,"
                + "@tipo, @cep, @endereco, @bairro, @fone, @cel, @email, @endnumero, @cidade, @estado); select @@IDENTITY";
            cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@rgie", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@rsocial", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);

            conexao.Conectar();
            modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloCliente modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "update cliente set cli_nome = @nome, cli_cpfcnpj = @cpfcnpj, cli_rgie =  @rgie, cli_rsocial = @rsocial,"
                + "cli_tipo = @tipo, cli_cep =  @cep, cli_endereco = @endereco, cli_bairro = @bairro, cli_fone = @fone, cli_cel =  @cel,"
                + "cli_email = @email, cli_endnumero = @endnumero, cli_cidade = @cidade, cli_estado = @estado where cli_cod = @cod;";
            cmd.Parameters.AddWithValue("@cod", modelo.CliCod);
            cmd.Parameters.AddWithValue("@nome", modelo.CliNome);
            cmd.Parameters.AddWithValue("@cpfcnpj", modelo.CliCpfCnpj);
            cmd.Parameters.AddWithValue("@rgie", modelo.CliRgIe);
            cmd.Parameters.AddWithValue("@rsocial", modelo.CliRSocial);
            cmd.Parameters.AddWithValue("@tipo", modelo.CliTipo);
            cmd.Parameters.AddWithValue("@cep", modelo.CliCep);
            cmd.Parameters.AddWithValue("@endereco", modelo.CliEndereco);
            cmd.Parameters.AddWithValue("@bairro", modelo.CliBairro);
            cmd.Parameters.AddWithValue("@fone", modelo.CliFone);
            cmd.Parameters.AddWithValue("@cel", modelo.CliCel);
            cmd.Parameters.AddWithValue("@email", modelo.CliEmail);
            cmd.Parameters.AddWithValue("@endnumero", modelo.CliEndNumero);
            cmd.Parameters.AddWithValue("@cidade", modelo.CliCidade);
            cmd.Parameters.AddWithValue("@estado", modelo.CliEstado);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "delete from cliente where cli_cod = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cliente where cli_nome like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarCpfCnpj(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from cliente where cli_cpfcnpj like '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }



        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from cliente where cli_cod = @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRSocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToString(registro["cli_tipo"]);
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);

            }
            conexao.Desconectar();
            return modelo;
        }

        public ModeloCliente CarregaModeloCliente(String cpfcnpj)
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "Select * from cliente where cli_cpfcnpj = @codigo";
            cmd.Parameters.AddWithValue("@codigo", cpfcnpj);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                modelo.CliRSocial = Convert.ToString(registro["cli_rsocial"]);
                modelo.CliTipo = Convert.ToString(registro["cli_tipo"]);
                modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                modelo.CliEndNumero = Convert.ToString(registro["cli_endnumero"]);
                modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                modelo.CliEstado = Convert.ToString(registro["cli_estado"]);

            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
