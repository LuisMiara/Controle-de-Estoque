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
    public partial class frmCadastroSubCategoria : GUI.frmModeloDeFormularioDeCadastro
    {
        public frmCadastroSubCategoria()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtNome.Clear();
            txtScatCodigo.Clear();
        }

        private void frmCadastroSubCategoria_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(conexao);

            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);

            try
            {
                //lendo os dados tela
                ModeloSubCategoria modelo = new ModeloSubCategoria();
                modelo.ScatNome = txtNome.Text;
                modelo.CatCod = Convert.ToInt32(cbCatCod.SelectedValue);
                //conexao ao banco
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma nova categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ScatCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.ScatCod = Convert.ToInt32(txtScatCodigo.Text);
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

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
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
                    BLLSubCategoria bll = new BLLSubCategoria(conexao);
                    bll.Excluir(Convert.ToInt32(txtScatCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro!\n O registro possui dependências.");
                this.alteraBotoes(3);
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
             frmConsultaSubCategoria f = new frmConsultaSubCategoria();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);
                ModeloSubCategoria modelo = bll.CarregaModeloSubCategoria(f.codigo);
                txtScatCodigo.Text = modelo.ScatCod.ToString();
                txtNome.Text = modelo.ScatNome.ToString();
                cbCatCod.SelectedValue = modelo.CatCod;
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(conexao);
            cbCatCod.DataSource = bll.Localizar("");
            cbCatCod.DisplayMember = "cat_nome";
            cbCatCod.ValueMember = "cat_cod";

        }
    }
}
