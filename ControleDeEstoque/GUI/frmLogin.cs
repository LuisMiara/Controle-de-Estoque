using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(conexao);
            Boolean permissao = bll.Autenticar(txtUsuario.Text, txtSenha.Text);
            if (permissao)
            {
                this.Hide();
                frmPrincipal f = new frmPrincipal();
                f.ShowDialog();
                f.Dispose();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Dados incorretos!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                DadosDaConexao.servidor = arquivo.ReadLine();
                DadosDaConexao.banco = arquivo.ReadLine();
                DadosDaConexao.usuario = arquivo.ReadLine();
                DadosDaConexao.senha = arquivo.ReadLine();
                arquivo.Close();
                //testar a conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Dados de conexão com o banco incorretos!\nEntre em contato com o suporte.");
                frmConfiguracaoBancoDados f = new frmConfiguracaoBancoDados();
                f.ShowDialog();
                f.Dispose();
            }
            
        }
    }
}
