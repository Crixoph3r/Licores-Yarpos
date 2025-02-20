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
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Compras : Form
    {

        
        public Compras()
        {
            InitializeComponent( );
            
           
        }

        Conexion oconexion = new Conexion();
        
        CE_Compras ecompra = new CE_Compras();
        CN_Compras ocompra = new CN_Compras();

        CE_Producto eproducto = new CE_Producto();
        CN_Producto oproducto = new CN_Producto();

        CE_Proveedor eproveedor = new CE_Proveedor();


        private int IDUsuario;
        private string Rol;
        private string UsuarioLB;
        private int idProducto;


        public void SetIDUsuario(int IDUsuario)
        {
            this.IDUsuario = IDUsuario; // Asignamos el valor al campo privado
        }
     

        public void limpiar()
        {
           
           
            CantidadCompraTXT.Clear();
           
           

        }

        public void compras()
        {
            DataTable dt = new DataTable();
            string query = @"
       
          SELECT c.IDPCompra, c.Fecha, c.IDProducto,pr.NombreProducto, c.IDProveedores, p.NombreEmpresa, c.Cantidad,c.Total_pagar
  FROM Compras c
 INNER JOIN Proveedores p ON c.IDProveedores = p.IDProveedor INNER JOIN Productos pr ON pr.IDProducto=c.IDProducto
";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            DgvCompras.DataSource = dt;
        }

        private void CargarProductos()
        {
            try
            {
                Dictionary<int, string> productos = new Dictionary<int, string>();
                string query = "SELECT IDProducto, NombreProducto FROM Productos";

                using (oconexion.Conectar())
                {
                    SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                    oconexion.Conectar();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        productos.Add(reader.GetInt32(0), reader.GetString(1));
                    }
                }

                // Asignar la fuente de datos al ComboBox
                IDProductoCBM.DataSource = new BindingSource(productos, null);
                IDProductoCBM.DisplayMember = "Value"; // Muestra el nombre del producto
                IDProductoCBM.ValueMember = "Key"; // Guarda el ID del producto

            }
            catch (Exception )
            {

                MessageBox.Show("Error: Ingrese primero datos en Productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void CargarProveedor()
        {
            try
            {
                Dictionary<int, string> proveedor = new Dictionary<int, string>();
                string query = "SELECT IDProveedor, NombreEmpresa FROM Proveedores";

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
                IDProveedorCMB.DataSource = new BindingSource(proveedor, null);
                IDProveedorCMB.DisplayMember = "Value"; // Muestra el nombre del producto


                IDProveedorCMB.ValueMember = "Key"; // Guarda el ID del producto
            }
            catch (Exception )
            {


                MessageBox.Show("Error:Ingrese primero datos en Proveedores ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
          

        }

        private void Compras_Load(object sender, EventArgs e)
        {


            compras();
            
                CargarProductos();
                CargarProveedor();
          

                IDComprasTXT.Visible = false;
            IDcomprasLBL.Visible = false;
        
          


        }

        private void DgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDComprasTXT.Text = DgvCompras.CurrentRow.Cells[0].Value.ToString(); // ID Compra
            FechaEntregaDT.Value = Convert.ToDateTime(DgvCompras.CurrentRow.Cells[1].Value.ToString()); // Fecha
            IDProductoCBM.Text = DgvCompras.CurrentRow.Cells[3].Value.ToString(); // Nombre del producto
            IDProveedorCMB.Text = DgvCompras.CurrentRow.Cells[4].Value.ToString(); // Nombre del proveedor
            CantidadCompraTXT.Text = DgvCompras.CurrentRow.Cells[6].Value.ToString();

        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            menu.SetIDUsuario(IDUsuario);
            menu.SetRolUsuario(Rol);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
            this.Hide();
        }

        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB = nombreUsuario;

        }

        public void SetRolUsuario(string rol)
        {
            this.Rol = rol;
        }

        private void CrearCuentaBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ecompra.IDProducto = Convert.ToInt32(IDProductoCBM.SelectedValue);
                ecompra.Fecha = FechaEntregaDT.Value;
                ecompra.IDProveedores = Convert.ToInt32(IDProveedorCMB.SelectedValue);
                ecompra.Cantidad = Convert.ToInt32(CantidadCompraTXT.Text);
                int idProducto = Convert.ToInt32(IDProductoCBM.SelectedValue);
                string estadoProducto = oproducto.ObtenerEstadoProducto(idProducto);

                if (estadoProducto != "Activo")
                {
                    MessageBox.Show("No se puede comprar un producto inactivo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir del método si el producto no está activo
                }

                if (IDProductoCBM.SelectedValue == null || FechaEntregaDT.Text == "" || IDProveedorCMB.SelectedValue == null || CantidadCompraTXT.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (ocompra.RegistrarCompras(ecompra, IDUsuario) > 0)
                        {
                            MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            compras();
                            limpiar();
                        }
                    }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
           

        }



        private void ModificarCompraBTN_Click(object sender, EventArgs e)
        {
            try
            {
                ecompra.IDPCompra = Convert.ToInt32(IDComprasTXT.Text);
                ecompra.IDProducto = Convert.ToInt32(IDProductoCBM.SelectedValue);
                ecompra.Fecha = FechaEntregaDT.Value;
                ecompra.IDProveedores = Convert.ToInt32(IDProveedorCMB.SelectedValue);
                ecompra.Cantidad = Convert.ToInt32(CantidadCompraTXT.Text);
               

                if (ocompra.EditarCompras(ecompra, IDUsuario) > 0)
                {
                    MessageBox.Show("Datos Editados","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    compras();
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Datos no Editados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void CantidadCompraTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void IDProductoCBM_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void DgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvCompras_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvCompras.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes

                IDComprasTXT.Text = row.Cells["IDPCompra"].Value?.ToString();
                IDProveedorCMB.Text = row.Cells["NombreEmpresa"].Value?.ToString();
                IDProductoCBM.Text= row.Cells["NombreProducto"].Value?.ToString();
                CantidadCompraTXT.Text = row.Cells["Cantidad"].Value?.ToString();
            }
        }

       
    }
}
