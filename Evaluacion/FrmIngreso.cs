using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Evaluacion
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Connection String   
            SqlConnection con = new SqlConnection("Data Source=LAB402-18\\SQLEXPRESS;Initial Catalog=Neptuno;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select nombre, clave from Usuarios where nombre = @name and clave = @clave", con);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@clave", txtClave.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //Connection open here   
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Loggeado con éxito");
                //after successful it will redirect  to next page .  
                this.Hide();
                FrmPrincipal f1 = new FrmPrincipal();
                f1.Show();
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }
    }
}
