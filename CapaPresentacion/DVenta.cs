using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class DVenta : Form
    {
        public DVenta()
        {
            InitializeComponent();
        }

        Conexion oconexion = new Conexion();
        CN_DVentas odventa = new CN_DVentas();
        CE_DVentas edventa = new CE_DVentas();
        private int IDUsuario;
        private string resultadoRol;
        private string UsuarioLB;


       

        private void AgregarVenta_Click(object sender, EventArgs e)
        {
        
                edventa.IDFactura = Convert.ToInt32(IDFacturaCMB.SelectedValue);
                edventa.IDProducto = Convert.ToInt32(IDProductoCMB.SelectedValue);
                edventa.Cantidad = Convert.ToInt32(CantidadTXT.Text);


          


                if (IDFacturaCMB.SelectedValue == null && IDProductoCMB.SelectedValue == null && CantidadTXT.Text == "")
                {
                    MessageBox.Show("Por favor ingrese los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {






                    if (odventa.RegistrarDventas(edventa, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVentas();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Dato no Almacenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
       }
              
          
        


     






        public void limpiar()
        {

            
            CantidadTXT.Clear();
            
        }

        public void DVentas()
        {
            DataTable dt = new DataTable();
            string query = @"
       
                SELECT 
                  dv.IDDetalleVenta,
                  dv.IDFactura,
                 dv.IDProducto,
                    p.NombreProducto,
                   dv.Cantidad,
                  dv.Precio,
                dv.IDUsuario,
               c.IDCliente,
                 c.NombreCliente
                FROM DetalleVenta dv
                  INNER JOIN Productos p ON dv.IDProducto = p.IDProducto
                   INNER JOIN Facturas f ON dv.IDFactura = f.IDFactura
                   INNER JOIN Clientes c ON f.IDCliente = c.IDCliente;";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            DgvDVentas.DataSource = dt;
        }

        public void SetRolUsuario(string roles)
        {
            this.resultadoRol = roles;
        }

        public void SetIDUsuario(int IDUsuario)
        {
            this.IDUsuario = IDUsuario; // Asignamos el valor al campo privado
        }

        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB = nombreUsuario;

        }

        private void DVenta_Load(object sender, EventArgs e)
        {
            DVentas();
            IDventaTXT.Visible = false;
            IDdventaLBL.Visible = false;
            CargarProductos();
            CargarFactura();


        }

        private void ModificarVentaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                edventa.IDDetalleVenta = Convert.ToInt32(IDventaTXT.Text);
                edventa.IDFactura = Convert.ToInt32(IDFacturaCMB.SelectedValue);
                edventa.IDProducto = Convert.ToInt32(IDProductoCMB.Text);
                edventa.Cantidad = Convert.ToInt32(CantidadTXT.Text);




                if (IDFacturaCMB.SelectedValue == null && IDProductoCMB.Text == "" && CantidadTXT.Text == "")
                {
                    MessageBox.Show("Por favor ingrese los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (odventa.EditarDVenta(edventa, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DVentas();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Dato no Almacenado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }



        private void DgvDVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDventaTXT.Text = DgvDVentas.CurrentRow.Cells[0].Value.ToString();
            IDFacturaCMB.Text = DgvDVentas.CurrentRow.Cells[1].Value.ToString();
            IDProductoCMB.Text = DgvDVentas.CurrentRow.Cells[2].Value.ToString();
            CantidadTXT.Text = DgvDVentas.CurrentRow.Cells[4].Value.ToString();
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            Factura fa = new Factura();
            fa.SetIDUsuario(IDUsuario);
            fa.SetRolUsuario(resultadoRol); // Asegúrate de que "roles" esté definido y tenga el valor correcto
            fa.SetUsuarioLabel(UsuarioLB);
            fa.Show();
            this.Hide();
        }

        private void DgvDVentas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvDVentas.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes

                IDventaTXT.Text = row.Cells["IDDetalleVenta"].Value?.ToString();
                IDFacturaCMB.Text = row.Cells["IDFactura"].Value?.ToString();
                IDProductoCMB.SelectedValue = row.Cells["NombreProducto"].Value?.ToString();
                CantidadTXT.Text = row.Cells["Cantidad"].Value?.ToString();
            }
        }

        private void CargarProductos()
        {
            Dictionary<int, string> proveedor = new Dictionary<int, string>();
            string query = @"
           SELECT i.IDProducto, p.NombreProducto
            FROM Inventarios i
            INNER JOIN Productos p ON i.IDProducto = p.IDProducto";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                oconexion.Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proveedor.Add(reader.GetInt32(0), reader.GetString(1));
                }
            }

            // Asignar la fuente de datos al ComboBox
            IDProductoCMB.DataSource = new BindingSource(proveedor, null);
            IDProductoCMB.DisplayMember = "Value"; // Muestra el nombre del producto
            IDProductoCMB.ValueMember = "Key"; // Guarda el ID del producto
        }
        private void CargarFactura()
        {
            Dictionary<int, int> proveedor = new Dictionary<int, int>();
            string query = "SELECT IDFactura,IDFactura FROM Facturas";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                oconexion.Conectar();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    proveedor.Add(reader.GetInt32(0), reader.GetInt32(0));
                }
            }

            // Asignar la fuente de datos al ComboBox
            IDFacturaCMB.DataSource = new BindingSource(proveedor, null);
            IDFacturaCMB.DisplayMember = "Value"; // Muestra el nombre del producto
            IDFacturaCMB.ValueMember = "Key"; // Guarda el ID del producto
        }

    }
}
