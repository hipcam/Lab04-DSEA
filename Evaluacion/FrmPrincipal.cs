using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void lISTADEPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            FrmListaRapida f1 = new FrmListaRapida();
            f1.Show();
        }

        private void lISTADECLIENTESPORPAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientesPorPais f1 = new FrmClientesPorPais();
            f1.Show();
        }

        private void lISTADEPROVEEDORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores f1 = new FrmProveedores();
            f1.Show();
        }

        private void lISTADEPRODUCTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProductos f1 = new FrmProductos();
            f1.Show();
        }

        private void lISTADEPEDIDOSYDETALLESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedidos f1 = new FrmPedidos();
            f1.Show();
        }
    }
}
