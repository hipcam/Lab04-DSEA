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
    public partial class FrmProveedores : Form
    {
        public FrmProveedores()
        {
            InitializeComponent();
        }

      private void FrmProveedores_Load(object sender, EventArgs e)
        {
           /* try
            {
                int x;
                x = Convert.ToInt32(dgvPedidos.CurrentRow.Cells[0].Value);
                dgvDetalles.DataSource = obj.ListaDetalle(x);
                txtTotal.Text = obj.PedidoTotal(x).ToString("c");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }*/
        }

        private void lvwProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
