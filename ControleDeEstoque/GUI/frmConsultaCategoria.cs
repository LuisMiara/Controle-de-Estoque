﻿using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmConsultaCategoria : Form
    {
        public int codigo = 0;
        public frmConsultaCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
           try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCategoria bll = new BLLCategoria(conexao);
                dgvDados.DataSource = bll.Localizar(txtValor.Text);

            }
            catch
            {
                throw new Exception("Erro ao realizar conexão com o banco.");

            }
        }

        private void frmConsultaCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código";
            dgvDados.Columns[0].Width = 50;
            dgvDados.Columns[1].HeaderText = "Categoria";
            dgvDados.Columns[1].Width = 700;

        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
