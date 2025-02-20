using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        Conexion oconexion = new Conexion();

        CE_Clientes eclientes = new CE_Clientes();
        CE_Factura efactura = new CE_Factura();
        CN_Factura ofactura = new CN_Factura();

        private int IDUsuario;
        private string resultadoRol;
        private string UsuarioLB;

        private void CrearFacturaBTN_Click(object sender, EventArgs e)
        {
            try
            {

                efactura.IDFactura = Convert.ToInt32(IDFactruraTXT.Text);
                efactura.Fecha = FechaFacturaPICK.Value;
                efactura.IDCliente =Convert.ToInt32(IDCLienteTXT.SelectedValue) ;
               

                if ( IDCLienteTXT.SelectedValue == null )
                {
                    MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (ofactura.RegistrarFactura(efactura, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        facturas();
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

        public void facturas()
        {
            ofactura.MostrarFactura();
            DgvFactura.DataSource = ofactura.MostrarFactura();
        }

        public void limpiar()
        {

           
       
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

        private void DgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            IDFactruraTXT.Text = DgvFactura.CurrentRow.Cells[0].Value.ToString();
            IDCLienteTXT.Text = DgvFactura.CurrentRow.Cells[1].Value.ToString();
            FechaFacturaPICK.Value = Convert.ToDateTime(DgvFactura.CurrentRow.Cells[2].Value.ToString());
            TPagarTXT.Text = DgvFactura.CurrentRow.Cells[3].Value.ToString();



        }

        private void ModificarFacBTN_Click(object sender, EventArgs e)
        {
            try
            {
                efactura.IDFactura = Convert.ToInt32(IDFactruraTXT.Text);
                efactura.Fecha = FechaFacturaPICK.Value;
                efactura.IDCliente = Convert.ToInt32(IDCLienteTXT.SelectedValue);


                if (IDCLienteTXT.Text == "")
                {
                    MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {


                    if (ofactura.Editaracturas(efactura, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Editado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        facturas();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Dato no Editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex )
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
               
           
        }

        private void DgvFactura_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvFactura.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes
                IDFactruraTXT.Text= row.Cells["IDFactura"].Value?.ToString();
                IDCLienteTXT.Text = row.Cells["NombreCliente"].Value?.ToString();
                TPagarTXT.Text= row.Cells["TotalPagar"].Value?.ToString();

            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            facturas();
              CargarCliente();

           
        }
          
          


        

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();

            menu.SetIDUsuario(IDUsuario);
            menu.SetRolUsuario(resultadoRol);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
            this.Hide();
        }

        private void SeleccionarCLiente_Click(object sender, EventArgs e)
        {
            CLientes cliente = new CLientes();
            cliente.Tag = "Factura";

            if (cliente.ShowDialog() == DialogResult.OK) // Esperamos la selección
            {
                string idCliente = cliente.Tag as string; // Recuperamos el ID almacenado en Tag
                IDCLienteTXT.Text = idCliente; // Asignamos el ID al TextBox

            }
        }


        private void CargarCliente()
        {
            try
            {
                Dictionary<int, string> proveedor = new Dictionary<int, string>();
                string query = "SELECT IDCliente, NombreCliente FROM Clientes";

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
                IDCLienteTXT.DataSource = new BindingSource(proveedor, null);
                IDCLienteTXT.DisplayMember = "Value"; // Muestra el nombre del producto
                IDCLienteTXT.ValueMember = "Key"; // Guarda el ID del cliente

            }
            catch (Exception)
            {


                MessageBox.Show("Error: Ingrese primero datos en Clientes" , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }




        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DVenta ve = new DVenta();
           ve.SetIDUsuario(IDUsuario);
            ve.SetRolUsuario(resultadoRol); // Asegúrate de que "roles" esté definido y tenga el valor correcto
            ve.SetUsuarioLabel(UsuarioLB);
            ve.Show();
            this.Hide();
        }
    }
}
