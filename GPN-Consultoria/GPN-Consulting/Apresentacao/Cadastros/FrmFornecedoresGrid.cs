﻿using System;
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
    public partial class FrmFornecedoresGrid : Form
    {
        public FrmFornecedoresGrid()
        {
            InitializeComponent();           
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmFornecedorCadastro frmFornecedorCadastro = new FrmFornecedorCadastro();
            frmFornecedorCadastro.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FrmFornecedorCadastro frmFornecedorCadastro = new FrmFornecedorCadastro();
            frmFornecedorCadastro.ShowDialog();
        }
    }
}
