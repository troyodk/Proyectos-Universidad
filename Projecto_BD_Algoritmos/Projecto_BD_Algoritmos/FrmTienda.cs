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
    public partial class FrmTienda : Form
    {
        public FrmTienda()
        {
            InitializeComponent();
        }

        private void FrmTienda_Load(object sender, EventArgs e)
        {
            FrmPrincipal FormP = new FrmPrincipal();
            FormP.Hide();
        }

        private void administradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin formL = new FrmLogin();
            this.IsMdiContainer = true;
            formL.MdiParent = this;
            formL.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasClientes frmC = new FrmConsultasClientes();
            this.IsMdiContainer = true;
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultasAdmin frmA = new FrmConsultasAdmin();
            this.IsMdiContainer = true;
            frmA.MdiParent = this;
            frmA.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCategorias frmC = new FrmCategorias();
            this.IsMdiContainer = true;
            frmC.MdiParent = this;
            frmC.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmClientes frmC = new FrmClientes();
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

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto frmp = new FrmProducto();
            this.IsMdiContainer = true;
            frmp.MdiParent = this;
            frmp.Show();
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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmp = new FrmPrincipal();
            frmp.Close();
            this.Close();
        }
    }
}
