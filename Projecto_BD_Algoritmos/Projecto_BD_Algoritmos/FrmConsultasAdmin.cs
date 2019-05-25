using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projecto_BD_Algoritmos
{
    public partial class FrmConsultasAdmin : Form
    {
        public FrmConsultasAdmin()
        {
            InitializeComponent();
        }

        private void cmbConsultasAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter Adaptador;
            DataSet DS = new DataSet();
            if (cmbConsultasAdmin.SelectedIndex == 0)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Proveedores.id_Proveedor as 'Num Proveedor', Proveedores.nombre_prov as 'Nombre Proveedor', Proveedores.direccion_prov as 'Direccion del Proveedor',"+ 
                    //"Proveedores.telefono_prov as 'Tel Proveedor' from Proveedores order by Proveedores.nombre_prov";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultA1();
                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if(cmbConsultasAdmin.SelectedIndex == 1)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Clientes.id_Cliente as 'Num Cliente', Clientes.nombre_cliente as 'Nombre Cliente', Clientes.direccion_cliente as 'Direccion Cliente', Clientes.telefono_cliente "+
                    //"as 'Tel Cliente', Facturas.id_Factura as 'Num Factura' from Clientes inner join Facturas on Facturas.id_Factura = 1";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
                    int res = FrmPrincipal.BaseDatos.ConsultA2();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultasAdmin.SelectedIndex == 2)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Ventas.id_Ventas as 'Num Venta', Ventas.id_Producto as 'Num Producto', Ventas.cantidad as 'Productos Vendidos', Producto.nombre_producto as 'Nombre Producto' from Ventas " +
                    //"inner join Producto on Producto.nombre_producto = Producto.nombre_producto where Ventas.cantidad > 3";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultA3();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultasAdmin.SelectedIndex == 3)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Producto.id_Producto as 'Num Producto',Producto.nombre_producto as 'Nombre Producto',Proveedores.id_Proveedor as 'Num Proveedor',Proveedores.nombre_prov as 'Nom proveedor' "+ 
                    //"from Producto inner join Proveedores on Proveedores.id_Proveedor = Producto.id_Proveedor";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
                    int res = FrmPrincipal.BaseDatos.ConsultA4();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultasAdmin.SelectedIndex == 4)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Facturas.id_Factura as 'Num Factura', Facturas.fecha as 'Fecha de Factura', Clientes.nombre_cliente as 'Nombre Cliente' from Facturas " +
                    //"inner join Clientes on Clientes.nombre_cliente = Clientes.nombre_cliente where Facturas.id_Factura = 1";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
                    int res = FrmPrincipal.BaseDatos.ConsultA5();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultasAdmin.SelectedIndex == 5)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Clientes.nombre_cliente as 'Nombre Cliente', Clientes.direccion_cliente as 'Direccion Cliente', Clientes.telefono_cliente as 'Telefono Cliente', Producto.precio " +
                    //"as 'Precio del Producto' from Clientes inner join Producto on Producto.precio > 5000";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultA6();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultasAdmin.SelectedIndex == 6)
            {
                try
                {
                    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    {
                        string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                        FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                        FrmPrincipal.BaseDatos.Conexion.Open();
                    }

                    //SQL = "select Categorias.id_Categoria as 'Num Categoria', Categorias.descripcion_categoria as 'Descripcion' from Categorias";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultA7();

                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dtgConsultasAdmin.DataSource = DS.Tables[0];

                    dtgConsultasAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dtgConsultasAdmin.AutoResizeColumns();
                    dtgConsultasAdmin.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
        }
    }
}
