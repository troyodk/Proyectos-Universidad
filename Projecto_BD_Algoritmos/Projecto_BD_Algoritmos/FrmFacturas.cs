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
    public partial class FrmFacturas : Form
    {
        public FrmFacturas()
        {
            InitializeComponent();
        }

        void CargarGrid()
        {
            String SQL; //Consulta a realizar
            SqlDataAdapter Adaptador; //Adaptador para obtener datos de BD
            DataSet DS = new DataSet(); //Conjunto de datos para llenar el Grid

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                {//Si la conexion esta cerrada, hay que abrirla
                    FrmPrincipal.BaseDatos.Conexion.Open();
                }

                SQL = "SELECT * FROM Facturas"; //Consulta

                //Asigna conecion y consulta al comando
                FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
                //El adaptador se crea con el comando y se ejecuta en la BD
                Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                //LLenar el DataSet con los datos del adaptador
                Adaptador.Fill(DS);
                //Ligar el datagridview a los datos del DataSet
                dataGridView1.DataSource = DS.Tables[0];

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AllowUserToResizeColumns = true;

            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void FrmFacturas_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
