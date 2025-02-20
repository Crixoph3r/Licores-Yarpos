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
using System.Windows.Forms.DataVisualization.Charting;
using CapaDatos;

namespace CapaPresentacion
{


    public partial class PanelDeControl : Form
    {
        Conexion oconexion = new Conexion();
        public PanelDeControl()
        {
            InitializeComponent();
        }

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

        private void CargarGraficoProductos()
        {
            using (SqlConnection conexion = oconexion.Conectar())
            {
                string query = @"
            SELECT p.NombreProducto, SUM(dv.Cantidad * dv.Precio) AS TotalVenta
            FROM DetalleVenta dv
            JOIN Productos p ON dv.IDProducto = p.IDProducto
            GROUP BY p.NombreProducto
            ORDER BY TotalVenta DESC";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar datos previos del gráfico
                chartProductos.Series.Clear();
                chartProductos.Titles.Clear();

                // Crear una nueva serie para el gráfico circular
                Series series = new Series
                {
                    Name = "Productos",
                    ChartType = SeriesChartType.Pie
                };

                decimal totalVentas = 0; // Variable para calcular el total general de ventas

                while (reader.Read())
                {
                    string nombreProducto = reader["NombreProducto"].ToString();
                    decimal totalVenta = Convert.ToDecimal(reader["TotalVenta"]);

                    totalVentas += totalVenta; // Acumular el total de todas las ventas

                    // Agregar datos al gráfico
                    DataPoint punto = new DataPoint();
                    punto.SetValueXY(nombreProducto, totalVenta);
                    punto.Label = $"{nombreProducto}\n{totalVenta:C}"; // Nombre y total vendido
                    series.Points.Add(punto);
                }

                reader.Close();

                // Agregar la serie al gráfico
                chartProductos.Series.Add(series);
                chartProductos.Titles.Add("Productos con más ventas");

                // Agregar título con el total general de ventas
                chartProductos.Titles.Add($"Total Ventas: {totalVentas:C}");

                // Formato de etiquetas dentro del gráfico
                series.IsValueShownAsLabel = true;
            }
        }



        private void CargarGraficoProveedores()
        {
            using (SqlConnection conexion = oconexion.Conectar())
            {
                string query = @"
            SELECT p.NombreProveedor, SUM(c.Total_pagar) AS TotalComprado
            FROM Proveedores p
            JOIN Compras c ON p.IDProveedor = c.IDProveedores
            GROUP BY p.NombreProveedor
            ORDER BY TotalComprado DESC";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar datos previos del gráfico
                chartProveedores.Series.Clear();
                chartProveedores.Titles.Clear();

                // Crear una nueva serie para el gráfico circular
                Series series = new Series
                {
                    Name = "Proveedores",
                    ChartType = SeriesChartType.Pie
                };

                decimal totalCompras = 0; // Variable para calcular el total general de compras

                while (reader.Read())
                {
                    string nombreProveedor = reader["NombreProveedor"].ToString();
                    decimal totalComprado = Convert.ToDecimal(reader["TotalComprado"]);

                    totalCompras += totalComprado; // Acumular el total de todas las compras

                    // Agregar datos al gráfico
                    DataPoint punto = new DataPoint();
                    punto.SetValueXY(nombreProveedor, totalComprado);
                    punto.Label = $"{nombreProveedor}\n{totalComprado:C}"; // Nombre y total comprado
                    series.Points.Add(punto);
                }

                reader.Close();

                // Agregar la serie al gráfico
                chartProveedores.Series.Add(series);
                chartProveedores.Titles.Add("Proveedores con más compras");

                // Agregar título con el total general de compras
                chartProveedores.Titles.Add($"Total Compras: {totalCompras:C}");

                // Formato de etiquetas dentro del gráfico
                series.IsValueShownAsLabel = true;
            }
        }

