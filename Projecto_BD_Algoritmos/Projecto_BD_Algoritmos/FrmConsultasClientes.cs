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
    public partial class FrmConsultasClientes : Form
    {
        public FrmConsultasClientes()
        {
            InitializeComponent();
        }

        private void cmbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SQL; 
            SqlDataAdapter Adaptador; 
            DataSet DS = new DataSet(); 
            if (cmbConsultas.SelectedIndex == 0)
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

                    //SQL = "select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc"; 

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultC1();
                
                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultas.SelectedIndex == 1)
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

                    //SQL = "select Producto.nombre_producto as 'Nombre del Producto',Producto.precio as 'Precio', Proveedores.nombre_prov as 'Marca/Proveedor' from Producto "+
                    //      "inner join Proveedores on Proveedores.id_Proveedor = Producto.id_Proveedor";
                    ////SQL = "select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultC2();
                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultas.SelectedIndex == 2)
            {
                txtValores.Visible = true;
                btnInsertar.Visible = true;
            }
            else if(cmbConsultas.SelectedIndex != 2)
            {
                txtValores.Visible = false;
                btnInsertar.Visible = false;
            }
            if (cmbConsultas.SelectedIndex == 3)
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

                    //SQL = "select nombre_producto as 'Nombre del Producto', descripcion as 'Descripcion' from Producto";
                    ////SQL = "select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultC3();
                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
            if (cmbConsultas.SelectedIndex == 4)
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

                    //SQL = "select nombre_producto as 'Nombre del Producto', categorias.descripcion_categoria as 'Categoria' from Producto inner join categorias on Producto.id_Categoria=categorias.id_Categoria";
                    ////SQL = "select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc";

                    //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                    //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                    //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                    int res = FrmPrincipal.BaseDatos.ConsultC4();
                    Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                    Adaptador.Fill(DS);
                    dataGridView1.DataSource = DS.Tables[0];

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    dataGridView1.AutoResizeColumns();
                    dataGridView1.AllowUserToResizeColumns = true;

                }
                catch (SqlException EX)
                {
                    MessageBox.Show(EX.Message);
                }
                FrmPrincipal.BaseDatos.Conexion.Close();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String SQL;
            SqlDataAdapter Adaptador;
            DataSet DS = new DataSet();
            string Valor = (txtValores.Text);
            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                {
                    string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; integrated security=true";
                    FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                    FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                    FrmPrincipal.BaseDatos.Conexion.Open();
                }

                //SQL = "select nombre_producto,precio from Producto where precio <" + Valor + ";";
                ////SQL = "select nombre_producto,MAX(precio) as 'Mas Caro' from Producto group by nombre_producto, precio order by precio desc";

                //FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                //FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                //FrmPrincipal.BaseDatos.Comando.CommandText = SQL;

                int res = FrmPrincipal.BaseDatos.ConsultC5(Valor);
                Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                Adaptador.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AllowUserToResizeColumns = true;

            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
            FrmPrincipal.BaseDatos.Conexion.Close();
        }

        private void FrmConsultasClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
