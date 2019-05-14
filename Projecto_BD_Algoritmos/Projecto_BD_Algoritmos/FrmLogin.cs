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
            //Aqui va el usuario creado en la base de datos y hay que cambiar la base de datos
            string CadenaConexion = "Data Source = DESKTOP-LGBA956\\SQLEXPRESS01; Initial Catalog = Topicos; user id = " +
                txtUsername.Text + "; password =" + txtPassword.Text;

            try
            {
                //Conexion.ConnectionString = CadenaConexion;
                //Conexion.Open();
                FrmPrincipal.BaseDatos.cadConexion = CadenaConexion;
                FrmPrincipal.BaseDatos.Conexion.ConnectionString = CadenaConexion;
                FrmPrincipal.BaseDatos.Conexion.Open();
                MessageBox.Show("Conexion Inciada");
                FrmPrincipal.BaseDatos.Conexion.Close();
                this.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
