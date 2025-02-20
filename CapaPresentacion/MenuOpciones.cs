using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class MenuOpciones : Form
    {

        bool sidebarExpand;
        public MenuOpciones()
        {
            InitializeComponent();


        }

        private int IDUsuario;
        private string rol;

        public void ResetearBotones()
        {


            if (rol == "Empleado")
            {
                // Ocultar o deshabilitar botones para empleados
                ProveedoresBTN.Visible = false;
                InformesBTN.Visible = false;
                ReportesBTN.Visible = false;
                RegistroBTN.Visible = false;
                TaConBTN.Visible = false;
                ProductosBTN.Visible = false;
                ComprasBTN.Visible = false;
                pictureBox8.Visible = false;
                pictureBox7.Visible = false;
                pictureBox9.Visible = false;
                pictureBox2.Visible = false;
                pictureBox11.Visible = false;
                pictureBox5.Visible = false;
                pictureBox4.Visible = false;
            }
            else if (rol == "Gerente")
            {
                // Si el usuario es administrador, aseguramos que todos los botones sean visibles
                ProveedoresBTN.Visible = true;
                InformesBTN.Visible = true;
                ReportesBTN.Visible = true;
                RegistroBTN.Visible = true;
                TaConBTN.Visible = true;
                pictureBox8.Visible = true;
                pictureBox7.Visible = true;
                pictureBox9.Visible = true;
                pictureBox2.Visible = true;
                pictureBox11.Visible = true;
            }


        }

        public void SetUsuarioLabel(string nombreUsuario)
        {
            UsuarioLB.Text = nombreUsuario;

        }


        private void ProductosBTN_Click_1(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            // Pasar el IDUsuario y el rol al formulario Producto
            producto.SetIDUsuario(IDUsuario);
            producto.SetRolUsuario(rol); // Asegúrate de que "roles" esté definido y tenga el valor correcto
            producto.SetUsuarioLabel(UsuarioLB.Text);
            // Mostrar el formulario Producto
            producto.Show();

            // Ocultar el formulario MenuOpciones
            this.Hide();
        }

        private void ComprasBTN_Click_1(object sender, EventArgs e)
        {
            Compras compras = new Compras();
            compras.SetIDUsuario(IDUsuario);
            compras.SetRolUsuario(rol);
            compras.SetUsuarioLabel(UsuarioLB.Text);// Pasamos el IDUsuario
            compras.Show();
            this.Hide();
        }

        public void RegistroBTN_Click_1(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.SetUsuarioLabel(UsuarioLB.Text);
            registro.Show();
            this.Hide();
        }

        private void SalirBTN_Click_1(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
        }

        public void SetIDUsuario(int IDUsuario)
        {
            this.IDUsuario = IDUsuario; // Asignamos el valor al campo privado
        }

        private void ProveedoresBTN_Click(object sender, EventArgs e)
        {
            // Abrir el formulario Proveedores y pasar el IDUsuario
            Proveedores proveedoresForm = new Proveedores();
            proveedoresForm.SetIDUsuario(IDUsuario);// Pasamos el IDUsuario
            proveedoresForm.SetUsuarioLabel(UsuarioLB.Text);
            proveedoresForm.Show();
            this.Hide();
        }

        private void MenuOpciones_Load_1(object sender, EventArgs e)
        {

            SetRolUsuario(rol);

        }


        public void SetRolUsuario(string roles)
        {
            rol = roles; // Guarda el rol en la variable de clase
            ResetearBotones(); // Configura los botones según el rol
        }


        public MenuOpciones(int idUsuario, string rol)
        {
            InitializeComponent();
            this.IDUsuario = idUsuario;
            this.rol = rol;
            ResetearBotones();  // Llamamos a ResetearBotones desde el constructor
        }

        private void ClientesBTN_Click(object sender, EventArgs e)
        {
            CLientes cliente = new CLientes();
            cliente.SetIDUsuario(IDUsuario);
            cliente.SetRolUsuario(rol);
            cliente.SetUsuarioLabel(UsuarioLB.Text);// Pasamos el IDUsuario
            cliente.Show();
            this.Hide();
        }

        private void InventarioBTN_Click(object sender, EventArgs e)
        {
            Inventario inv = new Inventario();
            inv.SetIDUsuario(IDUsuario);
            inv.SetRolUsuario(rol);
            inv.SetUsuarioLabel(UsuarioLB.Text);// Pasamos el IDUsuario
            inv.Show();
            this.Hide();
        }

        private void FacturasBTN_Click(object sender, EventArgs e)
        {
            Factura fac = new Factura();
            fac.SetIDUsuario(IDUsuario);
            fac.SetRolUsuario(rol);
            fac.SetUsuarioLabel(UsuarioLB.Text);// Pasamos el IDUsuario
            fac.Show();
            this.Hide();
        }

     

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;

                    sidebarTimer.Stop();
                }

            }
            else
            {

                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {

                    sidebarExpand = true;
                    sidebarTimer.Stop();

                }

            }

        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

      
        private void TaConBTN_Click(object sender, EventArgs e)
        {
            PanelDeControl pc = new PanelDeControl();
            pc.SetIDUsuario(IDUsuario);
            pc.SetRolUsuario(rol);
            pc.SetUsuarioLabel(UsuarioLB.Text);// Pasamos el IDUsuario
            pc.Show();
            this.Hide();
        }
    }
    }
