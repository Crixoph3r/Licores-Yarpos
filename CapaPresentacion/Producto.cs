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
    public partial class Producto : Form
    {
        public Producto()
        {
            InitializeComponent();
            
        }


        Conexion oconexion = new Conexion();
        CE_Producto eproducto = new CE_Producto();
        CN_Producto oproducto = new CN_Producto();

        private int IDUsuario;
        private string resultadoRol;
        private string UsuarioLB;


        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB = nombreUsuario;

        }


        public void Product()
        {
            oproducto.MostrarProductos();
            DgvProdcuto.DataSource = oproducto.MostrarProductos();
        }

        public void limpiar()
        {
            NombreProductoTXT.Clear();
            PrecioTXT.Clear();

        }

        private void DgvProdcuto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IDprodcutoTXT.Text= DgvProdcuto.CurrentRow.Cells[0].Value.ToString();
            NombreProductoTXT.Text = DgvProdcuto.CurrentRow.Cells[1].Value.ToString();
            TipoCOMBO.Text = DgvProdcuto.CurrentRow.Cells[2].Value.ToString();
            PrecioTXT.Text = DgvProdcuto.CurrentRow.Cells[3].Value.ToString();
            PrecioTXT.Text = DgvProdcuto.CurrentRow.Cells[3].Value.ToString();
            EstadoCOMBO.Text = DgvProdcuto.CurrentRow.Cells[4].Value.ToString();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
          

            // Agregar elementos a los ComboBox
            TipoCOMBO.Items.Add("Unidad");
            TipoCOMBO.Items.Add("Caja");

            EstadoCOMBO.Items.Add("Activo");
            EstadoCOMBO.Items.Add("Inactivo");



            TipoCOMBO.DropDownStyle = ComboBoxStyle.DropDownList;
            EstadoCOMBO.DropDownStyle = ComboBoxStyle.DropDownList;
           
            Product(); // Cargar datos del producto
            IDprodcutoTXT.Visible = false;
            IDprodcutoLBL.Visible = false;

        }

        public void CancelarBTN_Click(object sender, EventArgs e)
        {
            MenuOpciones menu = new MenuOpciones();


            
                menu.SetIDUsuario(IDUsuario);
                menu.SetRolUsuario(resultadoRol);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
                this.Hide();


        }

        

        public void SetRolUsuario(string roles)
        {
            this.resultadoRol = roles;
        }


        private void AgregarProductoBTN_Click(object sender, EventArgs e)
        {
            try
            {
               
                eproducto.NombreProducto = NombreProductoTXT.Text;
                eproducto.Tipo = TipoCOMBO.Text;
                eproducto.Precio = Convert.ToDecimal(PrecioTXT.Text);
                eproducto.Estado = EstadoCOMBO.Text;


                if (
                    
                    string.IsNullOrEmpty(NombreProductoTXT.Text) ||
                    string.IsNullOrEmpty(TipoCOMBO.Text) ||
                    string.IsNullOrEmpty(PrecioTXT.Text) ||
                    string.IsNullOrEmpty(EstadoCOMBO.Text))
                {
                    MessageBox.Show("Por favor ingrese todos los datos faltantes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ExisteProducto(eproducto.NombreProducto))
                    {
                        MessageBox.Show("El nombre de producto ya está en uso. Intente con otro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                    if (oproducto.RegistrarProducto(eproducto, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Almacenado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Product();
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

        public void EstadoProducto()
        {
            if(eproducto.Estado== "Activo")
            {

            }
        }



        public void SetIDUsuario(int IDUsuario)
        {
            this.IDUsuario = IDUsuario; // Asignamos el valor al campo privado
        }

        private void ModificarProductoBTN_Click(object sender, EventArgs e)
        {
            try
            {
                eproducto.IDProducto= Convert.ToInt32(IDprodcutoTXT.Text);
                eproducto.NombreProducto = NombreProductoTXT.Text;
                eproducto.Tipo = TipoCOMBO.Text;
                eproducto.Precio = Convert.ToDecimal(PrecioTXT.Text);
                eproducto.Estado = EstadoCOMBO.Text;

                if (oproducto.EditarProducto(eproducto, IDUsuario) > 0)
                {
                    MessageBox.Show("Dato Editado", "Exi");
                    Product();
                    limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
          


        }

        private void DgvProdcuto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que el índice de la fila sea válido (no es un encabezado de columna)
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvProdcuto.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes

                IDprodcutoTXT.Text= row.Cells["IDProducto"].Value?.ToString();
                NombreProductoTXT.Text = row.Cells["NombreProducto"].Value?.ToString(); 
                TipoCOMBO.Text = row.Cells["Tipo"].Value?.ToString(); 
                PrecioTXT.Text = row.Cells["Precio"].Value?.ToString();
                EstadoCOMBO.Text = row.Cells["Estado"].Value?.ToString();

                

            }       
        }


        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public bool ExisteProducto(string NombreProducto)
        {
            string query = "SELECT COUNT(*) FROM Productos WHERE NombreProducto = @NombreProducto";
            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                cmd.Parameters.AddWithValue("@NombreProducto", NombreProducto);
                oconexion.Conectar();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void PrecioTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
