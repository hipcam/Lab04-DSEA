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
    public partial class FrmClientesPorPais : Form
    {
        public FrmClientesPorPais()
        {
            InitializeComponent();
        }
        ClsDatos c = new ClsDatos();
        private void FrmClientesPorPais_Load(object sender, EventArgs e)
        {
            c.ListarPaises(cboPais);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string pais = Convert.ToString(cboPais.SelectedValue);
            dgvCliente.DataSource = c.ListarClientesxPais(pais);
        }

        private void cboPais_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            string idcli = Convert.ToString(dgvCliente.Rows[e.RowIndex].Cells["Id"].Value);
            dgvPedidosxCliente.DataSource = c.ListarDetallesxCliente(idcli);
            txtNroPedidos.Text = dgvPedidosxCliente.Rows.Count.ToString();
        }

        private void txtNroPedidos_TextChanged(object sender, EventArgs e)
        {
         
            
        }

        private void dgvPedidosxCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
