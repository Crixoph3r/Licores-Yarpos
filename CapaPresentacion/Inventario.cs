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
using static CapaPresentacion.Compras;

namespace CapaPresentacion
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        Conexion oconexion = new Conexion();
        CE_Inventario einventario = new CE_Inventario();
        CN_Inventario oinventario = new CN_Inventario();
        private int IDUsuario;
        private string resultadoRol;
        private string UsuarioLB;
  

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

      

        public void limpiar()
        {
           
           
            AjusteTXT.Clear();
            StockMinimoTXT.Clear();
            StockSerguridadTXT.Clear();
        }

        public void Inventarios( )
        {
            DataTable dt = new DataTable();
            string query = @"
       
                SELECT 
              i.IDInventario, 
	          i.IDProducto,
               p.NombreProducto, 
               i.CantidadInicial, 
               i.CantidadIEntrante, 
               i.CantidadSaliente, 
               i.ajuste, 
                   i.Existencia, 
               i.stock_minimo, 
                i.stock_seguridad, 
                i.IDUsuario 
                FROM Inventarios i
               INNER JOIN Productos p ON i.IDProducto = p.IDProducto;";

            using (oconexion.Conectar())
            {
                SqlCommand cmd = new SqlCommand(query, oconexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            DgvInventario.DataSource = dt;
        }


        private void EditarProductosBTN_Click(object sender, EventArgs e)
        {

            try
            {
               
                einventario.IDInventario = Convert.ToInt32(IDInvnetarioTXT.Text);
                einventario.ajuste = Convert.ToInt32(AjusteTXT.Text);
                einventario.stock_minimo = Convert.ToInt32(StockMinimoTXT.Text);
                einventario.stock_seguridad = Convert.ToInt32(StockSerguridadTXT.Text);


                    if (oinventario.EditarInventario(einventario, IDUsuario) > 0)
                    {
                        MessageBox.Show("Dato Editado", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      
                        Inventarios();
                        limpiar();
                    }
                    else
                    {
                        MessageBox.Show("Error al editar el dato", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            menu.SetIDUsuario(IDUsuario);
            menu.SetRolUsuario(resultadoRol);
            menu.SetUsuarioLabel(UsuarioLB);
            menu.Show();
            this.Hide();
        }

        private void DgvInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtiene la fila seleccionada
                DataGridViewRow row = DgvInventario.Rows[e.RowIndex];

                // Asigna los valores de las celdas a los TextBox correspondientes

                IDInvnetarioTXT.Text = DgvInventario.CurrentRow.Cells["IDInventario"].Value?.ToString();
                CITXT.Text = DgvInventario.CurrentRow.Cells["CantidadInicial"].Value?.ToString();
                AjusteTXT.Text = DgvInventario.CurrentRow.Cells["ajuste"].Value?.ToString();
                StockMinimoTXT.Text = row.Cells["stock_minimo"].Value?.ToString();
                StockSerguridadTXT.Text = row.Cells["stock_seguridad"].Value?.ToString();

            }
        }

        private void DgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            IDInvnetarioTXT.Text= DgvInventario.CurrentRow.Cells[0].Value.ToString();
            AjusteTXT.Text = DgvInventario.CurrentRow.Cells[6].Value.ToString();
            StockMinimoTXT.Text = DgvInventario.CurrentRow.Cells[8].Value.ToString();
            StockSerguridadTXT.Text = DgvInventario.CurrentRow.Cells[9].Value.ToString();

        }


 

        private void LimpiarBTN_Click(object sender, EventArgs e)
        {
            limpiar();
        }



        private void AjusteTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Permitir el signo negativo solo si está al inicio
            if (e.KeyChar == '-' && ((sender as TextBox).Text.Length > 0))
            {
                e.Handled = true;
            }
        }

        private void StockMinimoTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void StockSerguridadTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Inventarios();
            IDInvnetarioTXT.Visible = false;
            IDinventarioLBL.Visible = false;
        }

        private void CInicialTXT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar)) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}