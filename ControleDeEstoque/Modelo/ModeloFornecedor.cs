using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFornecedor
    {
        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForRSocial = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndNumero = "";
            this.ForCidade = "";
            this.ForEstado = "";
        }

        public ModeloFornecedor(int forcod, String fornome, String forcnpj, String forrgie, String forrsocial, String fortipo, String forcep
            , String forendereco, String forbairro, String forfone, String forcel, String foremail, String forendnumero, String forcidade,
            String forestado)
        {
            this.ForCod = forcod;
            this.ForNome = fornome;
            this.ForCnpj = forcnpj;
            this.ForIe = forrgie;
            this.ForRSocial = forrsocial;
            this.ForCep = forcep;
            this.ForEndereco = forendereco;
            this.ForBairro = forbairro;
            this.ForFone = forfone;
            this.ForCel = forcel;
            this.ForEmail = foremail;
            this.ForEndNumero = forendnumero;
            this.ForCidade = forcidade;
            this.ForEstado = forestado;
        }

        private int for_cod;

        public int ForCod
        {
            get { return this.for_cod; }
            set { this.for_cod = value; }
        }

        private String for_nome;

        public String ForNome
        {
            get { return this.for_nome; }
            set { this.for_nome = value; }
        }

        private String for_cnpj;

        public String ForCnpj
        {
            get { return this.for_cnpj; }
            set { this.for_cnpj = value; }
        }

        private String for_ie;

        public String ForIe
        {
            get { return this.for_ie; }
            set { this.for_ie = value; }
        }

        private String for_rsocial;

        public String ForRSocial
        {
            get { return this.for_rsocial; }
            set { this.for_rsocial = value; }
        }


        private String for_cep;

        public String ForCep
        {
            get { return this.for_cep; }
            set { this.for_cep = value; }
        }

        private String for_endereco;

        public String ForEndereco
        {
            get { return this.for_endereco; }
            set { this.for_endereco = value; }
        }

        private String for_bairro;

        public String ForBairro
        {
            get { return this.for_bairro; }
            set { this.for_bairro = value; }
        }

        private String for_fome;

        public String ForFone
        {
            get { return this.for_fome; }
            set { this.for_fome = value; }
        }

        private String for_cel;

        public String ForCel
        {
            get { return this.for_cel; }
            set { this.for_cel = value; }
        }

        private String for_email;

        public String ForEmail
        {
            get { return this.for_email; }
            set { this.for_email = value; }
        }

        private String for_endnumero;

        public String ForEndNumero
        {
            get { return this.for_endnumero; }
            set { this.for_endnumero = value; }
        }

        private String for_cidade;

        public String ForCidade
        {
            get { return this.for_cidade; }
            set { this.for_cidade = value; }
        }

        private String for_estado;

        public String ForEstado
        {
            get { return this.for_estado; }
            set { this.for_estado = value; }
        }
    }
}
