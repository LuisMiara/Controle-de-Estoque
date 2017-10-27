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
    public partial class frmMovimentacaoCompra : GUI.frmModeloDeFormularioDeCadastro
    {
        public double totalCompra = 0;
        public frmMovimentacaoCompra()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodCompra.Clear();
            txtNFiscal.Clear();
            txtCodFornecedor.Clear();
            txtCodProduto.Clear();
            txtQtd.Clear();
            txtValor.Clear();
            txtTotalCompra.Clear();
            dgvItens.Rows.Clear();
            labelFornecedor.Text = "Informe o código do fornecedor ou clique em localizar";

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
            this.totalCompra = 0;
           
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            /*frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);
                ModeloProduto modelo = bll.CarregaModeloProduto(f.codigo);
                txtCodigo.Text = modelo.ProCod.ToString();
                txtNome.Text = modelo.ProNome.ToString();
                txtDescricao.Text = modelo.ProDescricao.ToString();
                txtValorPago.Text = modelo.ProValorPago.ToString();
                txtValorVenda.Text = modelo.ProValorVenda.ToString();
                txtQuantidade.Text = modelo.ProQtde.ToString();
                cbCategoria.SelectedValue = modelo.ProCatCod;
                cbSubcategoria.SelectedValue = modelo.ProScatCod;
                cbUnd.SelectedValue = modelo.ProUmedCod;
                try
                {
                    MemoryStream ms = new MemoryStream(modelo.ProFoto);
                    pbFoto.Image = Image.FromStream(ms);
                }
                catch
                {

                }
                //falta a foto
                this.alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }8*/
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            /*try
            {
                //lendo opcao do usuario
                DialogResult d = MessageBox.Show("Deseja realmente excluir?", "Aviso", MessageBoxButtons.YesNo);

                if (d.ToString() == "Yes")
                {
                    DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLProduto bll = new BLLProduto(conexao);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossível excluir o registro!\n O registro possui dependências.");
                this.alteraBotoes(3);
            }*/
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            /*try
            {
                //lendo os dados tela
                ModeloProduto modelo = new ModeloProduto();
                modelo.ProNome = txtNome.Text;
                modelo.ProDescricao = txtDescricao.Text;
                modelo.ProValorPago = Convert.ToDouble(txtValorPago.Text);
                modelo.ProValorVenda = Convert.ToDouble(txtValorVenda.Text);
                modelo.ProQtde = Convert.ToDouble(txtQuantidade.Text);
                modelo.ProUmedCod = Convert.ToInt32(cbUnd.SelectedValue);
                modelo.ProCatCod = Convert.ToInt32(cbCategoria.SelectedValue);
                modelo.ProScatCod = Convert.ToInt32(cbSubcategoria.SelectedValue);
                modelo.CarregaImagem(this.foto);

                //conexao ao banco
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma nova categoria
                    modelo.CarregaImagem(this.foto);
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ProCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.ProCod = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado!");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }*/
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btLocFor_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCodFornecedor.Text = f.codigo.ToString();
                txtCodFornecedor_Leave(sender, e);
            }
        }

        private void txtCodFornecedor_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(Convert.ToInt32(txtCodFornecedor.Text));
                labelFornecedor.Text = modelo.ForNome;
            }
            catch
            {
                txtCodFornecedor.Clear();
                labelFornecedor.Text = "Informe o código do fornecedor ou clique em localizar";
                
            }
               

        }

        private void btLocProd_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                txtCodProduto.Text = f.codigo.ToString();
                txtCodProduto_Leave(sender, e);
            }
        }

        private void txtCodProduto_Leave(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLProduto bll = new BLLProduto(conexao);
                ModeloProduto modelo = bll.CarregaModeloProduto(Convert.ToInt32(txtCodProduto.Text));
                labelProduto.Text = modelo.ProNome;
                txtQtd.Text = "1";
                txtValor.Text = modelo.ProValorPago.ToString();
            }
            catch
            {
                txtCodProduto.Clear();
                labelFornecedor.Text = "Informe o código do fornecedor ou clique em localizar";

            }
        }
    }

}