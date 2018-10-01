using System;
using System.Windows.Forms;
using Siseve.UI.Utilitarios;

namespace Siseve.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuCliente_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmTipoevento();
            form.Show();
        }

        private void tipoDeContatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmTipoContato();
            form.Show();
        }

        private void mnuFormaPagto_Click(object sender, EventArgs e)
        {
            var form = new frmFormaPagamento();
            form.Show();
        }

        private void tipoDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmTipoServico();
            form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
