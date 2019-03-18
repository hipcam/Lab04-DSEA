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
    public partial class FrmListaRapida : Form
    {
        public FrmListaRapida()
        {
            InitializeComponent();
        }
        ClsDatos c = new ClsDatos();

        private void FrmListaRapida_Load(object sender, EventArgs e)
        {
            c.ListarEmpleados(cboEmpleado);
            c.ListarClientes(cboCliente);
        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboEmpleado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvPedido.DataSource = c.ListarxEmpleado(Convert.ToInt32(cboEmpleado.SelectedValue));
        }

        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvPedido.DataSource = c.ListarxCliente(Convert.ToString(cboCliente.SelectedValue));
        }

        private void chkTodo_CheckedChanged(object sender, EventArgs e)
        {
            dgvPedido.DataSource = c.ListarPedidos();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            DateTime ped = dtpFecha1.Value;
            DateTime ent = dtpFecha2.Value;
            dgvPedido.DataSource = c.ListarxFecha(ped, ent);
        }
    }
}
