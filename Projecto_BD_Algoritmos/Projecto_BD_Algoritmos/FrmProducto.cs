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
    public partial class FrmProducto : Form
    {
        int Fila = 0;

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            CargarGrid();
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

                SQL = "SELECT * FROM Producto"; //Consulta

                //Asigna conecion y consulta al comando
                FrmPrincipal.BaseDatos.Comando.Connection = FrmPrincipal.BaseDatos.Conexion;
                FrmPrincipal.BaseDatos.Comando.CommandType = CommandType.Text;
                FrmPrincipal.BaseDatos.Comando.CommandText = SQL;
                //El adaptador se crea con el comando y se ejecuta en la BD
                Adaptador = new SqlDataAdapter(FrmPrincipal.BaseDatos.Comando);
                //LLenar el DataSet con los datos del adaptador
                Adaptador.Fill(DS);
                //Ligar el datagridview a los datos del DataSet
                dtgProducto.DataSource = DS.Tables[0];

                dtgProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                dtgProducto.AutoResizeColumns();
                dtgProducto.AllowUserToResizeColumns = true;

            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Renglon = dtgProducto.CurrentRow;
            int indice = dtgProducto.RowCount - 1;
            String id_producto, descripcion, nombre, precio, id_categoria, id_proveedor;

            Renglon = dtgProducto.Rows[indice - 1];

            id_producto = Renglon.Cells["id_Producto"].Value.ToString();
            nombre = Renglon.Cells["nombre_producto"].Value.ToString();
            descripcion = Renglon.Cells["descripcion"].Value.ToString();
            precio = Renglon.Cells["precio"].Value.ToString();
            id_categoria = Renglon.Cells["id_Categoria"].Value.ToString();
            id_proveedor = Renglon.Cells["id_Proveedor"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.insertar_producto(id_producto, descripcion, nombre, precio, id_categoria, id_proveedor);
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
            DataGridViewRow Renglon = dtgProducto.CurrentRow;
            int indice = dtgProducto.RowCount - 1;
            String id_producto, descripcion, nombre, precio, id_categoria, id_proveedor;

            Renglon = dtgProducto.Rows[indice - 1];

            id_producto = Renglon.Cells["id_Producto"].Value.ToString();
            nombre = Renglon.Cells["nombre_producto"].Value.ToString();
            descripcion = Renglon.Cells["descripcion"].Value.ToString();
            precio = Renglon.Cells["precio"].Value.ToString();
            id_categoria = Renglon.Cells["id_Categoria"].Value.ToString();
            id_proveedor = Renglon.Cells["id_Proveedor"].Value.ToString();

            try
            {
                if (FrmPrincipal.BaseDatos.Conexion.State == ConnectionState.Closed)
                    FrmPrincipal.BaseDatos.Conexion.Open();
                int res = FrmPrincipal.BaseDatos.editar_producto(id_producto, descripcion, nombre, precio, id_categoria, id_proveedor);
                if (res == 1)
                {
                    MessageBox.Show("El registro con id = " + id_producto + " fue actualizado");
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
                id = dtgProducto.Rows[Fila].Cells[0].Value.ToString();
                SQL = "DELETE FROM Producto WHERE id_Producto=" + id + ";";

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
