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
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        Conexion oconexion = new Conexion();
        CE_Proveedor eproveedor = new CE_Proveedor();
        CN_Proveedor oproveedor = new CN_Proveedor();

        CE_Gerente egerente = new CE_Gerente();
        CE_Usuario eusuario = new CE_Usuario();

        CN_Gerente ogerente = new CN_Gerente();
        CN_Usuario ousuario = new CN_Usuario();
        private int IDUsuario;
        private string UsuarioLB;

        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB = nombreUsuario;

        }

        public void SetIDUsuario(int IDUsuario)
        {
            this.IDUsuario = IDUsuario;
        }

     

        public void proveedor()
        {

            oproveedor.MostrarProveedor();

            DgvProveedores.DataSource = oproveedor.MostrarProveedor();
        }

        public void limpiar()
        {
          
           NombreProveedorTXT.Clear();
           RTNTXT.Clear();
           TelefonoTXT.Clear();
           NombreEmpresaTXT.Clear();
           DireccionTXT.Clear();

        }

        private void DgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDProveedorTXT.Text= DgvProveedores.CurrentRow.Cells[0].Value.ToString();
            NombreProveedorTXT.Text = DgvProveedores.CurrentRow.Cells[1].Value.ToString();
            RTNTXT.Text = DgvProveedores.CurrentRow.Cells[2].Value.ToString();
            TelefonoTXT.Text = DgvProveedores.CurrentRow.Cells[3].Value.ToString();
            NombreEmpresaTXT.Text = DgvProveedores.CurrentRow.Cells[4].Value.ToString();
            DireccionTXT.Text = DgvProveedores.CurrentRow.Cells[5].Value.ToString();
            

        }

        public string[] ObtenerProveedor()
        {
            if (DgvProveedores.CurrentRow != null)
            {
                return new string[] { DgvProveedores.CurrentRow.Cells["IDProveedor"].Value?.ToString() ?? "" };
            }
            return new string[0]; // Devuelve un arreglo vacío si no hay fila seleccionada
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
           
            proveedor();
            IDProveedorTXT.Visible = false;
            IDProveedorTXT.Visible = false;
        }

        private void GuardarBTN_Click_1(object sender, EventArgs e)
        {
            try
            {

                // Asignar valores a las propiedades del objeto CE_Proveedor
                
                eproveedor.NombreProveedor = NombreProveedorTXT.Text;
                eproveedor.RTN = RTNTXT.Text;
                eproveedor.TelefonoProveedor = TelefonoTXT.Text;
                eproveedor.NombreEmpresa = NombreEmpresaTXT.Text;
                eproveedor.DireccionEmpresa = DireccionTXT.Text;

                // Validar que todos los campos estén llenos
                if (
                    string.IsNullOrEmpty(NombreProveedorTXT.Text) ||
                    string.IsNullOrEmpty(RTNTXT.Text) ||
                    string.IsNullOrEmpty(TelefonoTXT.Text) ||
                    string.IsNullOrEmpty(NombreEmpresaTXT.Text) ||
                    string.IsNullOrEmpty(DireccionTXT.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ExisteProveedor(eproveedor.NombreEmpresa))
                    {
                        MessageBox.Show("El nombre de proveedor ya está en uso. Intente con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (ExisteRTN(eproveedor.RTN))
                    {
                        MessageBox.Show("El RTN ya está registrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (Existetelefono(eproveedor.TelefonoProveedor))
                    {
                        MessageBox.Show("El telefono ya está registrado. Verifique sus datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    // Registrar el proveedor
                    if (oproveedor.RegistrarProveedor(eproveedor, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Almacenado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        proveedor(); // Actualizar el DataGridView
                        limpiar(); // Limpiar los campos
                    }
                    else
                    {
                        MessageBox.Show("Error al almacenar el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void CancelarBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();
            menu.SetUsuarioLabel(UsuarioLB);
            menu.SetIDUsuario(IDUsuario);
          
            menu.Show();
            this.Hide();
        }

      

        private void ModificarProveedorBTN_Click(object sender, EventArgs e)
        {
           
            try
            {
                eproveedor.IDProveedor = Convert.ToInt32(IDProveedorTXT.Text);
                eproveedor.NombreProveedor = NombreProveedorTXT.Text;
                eproveedor.RTN = RTNTXT.Text;
                eproveedor.TelefonoProveedor = TelefonoTXT.Text;
                eproveedor.NombreEmpresa = NombreEmpresaTXT.Text;
                eproveedor.DireccionEmpresa = DireccionTXT.Text;

                if (
                string.IsNullOrEmpty(NombreProveedorTXT.Text) ||
                string.IsNullOrEmpty(RTNTXT.Text) ||
                string.IsNullOrEmpty(TelefonoTXT.Text) ||
                string.IsNullOrEmpty(NombreEmpresaTXT.Text) ||
                string.IsNullOrEmpty(DireccionTXT.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (oproveedor.EditarProveedor(eproveedor, IDUsuario) > 0)
                    {
                        MessageBox.Show("Datos Editados", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        proveedor();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Datos no Editados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
           
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DgvProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Tag != null && this.Tag.ToString() == "Compras")
            {
                if (DgvProveedores.CurrentRow != null)
                {
                    // Recuperamos el ID del proveedor
                    string idProveedor = DgvProveedores.CurrentRow.Cells["IDProveedor"].Value?.ToString() ?? "";

                    // Guardamos el ID del proveedor en la propiedad Tag del formulario
                    this.Tag = idProveedor;

                    // Aseguramos que el formulario de Proveedores se cierre correctamente
                    this.DialogResult = DialogResult.OK; // Indicamos que la selección fue exitosa
                    this.Hide(); // Ocultamos el formulario en lugar de cerrarlo
                }

            }
              
        }

        private void DgvProveedores_CellContextMenuStripChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void RTNTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TelefonoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool ExisteProveedor(string NombreEmpresa)
        {
            string query = "SELECT COUNT(*) FROM Proveedores WHERE NombreEmpresa = @NombreEmpresa";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@NombreEmpresa", NombreEmpresa);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool ExisteRTN(string RTN)
        {
            string query = "SELECT COUNT(*) FROM Proveedores WHERE RTN = @RTN";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@RTN", RTN);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }


        public bool Existetelefono(string TelefonoProveedor)
        {
            string query = "SELECT COUNT(*) FROM Proveedores WHERE TelefonoProveedor = @TelefonoProveedor";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@TelefonoProveedor", TelefonoProveedor);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            NombreProveedorTXT.Clear();
            RTNTXT.Clear();
            TelefonoTXT.Clear();
            NombreEmpresaTXT.Clear();
            DireccionTXT.Clear();
        }
    }
}
