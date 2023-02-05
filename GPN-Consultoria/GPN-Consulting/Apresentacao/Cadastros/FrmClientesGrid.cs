using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Apresentacao.Cadastros;

namespace Apresentacao.Cadastros
{
    public partial class FrmClientesGrid : Form
    {
        public FrmClientesGrid()
        {
            InitializeComponent();
        }

        private void FrmClientesGrid_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmClienteCadastro frmClienteCadastro = new FrmClienteCadastro();
            frmClienteCadastro.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmClienteCadastro frmClienteCadastro = new FrmClienteCadastro();
            frmClienteCadastro.ShowDialog();
        }
    }
}
