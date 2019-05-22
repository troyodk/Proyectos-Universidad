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
    public partial class FrmTienda : Form
    {
        //public static CRUD BaseDatos; //Clase de BD, static para ser accesible desde afuera de la forma
        

        public FrmTienda()
        {
            InitializeComponent();
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            FrmPrincipal.BaseDatos = new CRUD();
        }

        private void btnVisitanos_Click_1(object sender, EventArgs e)
        {
            FrmPrincipal FormP = new FrmPrincipal();
            FrmTienda Form2 = new FrmTienda();
            FormP.Show();
            this.Hide();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (FrmPrincipal.BaseDatos.SesionIniciada == false)
            {
                FrmLogin Form1 = new FrmLogin();
                Form1.Show();
            }
            else
            {
                
            }
        }

        private void FrmTienda_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 'A')
            {
                MessageBox.Show("aber");
            }
        }
    }
}
