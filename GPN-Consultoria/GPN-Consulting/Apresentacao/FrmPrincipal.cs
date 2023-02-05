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

namespace Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuCliente_Click(object sender, EventArgs e)
        {
            FrmClientesGrid frmClientesGrid = new FrmClientesGrid();
            frmClientesGrid.MdiParent = this;
            frmClientesGrid.Show();
        }

        private void mnuFornecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedoresGrid frmFornecedoresGrid = new FrmFornecedoresGrid();
            frmFornecedoresGrid.MdiParent = this;
            frmFornecedoresGrid.Show();
        }

        private void mnuConsultores_Click(object sender, EventArgs e)
        {
            FrmConsultoresGrid frmConsultoresGrid = new FrmConsultoresGrid();
            frmConsultoresGrid.MdiParent = this;
            frmConsultoresGrid.Show();
        }
    }
}
