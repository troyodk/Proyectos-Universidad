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
        int font_size = 8;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaseDatos = new CRUD();

            administradorToolStripMenuItem.Text = "Iniciar Sesión Admin";
            clientesToolStripMenuItem.Enabled = false;
            categoriasToolStripMenuItem.Enabled = false;
            productoToolStripMenuItem.Enabled = false;
            proveedoresToolStripMenuItem.Enabled = false;
            ventasToolStripMenuItem.Enabled = false;
            facturasToolStripMenuItem.Enabled = false;
            admonCToolStripMenuItem.Enabled = false;
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!BaseDatos.SesionIniciada)
            {

                FrmLogin formL = new FrmLogin();

                this.IsMdiContainer = true;
                formL.MdiParent = this;
                formL.FormClosing += new FormClosingEventHandler(HablitarMenu);
                formL.Show();
            }
            else
            {

                if (MessageBox.Show("Deseas Cerrar Sesión?", "Logout",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BaseDatos = new CRUD();
                    administradorToolStripMenuItem.Text = "Iniciar Sesión Admin";
                    clientesToolStripMenuItem.Enabled = false;
                    categoriasToolStripMenuItem.Enabled = false;
                    productoToolStripMenuItem.Enabled = false;
                    proveedoresToolStripMenuItem.Enabled = false;
                    ventasToolStripMenuItem.Enabled = false;
                    facturasToolStripMenuItem.Enabled = false;
                }
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmC = new FrmClientes();
            this.IsMdiContainer = true;
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmp = new FrmProducto();
            this.IsMdiContainer = true;
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void clientesCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasClientes frmC = new FrmConsultasClientes();
            this.IsMdiContainer = true;
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void admonCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasAdmin frmA = new FrmConsultasAdmin();
            this.IsMdiContainer = true;
            frmA.MdiParent = this;
            frmA.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCategorias frmC = new FrmCategorias();
            this.IsMdiContainer = true;
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFacturas frmf = new FrmFacturas();
            this.IsMdiContainer = true;
            frmf.MdiParent = this;
            frmf.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedores frmp = new FrmProveedores();
            this.IsMdiContainer = true;
            frmp.MdiParent = this;
            frmp.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas frmv = new FrmVentas();
            this.IsMdiContainer = true;
            frmv.MdiParent = this;
            frmv.Show();
        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaNuestrosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmWeb frmW = new FrmWeb();
            //this.IsMdiContainer = true;
            //frmW.MdiParent = this;
            //frmW.Show();
            System.Diagnostics.Process.Start("https://fakesteren.000webhostapp.com/index.html?fbclid=IwAR0qh1fGW_NYnAc1fSwJn2zd6ohhSDA7NqtdcJpRQoZ4py5eby5cnwvYPp0");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        public void HablitarMenu(object sender, FormClosingEventArgs e)
        {
            if (BaseDatos.SesionIniciada)
            {
                clientesToolStripMenuItem.Enabled = true;
                categoriasToolStripMenuItem.Enabled = true;
                productoToolStripMenuItem.Enabled = true;
                proveedoresToolStripMenuItem.Enabled = true;
                ventasToolStripMenuItem.Enabled = true;
                facturasToolStripMenuItem.Enabled = true;
                admonCToolStripMenuItem.Enabled = true;
                administradorToolStripMenuItem.Text = "Cerrar Sesión";
            }
        }

        private void FrmPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                font_size -= 2;
                loginToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                loginToolStripMenuItem.Invalidate();
                consultasToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                consultasToolStripMenuItem.Invalidate();
                tablasToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                tablasToolStripMenuItem.Invalidate();
                webToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                webToolStripMenuItem.Invalidate();
                salirToolStripMenuItem.Font= new Font(this.Font.Name, font_size);
                salirToolStripMenuItem.Invalidate();
            }
            else
            {
                font_size += 2;
                loginToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                loginToolStripMenuItem.Invalidate();
                consultasToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                consultasToolStripMenuItem.Invalidate();
                tablasToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                tablasToolStripMenuItem.Invalidate();
                webToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                webToolStripMenuItem.Invalidate();
                salirToolStripMenuItem.Font = new Font(this.Font.Name, font_size);
                salirToolStripMenuItem.Invalidate();
            }
        }
    }
}
