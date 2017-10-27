namespace GUI
{
    partial class frmCadastroCliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRSocial = new System.Windows.Forms.Label();
            this.lbCpfCnpj = new System.Windows.Forms.Label();
            this.lbRgIe = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdJuridica = new System.Windows.Forms.RadioButton();
            this.rdFisica = new System.Windows.Forms.RadioButton();
            this.txtRSocial = new System.Windows.Forms.TextBox();
            this.txtCpfCnpj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbValorIncorreto = new System.Windows.Forms.Label();
            this.txtRgIe = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCep = new System.Windows.Forms.TextBox();
            this.lbValorIncorretoCep = new System.Windows.Forms.Label();
            this.lbValorIncorretoRgIe = new System.Windows.Forms.Label();
            this.pnDados.SuspendLayout();
            this.pnBotoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.pnDados.Controls.Add(this.txtRgIe);
            this.pnDados.Controls.Add(this.txtCpfCnpj);
            this.pnDados.Controls.Add(this.txtRSocial);
            this.pnDados.Controls.Add(this.groupBox1);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.lbRgIe);
            this.pnDados.Controls.Add(this.lbCpfCnpj);
            this.pnDados.Controls.Add(this.lbRSocial);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Size = new System.Drawing.Size(760, 388);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // lbRSocial
            // 
            this.lbRSocial.AutoSize = true;
            this.lbRSocial.Location = new System.Drawing.Point(17, 104);
            this.lbRSocial.Name = "lbRSocial";
            this.lbRSocial.Size = new System.Drawing.Size(70, 13);
            this.lbRSocial.TabIndex = 2;
            this.lbRSocial.Text = "Razão Social";
            this.lbRSocial.Visible = false;
            // 
            // lbCpfCnpj
            // 
            this.lbCpfCnpj.AutoSize = true;
            this.lbCpfCnpj.Location = new System.Drawing.Point(22, 148);
            this.lbCpfCnpj.Name = "lbCpfCnpj";
            this.lbCpfCnpj.Size = new System.Drawing.Size(27, 13);
            this.lbCpfCnpj.TabIndex = 3;
            this.lbCpfCnpj.Text = "CPF";
            // 
            // lbRgIe
            // 
            this.lbRgIe.AutoSize = true;
            this.lbRgIe.Location = new System.Drawing.Point(385, 148);
            this.lbRgIe.Name = "lbRgIe";
            this.lbRgIe.Size = new System.Drawing.Size(23, 13);
            this.lbRgIe.TabIndex = 4;
            this.lbRgIe.Text = "RG";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 33);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(20, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(720, 20);
            this.txtNome.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdJuridica);
            this.groupBox1.Controls.Add(this.rdFisica);
            this.groupBox1.Location = new System.Drawing.Point(210, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 47);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo do cliente";
            // 
            // rdJuridica
            // 
            this.rdJuridica.AutoSize = true;
            this.rdJuridica.Location = new System.Drawing.Point(121, 20);
            this.rdJuridica.Name = "rdJuridica";
            this.rdJuridica.Size = new System.Drawing.Size(63, 17);
            this.rdJuridica.TabIndex = 1;
            this.rdJuridica.Text = "Jurídica";
            this.rdJuridica.UseVisualStyleBackColor = true;
            // 
            // rdFisica
            // 
            this.rdFisica.AutoSize = true;
            this.rdFisica.Checked = true;
            this.rdFisica.Location = new System.Drawing.Point(7, 20);
            this.rdFisica.Name = "rdFisica";
            this.rdFisica.Size = new System.Drawing.Size(54, 17);
            this.rdFisica.TabIndex = 0;
            this.rdFisica.TabStop = true;
            this.rdFisica.Text = "Fisíca";
            this.rdFisica.UseVisualStyleBackColor = true;
            this.rdFisica.CheckedChanged += new System.EventHandler(this.rdFisica_CheckedChanged);
            // 
            // txtRSocial
            // 
            this.txtRSocial.Location = new System.Drawing.Point(20, 120);
            this.txtRSocial.Name = "txtRSocial";
            this.txtRSocial.Size = new System.Drawing.Size(720, 20);
            this.txtRSocial.TabIndex = 8;
            this.txtRSocial.Visible = false;
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(20, 165);
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(348, 20);
            this.txtCpfCnpj.TabIndex = 9;
            this.txtCpfCnpj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpfCnpj_KeyPress);
            this.txtCpfCnpj.Leave += new System.EventHandler(this.txtCpfCnpj_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CEP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(157, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Estado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(160, 207);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(151, 20);
            this.txtEstado.TabIndex = 14;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(388, 207);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(352, 20);
            this.txtCidade.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cidade";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(20, 246);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(593, 20);
            this.txtRua.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rua";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(635, 246);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(105, 20);
            this.txtNumero.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Número";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(20, 286);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(720, 20);
            this.txtBairro.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Bairro";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(20, 324);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(720, 20);
            this.txtEmail.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "E-mail";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Telefone";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 346);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Celular";
            // 
            // lbValorIncorreto
            // 
            this.lbValorIncorreto.AutoSize = true;
            this.lbValorIncorreto.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorreto.Location = new System.Drawing.Point(293, 148);
            this.lbValorIncorreto.Name = "lbValorIncorreto";
            this.lbValorIncorreto.Size = new System.Drawing.Size(75, 13);
            this.lbValorIncorreto.TabIndex = 29;
            this.lbValorIncorreto.Text = "Valor incorreto";
            this.lbValorIncorreto.Visible = false;
            // 
            // txtRgIe
            // 
            this.txtRgIe.Location = new System.Drawing.Point(388, 164);
            this.txtRgIe.Name = "txtRgIe";
            this.txtRgIe.Size = new System.Drawing.Size(352, 20);
            this.txtRgIe.TabIndex = 10;
            this.txtRgIe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRgIe_KeyPress);
            this.txtRgIe.Leave += new System.EventHandler(this.txtRgIe_Leave);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(389, 362);
            this.txtCelular.Mask = "(99)99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(351, 20);
            this.txtCelular.TabIndex = 28;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(20, 362);
            this.txtTelefone.Mask = "(99)9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(348, 20);
            this.txtTelefone.TabIndex = 26;
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(20, 207);
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(114, 20);
            this.txtCep.TabIndex = 12;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCep_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.txtCep_Leave);
            // 
            // lbValorIncorretoCep
            // 
            this.lbValorIncorretoCep.AutoSize = true;
            this.lbValorIncorretoCep.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorretoCep.Location = new System.Drawing.Point(59, 191);
            this.lbValorIncorretoCep.Name = "lbValorIncorretoCep";
            this.lbValorIncorretoCep.Size = new System.Drawing.Size(75, 13);
            this.lbValorIncorretoCep.TabIndex = 30;
            this.lbValorIncorretoCep.Text = "Valor incorreto";
            this.lbValorIncorretoCep.Visible = false;
            // 
            // lbValorIncorretoRgIe
            // 
            this.lbValorIncorretoRgIe.AutoSize = true;
            this.lbValorIncorretoRgIe.ForeColor = System.Drawing.Color.Red;
            this.lbValorIncorretoRgIe.Location = new System.Drawing.Point(665, 148);
            this.lbValorIncorretoRgIe.Name = "lbValorIncorretoRgIe";
            this.lbValorIncorretoRgIe.Size = new System.Drawing.Size(75, 13);
            this.lbValorIncorretoRgIe.TabIndex = 31;
            this.lbValorIncorretoRgIe.Text = "Valor incorreto";
            this.lbValorIncorretoRgIe.Visible = false;
            // 
            // frmCadastroCLiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "frmCadastroCLiente";
            this.Text = "Cadastro de cliente";
            this.Load += new System.EventHandler(this.frmCadastroCLiente_Load);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.pnBotoes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtRSocial;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdJuridica;
        private System.Windows.Forms.RadioButton rdFisica;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbRgIe;
        private System.Windows.Forms.Label lbCpfCnpj;
        private System.Windows.Forms.Label lbRSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbValorIncorreto;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.TextBox txtRgIe;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.Label lbValorIncorretoCep;
        private System.Windows.Forms.Label lbValorIncorretoRgIe;
    }
}
