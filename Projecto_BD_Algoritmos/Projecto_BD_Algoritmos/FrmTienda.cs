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
    }
}
