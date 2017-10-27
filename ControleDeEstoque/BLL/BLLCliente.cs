using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;
using Modelo;
using Ferramentas;
using System.Data;
using System.Text.RegularExpressions;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }
            

            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O campo CPF/CNPJ do cliente é obrigatório.");
            }

            //valida CPF_CNPJ
            if (modelo.CliTipo == "FISICA")
            {
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo CPF do cliente é inválido.");
                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo CNPJ do cliente é inválido.");
                }

            }


            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O campo de RG/IE do cliente é obrigatório.");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório.");
            }

            //validando o e-mail
            if (Validacao.ValidaEmail(modelo.CliEmail) == false)
            {
                throw new Exception("Digite um e-mail valido!");
            }

            //validando o cep
            if (Validacao.ValidaCep(modelo.CliCep) == false)
            {
                throw new Exception("Digite um CEP valido!");
            }

            //validando o telefone
            if (Validacao.ValidaTelefone(modelo.CliFone) == false)
            {
                throw new Exception("Digite um telefone valido!");
            }
            //valida RG
            if (modelo.CliTipo == "FISICA")
            {
                if (Validacao.ValidaRG(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo RG do cliente é inválido.");
                }
            }


            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);

        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.CliNome.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatório.");
            }


            if (modelo.CliCpfCnpj.Trim().Length == 0)
            {
                throw new Exception("O campo CPF/CNPJ do cliente é obrigatório.");
            }
            //verificar CPF_CNPJ

            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O campo de RG/IE do cliente é obrigatório.");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório.");
            }

            //valida CPF_CNPJ
            if (modelo.CliTipo == "FISICA")
            {
                if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo CPF do cliente é inválido.");
                }
            }
            else
            {
                if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo CNPJ do cliente é inválido.");
                }

            }


            if (modelo.CliRgIe.Trim().Length == 0)
            {
                throw new Exception("O campo de RG/IE do cliente é obrigatório.");
            }

            if (modelo.CliFone.Trim().Length == 0)
            {
                throw new Exception("O telefone do cliente é obrigatório.");
            }

            //validando o e-mail
            if (Validacao.ValidaEmail(modelo.CliEmail) == false)
            {
                throw new Exception("Digite um e-mail valido!");
            }

            //validando o cep
            if (Validacao.ValidaCep(modelo.CliCep) == false)
            {
                throw new Exception("Digite um CEP valido!");
            }

            //validando o telefone
            if (Validacao.ValidaTelefone(modelo.CliFone) == false)
            {
                throw new Exception("Digite um telefone valido!");
            }
            //validando RG
            if (modelo.CliTipo == "FISICA")
            {
                if (Validacao.ValidaRG(modelo.CliCpfCnpj) == false)
                {
                    throw new Exception("O campo RG do cliente é inválido.");
                }
            }

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);

        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);

        }

        public DataTable LocalizarCpfCnpj(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.LocalizarCpfCnpj(valor);

        }

        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);

        }

        public ModeloCliente CarregaModeloCliente(String cpfcnpj)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(cpfcnpj);

        }
    }
}
