using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ferramentas
{
    public class Validacao
    {
        //valida CPF
        public static bool IsCpf(String cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] {11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempCpf, digito;

            cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

            if (cpf.Length != 11)
            {
                return false;
            }
            else
            {
                tempCpf = cpf.Substring(0, 9);
                soma = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
                }

                resto = soma % 11;
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                tempCpf = tempCpf + digito;

                soma = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                }

                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString();
                return cpf.EndsWith(digito);
            }
         }


        public static bool IsCnpj(String cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2}; 
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma, resto;
            string tempcnpj, digito;

            cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");

            
            if (cnpj.Length != 14)
            {
                return false;
            }
            else
            {
                tempcnpj = cnpj.Substring(0, 12);
                soma = 0;
                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(tempcnpj[i].ToString()) * multiplicador1[i];
                }

                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = resto.ToString();
                tempcnpj = tempcnpj + digito;

                soma = 0;
                for (int i = 0; i < 13; i++)
                {
                    soma += int.Parse(tempcnpj[i].ToString()) * multiplicador2[i];
                }

                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                digito = digito + resto.ToString();
                return cnpj.EndsWith(digito);
            }


        }

        public static bool ValidaEmail(String valor)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (!rg.IsMatch(valor))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidaCep(String valor)
        {
            Regex rg = new Regex(@"^\d{5}-\d{3}$");
            if (!rg.IsMatch(valor))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidaTelefone(String valor)
        {
            Regex rg = new Regex(@"^\(\d{2}\)\d{4}-\d{4}$");
            if (!rg.IsMatch(valor))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidaCelular(String valor)
        {
            Regex rg = new Regex(@"^\(\d{2}\)\d{5}-\d{4}$");
            if (!rg.IsMatch(valor))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidaRG(String valor)
        {
            int digito = valor.Length;
            if (digito != 12)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public static bool ValidaIE(String valor)
        {
            int digito = valor.Length;
            if (digito != 12)
            {
                return false;
            }
            else
            {
                return true;
            }

        }


    }
}

