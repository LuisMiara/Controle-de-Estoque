using BLL;
using DAL;
using Modelo;
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
    public partial class frmConsultaSubCategoria : Form
    {
        public int codigo = 0;

        public frmConsultaSubCategoria()
        {
            InitializeComponent();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DALConexao conexao = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSubCategoria bll = new BLLSubCategoria(conexao);
                dgvDados.DataSource = bll.Localizar(txtValor.Text);

            }
            catch
            {
                throw new Exception("Erro ao realizar conexão com o banco.");
            }
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaSubCategoria_Load(object sender, EventArgs e)
        {
            btnLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "Código da Subcategoria";
            dgvDados.Columns[0].Width = 100;
            dgvDados.Columns[1].HeaderText = "Sucategoria";
            dgvDados.Columns[1].Width = 400;
            dgvDados.Columns[2].HeaderText = "Código da Categoria";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Nome da Categoria";
            dgvDados.Columns[3].Width = 400;
        }
    }
}

