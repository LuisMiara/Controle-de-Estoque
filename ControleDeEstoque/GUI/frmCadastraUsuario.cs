using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastraUsuario : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastraUsuario()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(conexao);
                ModeloUsuario modelo = bll.CarregaModeloUsuario(f.codigo);
                txtCodigo.Text = modelo.UsCod.ToString();
                txtUsuario.Text = modelo.UsNome.ToString();
                txtSenha.Text = modelo.UsSenha.ToString();
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                //lendo opcao do usuario
                DialogResult d = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLUsuario bll = new BLLUsuario(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro!\n O registro está sendo usado em outro local.");
                this.alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //lendo os dados tela
                ModeloUsuario modelo = new ModeloUsuario();
                modelo.UsNome = txtUsuario.Text;
                modelo.UsSenha = txtSenha.Text;
                //conexao ao banco
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(conexao);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma nova categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.UsCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.UsCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void frmCadastraUsuario_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }
    }
}
