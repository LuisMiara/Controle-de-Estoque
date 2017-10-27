using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        public ModeloUnidadeDeMedida()
        {
            this.umed_cod = 0;
            this.umed_nome = "";

        }

        public ModeloUnidadeDeMedida(int umedcod, String umednome)
        {
            this.umed_cod = umedcod;
            this.umed_nome = umednome;
        }
        private int umed_cod;

        public int Umed_cod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        private String umed_nome;

        public String Umed_nome
        {
            get { return this.umed_nome; }
            set { this.umed_nome = value; }
        }

    }
}
