using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao.Cadastros
{
    public partial class FrmConsultoresGrid : Form
    {
        public FrmConsultoresGrid()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmConsultorCadastro frmConsultorCadastro = new FrmConsultorCadastro();
            frmConsultorCadastro.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmConsultorCadastro frmConsultorCadastro = new FrmConsultorCadastro();
            frmConsultorCadastro.ShowDialog();
        }
    }
}
