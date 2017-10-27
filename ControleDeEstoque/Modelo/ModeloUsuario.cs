using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUsuario
    {
        public ModeloUsuario()
        {
            this.UsCod = 0;
            this.UsNome = "";
            this.UsSenha = "";
        }

        public ModeloUsuario(int uscod, String ususuario, String ussenha)
        {
            this.UsCod = uscod;
            this.UsNome = ususuario;
            this.UsSenha = ussenha;
        }

        private int us_cod;

        public int UsCod
        {
            get { return this.us_cod; }
            set { this.us_cod = value; }
        }

        private String us_nome;

        public String UsNome
        {
            get { return this.us_nome; }
            set { this.us_nome = value; }
        }

        private String us_senha;

        public String UsSenha
        {
            get { return this.us_senha; }
            set { this.us_senha = value; }
        }        
        
    }
}
