using BLL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroProduto : GUI.frmModeloDeFormularioDeCadastro
    {
        public String foto = "";

        public frmCadastroProduto()
        {
            InitializeComponent();
        }

        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
            txtValorPago.Clear();
            txtValorVenda.Clear();
            txtQuantidade.Clear();
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            //Combo da categoria
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(conexao);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";
            //cbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            //cbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;

            try
            {
                //Combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(conexao);
                cbSubcategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubcategoria.DisplayMember = "scat_nome";
                cbSubcategoria.ValueMember = "scat_cod";
            }
            catch
            {
                MessageBox.Show("Cadastre uma categoria!");
            }
            
            
            //Combo da unidade de medida
            BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(conexao);
            cbUnd.DataSource = ubll.Localizar("");
            cbUnd.DisplayMember = "umed_nome";
            cbUnd.ValueMember = "umed_cod";

            conexao.Desconectar();


        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorVenda.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtValorPago.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            if (txtValorVenda.Text.Contains(",") == false)
            {
                txtValorVenda.Text += ",00";
            }
            else
            {
                if(txtValorVenda.Text.IndexOf(",") == txtValorVenda.Text.Length - 1)
                {
                    txtValorVenda.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorVenda.Text);
            }
            catch
            {
                txtValorVenda.Text = "0.00";
            }
        }

        private void txtValorPago_Leave(object sender, EventArgs e)
        {
            if (txtValorPago.Text.Contains(",") == false)
            {
                txtValorPago.Text += ",00";
            }
            else
            {
                if (txtValorPago.Text.IndexOf(",") == txtValorPago.Text.Length - 1)
                {
                    txtValorPago.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtValorPago.Text);
            }
            catch
            {
                txtValorPago.Text = "0.00";
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (!txtQuantidade.Text.Contains(","))
                {
                    e.KeyChar = ',';
                }
                else e.Handled = true;
            }

        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Contains(",") == false)
            {
                txtQuantidade.Text += ",00";
            }
            else
            {
                if (txtQuantidade.Text.IndexOf(",") == txtQuantidade.Text.Length - 1)
                {
                    txtQuantidade.Text += "00";
                }
            }
            try
            {
                Double d = Convert.ToDouble(txtQuantidade.Text);
            }
            catch
            {
                txtQuantidade.Text = "0.00";
            }

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                //Combo da subcategoria
                cbSubcategoria.Text = "";
                BLLSubCategoria sbll = new BLLSubCategoria(conexao);
                cbSubcategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubcategoria.DisplayMember = "scat_nome";
                cbSubcategoria.ValueMember = "scat_cod";
            }
            catch
            {
               // MessageBox.Show("Cadastre uma categoria!");
            }


        }

        private void btLoFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            if (!string.IsNullOrEmpty(od.FileName))
            {
                this.foto = od.FileName;
                pbFoto.Load(this.foto);
            }
        }

        private void btRmFoto_Click(object sender, EventArgs e)
        {
            this.foto = "";
            pbFoto.Image = null;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
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

            }
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
            }
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaProduto f = new frmConsultaProduto();
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
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btAddCategoria_Click(object sender, EventArgs e)
        {
            frmCadastroCategoria f = new frmCadastroCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCategoria bll = new BLLCategoria(conexao);
            cbCategoria.DataSource = bll.Localizar("");
            cbCategoria.DisplayMember = "cat_nome";
            cbCategoria.ValueMember = "cat_cod";

            try
            {
                //Combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(conexao);
                cbSubcategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubcategoria.DisplayMember = "scat_nome";
                cbSubcategoria.ValueMember = "scat_cod";
            }
            catch
            {
                MessageBox.Show("Cadastre uma categoria!");
            }

            conexao.Desconectar();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCadastroSubCategoria f = new frmCadastroSubCategoria();
            f.ShowDialog();
            f.Dispose();
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                //Combo da subcategoria
                BLLSubCategoria sbll = new BLLSubCategoria(conexao);
                cbSubcategoria.DataSource = sbll.LocalizarPorCategoria((int)cbCategoria.SelectedValue);
                cbSubcategoria.DisplayMember = "scat_nome";
                cbSubcategoria.ValueMember = "scat_cod";
            }
            catch
            {
                MessageBox.Show("Cadastre uma categoria!");
            }

            conexao.Desconectar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmCadastroUnidadeDeMedida f = new frmCadastroUnidadeDeMedida();
            f.ShowDialog();
            f.Dispose();
            DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                //Combo da unidade de medida
                BLLUnidadeDeMedida ubll = new BLLUnidadeDeMedida(conexao);
                cbUnd.DataSource = ubll.Localizar("");
                cbUnd.DisplayMember = "umed_nome";
                cbUnd.ValueMember = "umed_cod";

     
            conexao.Desconectar();
        }
    }
}
