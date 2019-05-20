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
    public partial class FrmProveedores : Form
    {
        int Fila = 0;

        public FrmProveedores()
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
                {
                    FrmPrincipal.BaseDatos.Conexion.Open();
                }

                SQL = "SELECT * FROM Proveedores"; //Consulta

                FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
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
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Renglon = dataGridView1.CurrentRow;
            int indice = dataGridView1.RowCount - 1;
            String id_proveedor, nombre, direccion, telefono;

            Renglon = dataGridView1.Rows[indice - 1];

            id_proveedor = Renglon.Cells["id_Proveedor"].Value.ToString();
            nombre = Renglon.Cells["nombre_prov"].Value.ToString();
            direccion = Renglon.Cells["direccion_prov"].Value.ToString();
            telefono = Renglon.Cells["telefono_prov"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.insertar_proveedores(id_proveedor, nombre, direccion, telefono);
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
            String id_proveedor, nombre, direccion, telefono;

            Renglon = dataGridView1.Rows[indice - 1];

            id_proveedor = Renglon.Cells["id_Proveedor"].Value.ToString();
            nombre = Renglon.Cells["nombre_prov"].Value.ToString();
            direccion = Renglon.Cells["direccion_prov"].Value.ToString();
            telefono = Renglon.Cells["telefono_prov"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.editar_proveedores(id_proveedor, nombre, direccion, telefono);
                if (res == 1)
                {
                    MessageBox.Show("El registro con id = " + id_proveedor + " fue actualizado");
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
                SQL = "DELETE FROM Proveedores WHERE id_Proveedor=" + id + ";";

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
            //btBorrar.Enabled = false;

            //DataGridViewRow Renglon = dataGridView1.CurrentRow;
            //int indice = dataGridView1.RowCount - 1;
            //String id_proveedor;

            //Renglon = dataGridView1.Rows[indice - 1];

            //id_proveedor = Renglon.Cells["id_Proveedor"].Value.ToString();

            //try
            //{
            //    if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
            //        FrmPrincipal.BaseDatos.Conexion.Open();
            //    int res = FrmPrincipal.BaseDatos.eliminar_proveedores(id_proveedor);
            //    if (res == 1)
            //    {
            //        MessageBox.Show("El registro con id = " + id_proveedor + " fue borrado");
            //        btnEliminar.Enabled = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo borrar el registro");
            //    }
            //    CargarGrid();
            //}
            //catch (SqlException EX)
            //{
            //    MessageBox.Show(EX.Message);
            //}
            //btnEliminar.Enabled = false;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fila = e.RowIndex;
            if (Fila == dataGridView1.Rows.Count - 1)
                btnInsertar.Enabled = true;
            else
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }
    }
}
