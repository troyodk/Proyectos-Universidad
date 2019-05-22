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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //FrmPrincipal Form3 = new FrmPrincipal();
            ////FrmTienda Form1 = new FrmTienda();
            //FrmProducto FormP = new FrmProducto();
            //FrmCategorias FormC = new FrmCategorias();
            //FrmProveedores FormPr = new FrmProveedores();
            //FrmClientes FormCl = new FrmClientes();
            //FrmFacturas FormF = new FrmFacturas();
            //FrmVentas FormV = new FrmVentas();
            //Aqui va el usuario creado en la base de datos y hay que cambiar la base de datos
            //Esta es la compu de Uriel xd
            string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = TiendaExamen; user id = " +
                txtUsername.Text + "; password =" + txtPassword.Text;

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                {
                    FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                    FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                    FrmPrincipal.BaseDatos.Conexion.Open();
                    MessageBox.Show("Conexion Inciada");
                    FrmPrincipal.BaseDatos.Conexion.Close();
                    FrmPrincipal.BaseDatos.SesionIniciada = true;
                    this.Close();
                    //Form3.Hide();
                    //FormV.Show();
                }
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
