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
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }
        ClsDatos c = new ClsDatos();
        private void txtProducto_TextChanged(object sender, EventArgs e) 
        {
          dgvProductos.DataSource = c.ListaProdxNombre(txtProducto.Text);
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }

    }
}
