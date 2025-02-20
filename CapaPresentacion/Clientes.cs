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
    public partial class CLientes : Form
    {
        public CLientes()
        {
            InitializeComponent();
        }

        Conexion oconexion = new Conexion();
        CN_Clientes ocliente = new CN_Clientes();
        CE_Clientes eclientes = new CE_Clientes();

        private int IDUsuario;
        private string resultadoRol;
        private string UsuarioLB;
        private int idProducto;

        private void AgregarClienteBTN_Click(object sender, EventArgs e)
        {

            try
            {
                
                
                    eclientes.NombreCliente = NombreClientetxt.Text;
                    eclientes.DireccionCliente = DireccionClienteTXT.Text;
                    eclientes.TelefonoCliente = TelClienteTXT.Text;

               

                    if (NombreClientetxt.Text == "" && DireccionClienteTXT.Text == "" && TelClienteTXT.Text == "")
                    {
                        MessageBox.Show("Por favor ingrese los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                    if (Existetelefono(eclientes.TelefonoCliente))
                    {
                        MessageBox.Show("El telefono ya está registrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (ocliente.RegistrarClientes(eclientes, IDUsuario) > 0)
                        {
                            MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clientes();
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
        

        private void ModificarClienteBTN_Click(object sender, EventArgs e)
        {
            try
            {
                eclientes.IDCliente = Convert.ToInt32(IDClienteTXT.Text);
                eclientes.NombreCliente = NombreClientetxt.Text;
                eclientes.DireccionCliente = DireccionClienteTXT.Text;
                eclientes.TelefonoCliente = TelClienteTXT.Text;
                if ( NombreClientetxt.Text == "" && DireccionClienteTXT.Text == "" && TelClienteTXT.Text == "")
                {
                    MessageBox.Show("Por favor ingrese los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ocliente.EditarClientes(eclientes, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Editado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clientes();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Dato no Editado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SalirBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();



            menu.SetIDUsuario(IDUsuario);
            menu.SetRolUsuario(resultadoRol);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
            this.Hide();
        }

        public void Clientes()
        {
            ocliente.MostrarClientes();
            DgvClientes.DataSource= ocliente.MostrarClientes();
        }

        public void limpiar()
        {
           
            NombreClientetxt.Clear();
            DireccionClienteTXT.Clear();
            TelClienteTXT.Clear();
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

        private void DgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDClienteTXT.Text = DgvClientes.CurrentRow.Cells[0].Value.ToString();
            NombreClientetxt.Text = DgvClientes.CurrentRow.Cells[1].Value.ToString();
            DireccionClienteTXT.Text = DgvClientes.CurrentRow.Cells[2].Value.ToString();
            TelClienteTXT.Text = DgvClientes.CurrentRow.Cells[3].Value.ToString();

        }

        private void DgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila sea válido (no es un encabezado de columna)
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvClientes.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes

                IDClienteTXT.Text= row.Cells["IDCliente"].Value?.ToString();
                NombreClientetxt.Text = row.Cells["NombreCliente"].Value?.ToString();
                DireccionClienteTXT.Text = row.Cells["DireccionCliente"].Value?.ToString();
                TelClienteTXT.Text = row.Cells["TelefonoCliente"].Value?.ToString();
            }
        }

        private void CLientes_Load(object sender, EventArgs e)
        {
            Clientes();
            if (this.Tag != null && this.Tag.ToString() == "Factura")
            {

                
                NombreClientetxt.Visible = false;
                DireccionClienteTXT.Visible = false;
                TelClienteTXT.Visible = false;

                
                NombreClienteLB.Visible = false;
                DireccionLB.Visible = false;
                TelefonoLB.Visible = false;
               
               
  
                AgregarClienteBTN.Visible = false;
                ModificarClienteBTN.Visible = false;
                ImprimirClienteBTN.Visible = false;
                LimpiarBTN.Visible = false;
                SalirBTN.Visible = false;
            }

            IDClienteTXT.Visible = false;
            idcleitneLBL.Visible = false;
        }

        public string[] ObtenerCliente()
        {
            if (DgvClientes.CurrentRow != null)
            {
                return new string[] { DgvClientes.CurrentRow.Cells["IDCliente"].Value?.ToString() ?? "" };
            }
            return new string[0]; // Devuelve un arreglo vacío si no hay fila seleccionada
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ( this.Tag != null && this.Tag.ToString() == "Factura")
            {
                if (DgvClientes.CurrentRow != null)
                {

                    string idCliente = DgvClientes.CurrentRow.Cells["IDCliente"].Value?.ToString() ?? "";
                    this.Tag = idCliente; // Guardamos el ID en la propiedad Tag del formulario
                    this.DialogResult = DialogResult.OK; // Indicamos que la selección fue exitosa
                    this.Close(); // Cerramos el formulario de proveedores
                }

            }

        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void TelClienteTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        public bool Existetelefono(string TelefonoCliente)
        {
            string query = "SELECT COUNT(*) FROM Clientes WHERE TelefonoCliente = @TelefonoCliente";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@TelefonoCliente", TelefonoCliente);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
