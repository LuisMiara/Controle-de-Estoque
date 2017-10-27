using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloProduto
    {
        public ModeloProduto()
        {
            this.pro_cod = 0;
            this.pro_nome = "";
            this.pro_descricao = "";
            //Foto null
            this.pro_valorpago = 0;
            this.pro_valorvenda = 0;
            this.pro_qtde = 0;
            this.umed_cod = 0;
            this.cat_cod = 0;
            this.scat_cod = 0;
                       
        }

        public ModeloProduto(int procod, String pronome, String prodescricao, byte[] profoto, Double valorpago, Double valorvenda,
            Double proqtde, int umecod, int catcod, int scatcod)
        {
            this.pro_cod = procod;
            this.pro_nome = pronome;
            this.pro_descricao = prodescricao;
            this.pro_foto = profoto;
            this.pro_valorpago = valorpago;
            this.pro_valorvenda = valorvenda;
            this.pro_qtde = proqtde;
            this.umed_cod = umecod;
            this.cat_cod = catcod;
            this.scat_cod = scatcod;

        }

        public ModeloProduto(int procod, String pronome, String prodescricao, String profoto, Double valorpago, Double valorvenda, 
            Double proqtde, int umecod, int catcod, int scatcod)
        {
            this.pro_cod = procod;
            this.pro_nome = pronome;
            this.pro_descricao = prodescricao;
            this.CarregaImagem(profoto);
            this.pro_valorpago = valorpago;
            this.pro_valorvenda = valorvenda;
            this.pro_qtde = proqtde;
            this.umed_cod = umecod;
            this.cat_cod = catcod;
            this.scat_cod = scatcod;

        }

        private int pro_cod;

        public int ProCod
        {
            get { return this.pro_cod; }
            set { this.pro_cod = value; }
        }

        private String pro_nome;

        public String ProNome
        {
            get { return this.pro_nome; }
            set { this.pro_nome = value; }
        }

        private String pro_descricao;

        public String ProDescricao
        {
            get { return this.pro_descricao; }
            set { this.pro_descricao = value; }
        }

        private byte[] pro_foto;

        public byte[] ProFoto
        {
            get { return this.pro_foto; }
            set { this.pro_foto = value; }
        }

        public void CarregaImagem(String imgCaminho)
        {
            try
            {
                if (!string.IsNullOrEmpty(imgCaminho))
                {
                    FileInfo arqImagem = new FileInfo(imgCaminho);

                    FileStream fs = new FileStream(imgCaminho, FileMode.Open, FileAccess.Read, FileShare.Read);

                    this.pro_foto = new byte[Convert.ToInt32(arqImagem.Length)];

                    int iBytesRead = fs.Read(this.pro_foto,0, Convert.ToInt32(arqImagem.Length));

                    fs.Close();
                }

            }
            catch(Exception erro)
            {
                throw new Exception(erro.Message.ToString());
            }
        }

        private Double pro_valorpago;

        public Double ProValorPago
        {
            get { return this.pro_valorpago; }
            set { this.pro_valorpago = value; }
        }

        private Double pro_valorvenda;

        public Double ProValorVenda
        {
            get { return this.pro_valorvenda; }
            set { this.pro_valorvenda = value; }
        }

        private Double pro_qtde;

        public Double ProQtde
        {
            get { return this.pro_qtde; }
            set { this.pro_qtde = value; }
        }

        private int umed_cod;

        public int ProUmedCod
        {
            get { return this.umed_cod; }
            set { this.umed_cod = value; }
        }

        private int cat_cod;

        public int ProCatCod
        {
            get { return this.cat_cod; }
            set { this.cat_cod = value; }
        }

        private int scat_cod;

        public int ProScatCod
        {
            get { return this.scat_cod; }
            set { this.scat_cod = value; }
        }



    }
}
