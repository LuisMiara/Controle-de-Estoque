using DAL;
using Ferramentas;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFornecedor
    {
        private DALConexao conexao;

        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }


            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O campo CNPJ do cliente é obrigatório.");
            }

            //valida CPF_CNPJ 
            // Não funciona,validar
           /*if (Validacao.IsCnpj(modelo.ForCnpj) == false)
           {
               throw new Exception("O campo CNPJ do cliente é inválido.");
           }*/


            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O campo de IE do cliente é obrigatório.");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório.");
            }

            //validando o e-mail
            if (Validacao.ValidaEmail(modelo.ForEmail) == false)
            {
                throw new Exception("Digite um e-mail valido!");
            }

            //validando o cep
            if (Validacao.ValidaCep(modelo.ForCep) == false)
            {
                throw new Exception("Digite um CEP valido!");
            }

            //validando o telefone
            if (Validacao.ValidaTelefone(modelo.ForFone) == false)
            {
                throw new Exception("Digite um telefone valido!");
            }


            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloFornecedor modelo)
        {
            if (modelo.ForNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }


            if (modelo.ForCnpj.Trim().Length == 0)
            {
                throw new Exception("O campo CPF/CNPJ do cliente é obrigatório.");
            }
            //valida CPF_CNPJ
            //Não ta funcionando, arrumar
            /*if (Validacao.IsCnpj(modelo.ForCnpj) == false)
            {
                throw new Exception("O campo CNPJ do cliente é inválido.");
            }*/


            if (modelo.ForIe.Trim().Length == 0)
            {
                throw new Exception("O campo de IE do cliente é obrigatório.");
            }

            if (modelo.ForFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório.");
            }

            //validando o e-mail
            if (Validacao.ValidaEmail(modelo.ForEmail) == false)
            {
                throw new Exception("Digite um e-mail valido!");
            }

            //validando o cep
            if (Validacao.ValidaCep(modelo.ForCep) == false)
            {
                throw new Exception("Digite um CEP valido!");
            }

            //validando o telefone
            if (Validacao.ValidaTelefone(modelo.ForFone) == false)
            {
                throw new Exception("Digite um telefone valido!");
            }

            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            DALobj.Excluir(codigo);

        }

        public DataTable Localizar(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.Localizar(valor);

        }

        public DataTable LocalizarCnpj(String valor)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.LocalizarCnpj(valor);

        }

        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(codigo);

        }

        public ModeloFornecedor CarregaModeloFornecedor(String cpfcnpj)
        {
            DALFornecedor DALobj = new DALFornecedor(conexao);
            return DALobj.CarregaModeloFornecedor(cpfcnpj);

        }
    }
}
