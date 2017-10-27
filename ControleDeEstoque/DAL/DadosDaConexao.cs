using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DadosDaConexao
    {
        public static String servidor = " ";
        public static String banco = " ";
        public static String usuario = " ";
        public static String senha = " ";


        public static String StringDeConexao
        {

            get
                {
                    return defineRetorno();
                }
        }

        public static String defineRetorno()
        {
            if(string.IsNullOrEmpty(usuario) && string.IsNullOrEmpty(senha))
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco + ";Integrated Security=True";
            }else
            {
                return "Data Source=" + servidor + ";Initial Catalog=" + banco + ";User=" + usuario + ";Password=" + senha;
            }
        }

    }
}
