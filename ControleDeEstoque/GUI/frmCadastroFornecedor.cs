using BLL;
using DAL;
using Modelo;
using System;
using Ferramentas;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroFornecedor : GUI.frmModeloDeFormularioDeCadastro
    {
        public void LimpaTela()
        {
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtCnpj.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtIe.Clear();
            txtRSocial.Clear();
            txtRua.Clear();
            txtTelefone.Clear();

        }
        public frmCadastroFornecedor()
        {
            InitializeComponent();
        }

        public enum Campo
        {
            CPF = 1,
            CNPJ = 2,
            CEP = 3,
            RG = 4,
            IE = 5
        }

        public void Formatar(Campo Valor, TextBox txtTexto)
        {
            switch (Valor)
            {
                case Campo.CPF:
                    txtTexto.MaxLength = 14;
                    if (txtTexto.Text.Length == 3)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 7)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 11)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CNPJ:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2 || txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.CEP:
                    txtTexto.MaxLength = 9;
                    if (txtTexto.Text.Length == 5)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.RG:
                    txtTexto.MaxLength = 12;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
                case Campo.IE:
                    txtTexto.MaxLength = 18;
                    if (txtTexto.Text.Length == 2)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 6)
                    {
                        txtTexto.Text = txtTexto.Text + ".";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 10)
                    {
                        txtTexto.Text = txtTexto.Text + "/";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    else if (txtTexto.Text.Length == 15)
                    {
                        txtTexto.Text = txtTexto.Text + "-";
                        txtTexto.SelectionStart = txtTexto.Text.Length + 1;
                    }
                    break;
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            this.LimpaTela();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
            txtNome.Focus();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaFornecedor f = new frmConsultaFornecedor();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                ModeloFornecedor modelo = bll.CarregaModeloFornecedor(f.codigo);
                txtCodigo.Text = modelo.ForCod.ToString();
                txtNome.Text = modelo.ForNome.ToString();
                txtBairro.Text = modelo.ForBairro.ToString();
                txtCelular.Text = modelo.ForCel.ToString();
                txtCep.Text = modelo.ForCep.ToString();
                txtCidade.Text = modelo.ForCidade.ToString();
                txtCodigo.Text = modelo.ForCod.ToString();
                txtCnpj.Text = modelo.ForCnpj.ToString();
                txtEmail.Text = modelo.ForEmail.ToString();
                txtEstado.Text = modelo.ForEstado.ToString();
                txtNome.Text = modelo.ForNome.ToString();
                txtNumero.Text = modelo.ForEndNumero.ToString();
                txtIe.Text = modelo.ForIe.ToString();
                txtRSocial.Text = modelo.ForRSocial.ToString();
                txtRua.Text = modelo.ForEndereco.ToString();
                txtTelefone.Text = modelo.ForFone.ToString();

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
            txtNome.Focus();
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
                    BLLFornecedor bll = new BLLFornecedor(conexao);
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
                ModeloFornecedor modelo = new ModeloFornecedor();

                modelo.ForBairro = txtBairro.Text;
                modelo.ForCel = txtCelular.Text;
                modelo.ForCep = txtCep.Text;
                modelo.ForCidade = txtCidade.Text;
                modelo.ForCnpj = txtCnpj.Text;
                modelo.ForEmail = txtEmail.Text;
                modelo.ForEstado = txtEstado.Text;
                modelo.ForNome = txtNome.Text;
                modelo.ForEndNumero = txtNumero.Text;
                modelo.ForIe = txtIe.Text;
                modelo.ForRSocial = txtRSocial.Text;
                modelo.ForEndereco = txtRua.Text;
                modelo.ForFone = txtTelefone.Text;

                //conexao ao banco
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLFornecedor bll = new BLLFornecedor(conexao);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma nova categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.ForCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.ForCod = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroFornecedor_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            txtNome.Focus();
        }

        private void txtCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {

              Formatar(Campo.CNPJ, txtCnpj);

            }
        }

        private void txtCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (Validacao.IsCnpj(txtCnpj.Text) == false)
            {
                lbValorIncorreto.Visible = true;
            }
        }

        private void txtIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtIe_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIe.Text))
            {
                lbValorIncorretoRgIe.Visible = true;
            }else
            {
                lbValorIncorretoRgIe.Visible = false;
            }
        }

        private void txtCep_Leave(object sender, EventArgs e)
        {
            lbValorIncorretoCep.Visible = false;
            if (Validacao.ValidaCep(txtCep.Text) == false)
            {
                lbValorIncorretoCep.Visible = true;
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCep.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    txtEstado.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtRua.Text = BuscaEndereco.endereco;
                }
                else
                {

                }
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                Formatar(Campo.CEP, txtCep);
            }
        }
    }
}
