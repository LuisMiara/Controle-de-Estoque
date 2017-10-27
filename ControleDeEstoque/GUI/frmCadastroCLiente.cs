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
    public partial class frmCadastroCliente : GUI.frmModeloDeFormularioDeCadastro
    {
        public void LimpaTela()
        {
            txtBairro.Clear();
            txtCelular.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtCodigo.Clear();
            txtCpfCnpj.Clear();
            txtEmail.Clear();
            txtEstado.Clear();
            txtNome.Clear();
            txtNumero.Clear();
            txtRgIe.Clear();
            txtRSocial.Clear();
            txtRua.Clear();
            txtTelefone.Clear();
            rdFisica.Checked = true;
        }
        public frmCadastroCliente()
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
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(conexao);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.CliCod.ToString();
                txtNome.Text = modelo.CliNome.ToString();
                txtBairro.Text = modelo.CliBairro.ToString();
                txtCelular.Text = modelo.CliCel.ToString();
                txtCep.Text = modelo.CliCep.ToString();
                txtCidade.Text = modelo.CliCidade.ToString();
                txtCodigo.Text = modelo.CliCod.ToString();
                txtCpfCnpj.Text = modelo.CliCpfCnpj.ToString();
                txtEmail.Text = modelo.CliEmail.ToString();
                txtEstado.Text = modelo.CliEstado.ToString();
                txtNome.Text = modelo.CliNome.ToString();
                txtNumero.Text = modelo.CliEndNumero.ToString();
                txtRgIe.Text = modelo.CliRgIe.ToString();
                txtRSocial.Text = modelo.CliRSocial.ToString();
                txtRua.Text = modelo.CliEndereco.ToString();
                txtTelefone.Text = modelo.CliFone.ToString();
                if(modelo.CliTipo == "FISICA")
                {
                    rdFisica.Checked = true;
                    rdJuridica.Checked = false;
                    lbCpfCnpj.Text = "CPF";
                    lbRgIe.Text = "RG";
                    lbRSocial.Visible = false;
                    txtRSocial.Visible = false;
                }else
                {
                    rdJuridica.Checked = true;
                    rdFisica.Checked = false;
                    lbCpfCnpj.Text = "CNPJ";
                    lbRgIe.Text = "IE";
                    lbRSocial.Visible = true;
                    txtRSocial.Visible = true;
                }
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
                    BLLCliente bll = new BLLCliente(conexao);
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

        private void frmCadastroCLiente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            txtNome.Focus();
        }

        private void rdFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdFisica.Checked == true)
            {
                lbRSocial.Visible = false;
                txtRSocial.Visible = false;
                lbCpfCnpj.Text = "CPF";
                lbRgIe.Text = "RG";
            }
            else
            {
                lbRSocial.Visible = true;
                txtRSocial.Visible = true;
                lbCpfCnpj.Text = "CNPJ";
                lbRgIe.Text = "IE";
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //lendo os dados tela
                ModeloCliente modelo = new ModeloCliente();
                modelo.CliBairro = txtBairro.Text;
                modelo.CliCel = txtCelular.Text;
                modelo.CliCep = txtCep.Text;
                modelo.CliCidade = txtCidade.Text;
                modelo.CliCpfCnpj = txtCpfCnpj.Text;
                modelo.CliEmail = txtEmail.Text;
                modelo.CliEstado = txtEstado.Text;
                modelo.CliNome = txtNome.Text;
                modelo.CliEndNumero = txtNumero.Text;
                modelo.CliRgIe = txtRgIe.Text;
                modelo.CliRSocial = txtRSocial.Text;
                modelo.CliEndereco = txtRua.Text;
                modelo.CliFone = txtTelefone.Text;
                if (rdFisica.Checked == true)
                {
                    modelo.CliTipo = "FISICA";
                    modelo.CliRSocial = "";
                }
                else
                {
                    modelo.CliTipo = "JURIDICA";
                }
                    
                //conexao ao banco
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(conexao);
                if (this.operacao == "inserir")
                {
                    //cadastrar uma nova categoria
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.CliCod.ToString());
                }
                else
                {
                    //alterar uma categoria
                    modelo.CliCod = Convert.ToInt32(txtCodigo.Text);
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

        private void txtCep_Leave(object sender, EventArgs e)
        {
            lbValorIncorretoCep.Visible = false;
            if(Validacao.ValidaCep(txtCep.Text) == false)
            {
                lbValorIncorretoCep.Visible = true;
            }else
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
            if(e.KeyChar != (char)8)
            {
                Formatar(Campo.CEP, txtCep);
            }

        }

        private void txtCpfCnpj_Leave(object sender, EventArgs e)
        {
            lbValorIncorreto.Visible = false;
            if (rdFisica.Checked == true)
            {
                //cpf
                if (Validacao.IsCpf(txtCpfCnpj.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }
               
            }
            else
            {
                if (Validacao.IsCnpj(txtCpfCnpj.Text) == false)
                {
                    lbValorIncorreto.Visible = true;
                }

            }
        }

        private void txtCpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                if (rdFisica.Checked == true)
                {
                    Formatar(Campo.CPF, txtCpfCnpj);
                }
                else
                {
                    Formatar(Campo.CNPJ, txtCpfCnpj);
                }

            }
            
            
        }

        private void txtRgIe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)8)
            {
                if (rdFisica.Checked == true)
                {
                    Formatar(Campo.RG, txtRgIe);
                }
                else
                {
                    Formatar(Campo.IE, txtRgIe);
                }

            }
        }

        private void txtRgIe_Leave(object sender, EventArgs e)
        {
            lbValorIncorretoRgIe.Visible = false;
            if(rdFisica.Checked == true)
            {
                if(Validacao.ValidaRG(txtRgIe.Text) == false)
                {
                    lbValorIncorretoRgIe.Visible = true;
                }
            }
        }
    }
}
