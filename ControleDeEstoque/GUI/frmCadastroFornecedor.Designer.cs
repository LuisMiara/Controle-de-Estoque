namespace GUI
{
    partial class frmCadastroFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbValorIncorretoRgIe = new System.Windows.Forms.Label();
            this.lbValorIncorretoCep = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.TextBox();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbIe = new System.Windows.Forms.Label();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.lbValorIncorretoRgIe);
            this.pnDados.Controls.Add(this.lbValorIncorretoCep);
            this.pnDados.Controls.Add(this.txtCep);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.lbValorIncorreto);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtEmail);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtBairro);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtNumero);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtRua);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.txtCidade);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtEstado);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtIe);
            this.pnDados.Controls.Add(this.txtCnpj);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbIe);
            this.pnDados.Controls.Add(this.lbCnpj);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Size = new System.Drawing.Size(760, 381);
            // 
            // btCancelar
            // 
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // lbValorIncorretoRgIe
            // 
            this.lbValorIncorretoRgIe.AutoSize = true;
            this.lbValorIncorretoRgIe.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorretoRgIe.Location = new System.Drawing.Point(478, 131);
            this.lbValorIncorretoRgIe.Name = "lbValorIncorretoRgIe";
            this.lbValorIncorretoRgIe.Size = new System.Drawing.Size(264, 13);
            this.lbValorIncorretoRgIe.TabIndex = 62;
            this.lbValorIncorretoRgIe.Text = "Se o fornecedor não possui IE preencha com ISENTO";
            this.lbValorIncorretoRgIe.Visible = false;
            // 
            // lbValorIncorretoCep
            // 
            this.lbValorIncorretoCep.AutoSize = true;
            this.lbValorIncorretoCep.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorretoCep.Location = new System.Drawing.Point(61, 174);
            this.lbValorIncorretoCep.Name = "lbValorIncorretoCep";
            this.lbValorIncorretoCep.Size = new System.Drawing.Size(75, 13);
            this.lbValorIncorretoCep.TabIndex = 61;
            this.lbValorIncorretoCep.Text = "Valor incorreto";
            this.lbValorIncorretoCep.Visible = false;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(22, 190);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(114, 20);
            this.txtCep.TabIndex = 43;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(22, 345);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(348, 20);
            this.txtTelefone.TabIndex = 57;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(391, 345);
            this.txtCelular.Mask = "(99)99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(351, 20);
            this.txtCelular.TabIndex = 59;
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(295, 131);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(75, 13);
            this.lbValorIncorreto.TabIndex = 60;
            this.lbValorIncorreto.Text = "Valor incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(388, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Celular";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Telefone";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(22, 307);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(720, 20);
            this.txtEmail.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "E-mail";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(22, 269);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(720, 20);
            this.txtBairro.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Bairro";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(637, 229);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 20);
            this.txtNumero.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(634, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Número";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(22, 229);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(593, 20);
            this.txtRua.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Rua";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(390, 190);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(352, 20);
            this.txtCidade.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cidade";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(162, 190);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(151, 20);
            this.txtEstado.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "CEP";
            // 
            // txtIe
            // 
            this.txtIe.Location = new System.Drawing.Point(390, 147);
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(352, 20);
            this.txtIe.TabIndex = 41;
            this.txtIe.Leave += new System.EventHandler(this.txtIe_Leave);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(22, 148);
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(348, 20);
            this.txtCnpj.TabIndex = 40;
            this.txtCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCnpj_KeyPress);
            this.txtCnpj.Leave += new System.EventHandler(this.txtCnpj_Leave);
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(22, 103);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(720, 20);
            this.txtRSocial.TabIndex = 39;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 61);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(720, 20);
            this.txtNome.TabIndex = 38;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(22, 16);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 37;
            // 
            // lbIe
            // 
            this.lbIe.AutoSize = true;
            this.lbIe.Location = new System.Drawing.Point(387, 131);
            this.lbIe.Name = "lbIe";
            this.lbIe.Size = new System.Drawing.Size(17, 13);
            this.lbIe.TabIndex = 36;
            this.lbIe.Text = "IE";
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(24, 131);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(34, 13);
            this.lbCnpj.TabIndex = 35;
            this.lbCnpj.Text = "CNPJ";
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(19, 87);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 34;
            this.lbRSocial.Text = "Razão Social";
            this.lbRSocial.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Código";
            // 
            // frmCadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroFornecedor";
            this.Load += new System.EventHandler(this.frmCadastroFornecedor_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbValorIncorretoRgIe;
        private System.Windows.Forms.Label lbValorIncorretoCep;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.TextBox txtCnpj;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbIe;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
