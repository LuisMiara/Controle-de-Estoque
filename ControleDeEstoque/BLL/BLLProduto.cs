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
    public class BLLProduto
    {
        private DALConexao conexao;

        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }

            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatório.");
            }


            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório.");
            }

            if (modelo.ProQtde <= 0)
            {
                throw new Exception("A quantidade do produto é obrigatório.");
            }

            if (modelo.ProCatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }

            if (modelo.ProScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório.");
            }

            if (modelo.ProUmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório.");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloProduto modelo)
        {
            if (modelo.ProNome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }


            if (modelo.ProDescricao.Trim().Length == 0)
            {
                throw new Exception("A descrição do produto é obrigatório.");
            }


            if (modelo.ProValorVenda <= 0)
            {
                throw new Exception("O valor de venda do produto é obrigatório.");
            }

            if (modelo.ProQtde <= 0)
            {
                throw new Exception("A quantidade do produto é obrigatório.");
            }

            if (modelo.ProCatCod <= 0)
            {
                throw new Exception("O código da categoria é obrigatório.");
            }

            if (modelo.ProScatCod <= 0)
            {
                throw new Exception("O código da subcategoria é obrigatório.");
            }

            if (modelo.ProUmedCod <= 0)
            {
                throw new Exception("O código da unidade de medida é obrigatório.");
            }

            if (modelo.ProCod <= 0)
            {
                throw new Exception("O código do produto é obrigatório.");
            }

            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            DALobj.Excluir(codigo);

        }

        public DataTable Localizar(String valor)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.Localizar(valor);

        }

        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            DALProduto DALobj = new DALProduto(conexao);
            return DALobj.CarregaModeloProduto(codigo);

        }
    }
}
