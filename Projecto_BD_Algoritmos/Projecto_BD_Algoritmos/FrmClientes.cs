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
    public partial class FrmClientes : Form
    {
        int Fila = 0;

        public FrmClientes()
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

                SQL = "SELECT * FROM Clientes"; //Consulta

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

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Renglon = dataGridView1.CurrentRow;
            int indice = dataGridView1.RowCount - 1;
            String id_Cliente, nombre, direccion, telefono;

            Renglon = dataGridView1.Rows[indice - 1];

            id_Cliente = Renglon.Cells["id_Cliente"].Value.ToString();
            nombre = Renglon.Cells["nombre_cliente"].Value.ToString();
            direccion = Renglon.Cells["direccion_cliente"].Value.ToString();
            telefono = Renglon.Cells["telefono_cliente"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.insertar_clientes(id_Cliente, nombre, direccion, telefono);
                if (res == 1)
                {
                    MessageBox.Show("Datos insertados");
                    btnInsertar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Datos no Insertados");
                }
                CargarGrid();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
            btnInsertar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Renglon = dataGridView1.CurrentRow;
            int indice = dataGridView1.RowCount - 1;
            String id_Cliente, nombre, direccion, telefono;

            Renglon = dataGridView1.Rows[indice - 1];

            id_Cliente = Renglon.Cells["id_Cliente"].Value.ToString();
            nombre = Renglon.Cells["nombre_cliente"].Value.ToString();
            direccion = Renglon.Cells["direccion_cliente"].Value.ToString();
            telefono = Renglon.Cells["telefono_cliente"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.editar_cliente(id_Cliente, nombre, direccion, telefono);
                if (res == 1)
                {
                    MessageBox.Show("El registro con id = " + id_Cliente + " fue actualizado");
                    btnActualizar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el registro");
                }
                CargarGrid();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
            btnActualizar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string SQL, id;
            SqlCommand Comando;
            try
            {
                id = dataGridView1.Rows[Fila].Cells[0].Value.ToString();
                SQL = "DELETE FROM Clientes WHERE id_Cliente=" + id + ";";

                Comando = new SqlCommand(SQL, FrmPrincipal.BaseDatos.Conexion);
                Comando.CommandType = CommandType.Text;

                if (Comando.Connection.State == ConnectionState.Closed)
                    Comando.Connection.Open();

                int f = Comando.ExecuteNonQuery();
                if (f == 0)
                    MessageBox.Show("No se pudo borrar el registro");
                else
                    MessageBox.Show("El registro con id = " + id + " fue borrado");

                CargarGrid();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
