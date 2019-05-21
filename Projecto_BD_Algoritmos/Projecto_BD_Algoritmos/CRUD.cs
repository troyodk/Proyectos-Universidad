using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Projecto_BD_Algoritmos
{
    public class CRUD
    {
        public SqlConnection Conexion;
        public SqlCommand Comando;
        public SqlDataReader Lector;
        public string cadConexion;
        public bool SesionIniciada;

        public CRUD()
        {   
            this.Conexion = new SqlConnection();
            this.Comando = new SqlCommand();
            this.cadConexion = string.Empty;
        }

        public CRUD(string CadenaConexion)
        {
            this.Conexion = new SqlConnection();
            this.Conexion.ConnectionString = CadenaConexion;

            this.Comando = new SqlCommand();
            this.cadConexion = CadenaConexion;
        }

        #region SP_Proveedores
        public int insertar_proveedores(string id_proveedor, string nombre_prov, string direccion_prov, string telefono_prov)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_insertar_proveedores", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Proveedor", id_proveedor);
                this.Comando.Parameters.AddWithValue("nombre_prov", nombre_prov);
                this.Comando.Parameters.AddWithValue("direccion_prov", direccion_prov);
                this.Comando.Parameters.AddWithValue("telefono_prov", telefono_prov);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_proveedores(string id_proveedor, string nombre_prov, string direccion_prov, string telefono_prov)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_proveedores", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Proveedor", id_proveedor);
                this.Comando.Parameters.AddWithValue("nombre_prov", nombre_prov);
                this.Comando.Parameters.AddWithValue("direccion_prov", direccion_prov);
                this.Comando.Parameters.AddWithValue("telefono_prov", telefono_prov);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_proveedores(string id_proveedor)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_proveedores", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Proveedor", id_proveedor);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion

        #region SP_Clientes
        public int insertar_clientes(string id_cliente, string nombre_cliente, string direccion_cliente, string telefono_cliente)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_cliente", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Cliente", id_cliente);
                this.Comando.Parameters.AddWithValue("nombre_cliente", nombre_cliente);
                this.Comando.Parameters.AddWithValue("direccion_cliente", direccion_cliente);
                this.Comando.Parameters.AddWithValue("telefono_cliente", telefono_cliente);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_cliente(string id_cliente, string nombre_cliente, string direccion_cliente, string telefono_cliente)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_proveedores", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Cliente", id_cliente);
                this.Comando.Parameters.AddWithValue("nombre_cliente", nombre_cliente);
                this.Comando.Parameters.AddWithValue("direccion_cliente", direccion_cliente);
                this.Comando.Parameters.AddWithValue("telefono_cliente", telefono_cliente);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_cliente(string id_cliente)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_cliente", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Cliente", id_cliente);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion

        #region SP_Categorias
        public int insertar_categoria(string id_categoria, string descripcion)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_insertar_categorias", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Categoria", id_categoria);
                this.Comando.Parameters.AddWithValue("descripcion_categoria", descripcion);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_categoria(string id_categoria, string descripcion)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_categorias", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Categoria", id_categoria);
                this.Comando.Parameters.AddWithValue("descripcion_categoria", descripcion);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_categoria(string id_categoria)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_categorias", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Categoria", id_categoria);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion

        #region SP_Facturas
        public int insertar_factura(string id_factura, string fecha, string id_cliente)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_insertar_facturas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Factura", id_factura);
                this.Comando.Parameters.AddWithValue("fecha", fecha);
                this.Comando.Parameters.AddWithValue("id_Cliente", id_cliente);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_factura(string id_factura, string fecha, string id_cliente)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_facturas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Factura", id_factura);
                this.Comando.Parameters.AddWithValue("fecha", fecha);
                this.Comando.Parameters.AddWithValue("id_Cliente", id_cliente);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_factura(string id_factura)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_facturas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Factura", id_factura);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion

        #region SP_Producto
        public int insertar_producto(string id_producto, string nombre, string descripcion, string precio, string id_categoria, string id_proveedor)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_insertar_producto", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Producto", id_producto);
                this.Comando.Parameters.AddWithValue("nombre_producto", nombre);
                this.Comando.Parameters.AddWithValue("descripcion", descripcion);
                this.Comando.Parameters.AddWithValue("precio", precio);
                this.Comando.Parameters.AddWithValue("id_Categoria", id_categoria);
                this.Comando.Parameters.AddWithValue("id_Proveedor", id_proveedor);   
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_producto(string id_producto, string nombre, string descripcion, string precio, string id_categoria, string id_proveedor)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_producto", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Producto", id_producto);
                this.Comando.Parameters.AddWithValue("nombre_producto", nombre);
                this.Comando.Parameters.AddWithValue("descripcion", descripcion);
                this.Comando.Parameters.AddWithValue("precio", precio);
                this.Comando.Parameters.AddWithValue("id_Categoria", id_categoria);
                this.Comando.Parameters.AddWithValue("id_Proveedor", id_proveedor);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_producto(string id_producto)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_producto", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Producto", id_producto);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion

        #region SP_Ventas
        public int insertar_venta(string id_ventas, string id_factura, string id_producto, string cantidad)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_insertar_ventas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Ventas", id_ventas);
                this.Comando.Parameters.AddWithValue("id_Factura", id_factura);
                this.Comando.Parameters.AddWithValue("id_Producto", id_producto);
                this.Comando.Parameters.AddWithValue("cantidad", cantidad);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int editar_venta(string id_ventas, string id_factura, string id_producto, string cantidad)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_editar_ventas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Ventas", id_ventas);
                this.Comando.Parameters.AddWithValue("id_Factura", id_factura);
                this.Comando.Parameters.AddWithValue("id_Producto", id_producto);
                this.Comando.Parameters.AddWithValue("cantidad", cantidad);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        public int eliminar_venta(string id_ventas)
        {
            int filas = 0;
            try
            {

                this.Comando = new SqlCommand("SP_eliminar_ventas", this.Conexion);
                this.Comando.CommandType = CommandType.StoredProcedure;

                this.Comando.Parameters.AddWithValue("id_Ventas", id_ventas);
                filas = this.Comando.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                filas = Ex.ErrorCode;
            }
            return filas;
        }
        #endregion
    }
}
