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
    public partial class frmConfiguracaoBancoDados : Form
    {
        Boolean opcao = true;
        public frmConfiguracaoBancoDados()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter arquivo = new StreamWriter("ConfiguracaoBanco.txt", false);
                arquivo.WriteLine(txtServidor.Text);
                arquivo.WriteLine(txtBanco.Text);
                arquivo.WriteLine(txtUsuario.Text);
                arquivo.WriteLine(txtSenha.Text);
                arquivo.Close();
                MessageBox.Show("Arquivo de configuração do banco de dados atualizado com sucesso!!!");

            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }
            

        }

        private void frmConfiguracaoBancoDados_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader arquivo = new StreamReader("ConfiguracaoBanco.txt");
                txtServidor.Text = arquivo.ReadLine();
                txtBanco.Text = arquivo.ReadLine();
                txtUsuario.Text = arquivo.ReadLine();
                txtSenha.Text = arquivo.ReadLine();
                arquivo.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro:" + erro);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btTestarConexao_Click(object sender, EventArgs e)
        {
            try
            {
                DadosDaConexao.servidor = txtServidor.Text;
                DadosDaConexao.banco = txtBanco.Text;
                DadosDaConexao.usuario = txtUsuario.Text;
                DadosDaConexao.senha = txtSenha.Text;

                //testar a conexão
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = DadosDaConexao.StringDeConexao;
                conexao.Open();
                conexao.Close();
                MessageBox.Show("Conexão testada com sucesso!!!");
            }
            catch
            {
                MessageBox.Show("Erro ao se conectar no banco de dados.\nVerifique os dados informados.");

            }
            
        }
    }
}
