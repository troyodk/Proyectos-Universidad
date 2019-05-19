using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_BD_Algoritmos
{
    public partial class FrmPrincipal : Form
    {
        public static CRUD BaseDatos; //Clase de BD, static para ser accesible desde afuera de la forma

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDatos = new CRUD();
            //MessageBox.Show("baer");
            //MessageBox.Show("baerecito");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmLogin Form1 = new FrmLogin();
            //Form1.MdiParent = this;
            Form1.Show();
        }

        private void btnVisitanos_Click(object sender, EventArgs e)
        {
            FrmPrincipal FormP = new FrmPrincipal();
            FrmTienda Form2 = new FrmTienda();
            Form2.Show();
            this.Hide();
        }
    }
}
