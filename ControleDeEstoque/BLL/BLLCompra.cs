﻿using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCompra
    {
        private DALConexao conexao;

        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCompra modelo)
        {
            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informada.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código de fornecedor deve ser informada.");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O de parcelas deve ser maior que zero.");
            }

            /*if (modelo.ComData != DateTime.Now)
            {
                throw new Exception("A data da compra difere da data atual.");
            }*/


            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloCompra modelo)
        {

            if (modelo.ComCod <= 0)
            {
                throw new Exception("O código da compra deve ser informada.");
            }


            if (modelo.ComTotal <= 0)
            {
                throw new Exception("O valor da compra deve ser informada.");
            }

            if (modelo.ForCod <= 0)
            {
                throw new Exception("O código de fornecedor deve ser informada.");
            }

            if (modelo.ComNParcelas <= 0)
            {
                throw new Exception("O de parcelas deve ser maior que zero.");
            }

            /*if (modelo.ComData != DateTime.Now)
            {
                throw new Exception("A data da compra difere da data atual.");
            }*/


            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            DALobj.Excluir(codigo);

        }

        public DataTable LocalizarFornecedor(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(codigo);
        }

        public DataTable Localizar(String nome)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(nome);

        }

        public DataTable Localizar(DateTime DataInicial, DateTime DataFinal)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.Localizar(DataInicial, DataFinal);
        }

        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            DALCompra DALobj = new DALCompra(conexao);
            return DALobj.CarregaModeloCompra(codigo);

        }


    }
}