        private void CargarGraficoMovimientos()
        {
            using (SqlConnection conexion = oconexion.Conectar())
            {
                string query = @"
        SELECT 
            'Entrada' AS TipoMovimiento,
            p.NombreProducto AS Producto, 
            SUM(c.Cantidad) AS Cantidad
        FROM 
            Compras c
        INNER JOIN 
            Productos p ON c.IDProducto = p.IDProducto 
        GROUP BY 
            p.NombreProducto
        UNION ALL
        SELECT 
            'Salida' AS TipoMovimiento,
            p.NombreProducto AS Producto,
            SUM(dv.Cantidad) AS Cantidad
        FROM 
            Facturas f
        INNER JOIN 
            DetalleVenta dv ON f.IDFactura = dv.IDFactura
        INNER JOIN 
            Productos p ON dv.IDProducto = p.IDProducto
        GROUP BY 
            p.NombreProducto";

                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataReader reader = cmd.ExecuteReader();

                // Limpiar datos previos del gráfico
                chartMovimientos.Series.Clear();
                chartMovimientos.Titles.Clear();

                // Crear series para Entradas y Salidas
                Series serieEntrada = new Series("Entradas")
                {
                    ChartType = SeriesChartType.Column
                };

                Series serieSalida = new Series("Salidas")
                {
                    ChartType = SeriesChartType.Column
                };

                // Diccionario para almacenar las cantidades de entradas y salidas por producto
                Dictionary<string, int> entradasPorProducto = new Dictionary<string, int>();
                Dictionary<string, int> salidasPorProducto = new Dictionary<string, int>();

                while (reader.Read())
                {
                    string producto = reader["Producto"].ToString();
                    string tipo = reader["TipoMovimiento"].ToString();
                    int cantidad = Convert.ToInt32(reader["Cantidad"]);

                    if (tipo == "Entrada")
                    {
                        if (entradasPorProducto.ContainsKey(producto))
                            entradasPorProducto[producto] += cantidad;
                        else
                            entradasPorProducto[producto] = cantidad;
                    }
                    else
                    {
                        if (salidasPorProducto.ContainsKey(producto))
                            salidasPorProducto[producto] += cantidad;
                        else
                            salidasPorProducto[producto] = cantidad;
                    }
                }

                reader.Close();

                // Agregar los puntos a las series
                foreach (var producto in entradasPorProducto.Keys)
                {
                    serieEntrada.Points.AddXY(producto, entradasPorProducto[producto]);
                    serieSalida.Points.AddXY(producto, salidasPorProducto.ContainsKey(producto) ? salidasPorProducto[producto] : 0);
                }

                // Agregar las series al gráfico
                chartMovimientos.Series.Add(serieEntrada);
                chartMovimientos.Series.Add(serieSalida);

                // Agregar título
                chartMovimientos.Titles.Add("Movimientos de Inventario");
            }
        }



        private void PanelDeControl_Load(object sender, EventArgs e)
        {
            CargarGraficoProductos();
            CargarGraficoProveedores();
            CargarGraficoMovimientos();
            CargarEntrada();
            CargarSaliente();
            CargarAjuste();
            CargarStockMinimo();
            CargarStockSeguridad();
            CargarExistencia();


        }



        private void IInicialLBL_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = oconexion.Conectar())
                {
                    conexion.Open();

                    string query = "SELECT ISNULL(SUM(CantidadInicial), 0) AS TotalInicial FROM Inventarios"; // ISNULL asegura que siempre haya un 0

                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        object resultado = cmd.ExecuteScalar();

                        // Mostrar el resultado siempre, incluso si es 0
                        IInicialLBL.Text = "Inventario Inicial: " + resultado.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public void CargarIncial()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(CantidadInicial) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            IInicialLBL.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            IInicialLBL.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    IInicialLBL.Text = "Error: " + ex.Message;
                }
            }

        }






        public void CargarEntrada()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(CantidadIEntrante) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            EntradaLBL.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            EntradaLBL.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    EntradaLBL.Text = "Error: " + ex.Message;
                }
            }

        }

        public void CargarSaliente()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(CantidadSaliente) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            SalidasLBL.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            SalidasLBL.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    SalidasLBL.Text = "Error: " + ex.Message;
                }
            }

        }

        public void CargarAjuste()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(ajuste) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            IAjusteLBL.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            IAjusteLBL.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    IAjusteLBL.Text = "Error: " + ex.Message;
                }
            }

        }

        public void CargarStockMinimo()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(stock_minimo) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            SMinimoLBL.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            SMinimoLBL.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    SMinimoLBL.Text = "Error: " + ex.Message;
                }
            }

        }

        public void CargarStockSeguridad()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(stock_seguridad) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            SSeguridad.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            SSeguridad.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    SSeguridad.Text = "Error: " + ex.Message;
                }
            }

        }


        public void CargarExistencia()
        {
            // Query para obtener la suma de CantidadIEntrante
            string query = "SELECT SUM(Existencia) AS TotalInicial FROM Inventarios";

            using (SqlConnection connection = oconexion.Conectar())
            {
                try
                {
                    oconexion.Conectar();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Ejecutar el query y obtener el resultado
                        object result = command.ExecuteScalar();

                        // Verificar si el resultado no es nulo
                        if (result != null && result != DBNull.Value)
                        {
                            int totalInicial = Convert.ToInt32(result);

                            // Asignar el total al Label en el formulario
                            Existencia.Text = totalInicial.ToString();
                        }
                        else
                        {
                            // Si no hay datos, mostrar 0 o un mensaje en el Label
                            Existencia.Text = "0";
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Mostrar el error en el Label
                    Existencia.Text = "Error: " + ex.Message;
                }
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
    }
}
  
