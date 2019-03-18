using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Evaluacion
{
    class ClsDatos : Conexion
    {
        SqlConnection cn = new SqlConnection();

        public void ListarPaises(ComboBox cbo)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("usp_ListarPais ", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);

            cbo.DataSource = dt;
            cbo.DisplayMember = "Pais";
            cbo.ValueMember = "Pais";


        }
        public DataTable ListarClientesxPais(string pais)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ClientesxPais", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@pais", pais);
                   using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListarDetallesxCliente(string idcli)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ListaPedidosxCliente2", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idcli", idcli);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
            
        }
        public DataTable ListaProdxNombre(string nombre)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ListarProdxNombre", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@name", nombre);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public void ListarEmpleados(ComboBox cbo)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("Usp_ListaEmpleados", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);

            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "IdEmpleado";
            
        }
        public DataTable ListarxEmpleado(int emp)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ListaRapidaxEmpleado", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idemp", emp);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public void ListarClientes(ComboBox cbo)
        {
            cn = cadena();
            SqlDataAdapter df = new SqlDataAdapter("usp_ListarCliente", cn);
            df.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            df.Fill(dt);

            cbo.DataSource = dt;
            cbo.DisplayMember = "Nombre";
            cbo.ValueMember = "IdCliente";

        }
        public DataTable ListarxCliente(string cli)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ListaRapidaxCliente", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@idcli", cli);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListarPedidos()
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("Usp_ListarPedidos", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable ListarxFecha(DateTime fechaped, DateTime fechaent)
        {
            cn = cadena();
            using (SqlDataAdapter df = new SqlDataAdapter("usp_ListaRapidaxFecha", cn))
            {
                df.SelectCommand.CommandType = CommandType.StoredProcedure;
                df.SelectCommand.Parameters.AddWithValue("@fechaped", fechaped);
                df.SelectCommand.Parameters.AddWithValue("@fechaent", fechaent);
                using (DataTable dt = new DataTable())
                {
                    df.Fill(dt);
                    return dt;
                }
            }
        }
        public void ListarTops(ComboBox cbo)
        {

        }
    }
}


