using System;
using System.Data;
using Npgsql;

namespace Proyecto.base_de_datos
{

	public class ProductoDAO
	{
		private Conexion dbConn = new Conexion();

		//Cargar los productos desde la base de datos
		public DataTable ObtenerProductos()
		{
			DataTable dt = new DataTable();
			try
			{
                using (NpgsqlConnection conn = dbConn.GetConnection())
                {
					conn.Open();
                    string query = @"SELECT
										id_producto,
										nombre,
										precio,
										stock,
										TO_CHAR(fecha_registro, 'DD/MM/YYYY') as fecha_registro
										FROM productos
										ORDER BY id_producto";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						using (NpgsqlDataReader reader = cmd.ExecuteReader())
						{
							dt.Load(reader);
						}
					}
				}
			}
			// Manejo de errores
			catch (Exception ex)
			{
				throw new Exception("Error al obtener los productos: " + ex.Message);
			}
			return dt;
		}
		//Agregar un nuevo producto a la base de datos
		public bool AgregarProducto(int id_producto, string nombre, decimal precio, int stock, string fecha)
		{
			try
			{
				using (NpgsqlConnection conn = dbConn.GetConnection())
				{
					conn.Open();
					string query = @"INSERT INTO productos (id_producto, nombre, precio, stock, fecha_registro)
									VALUES (@id_producto, @nombre, @precio, @stock, TO_DATE(@fecha, 'DD/MM/YYYY'))";

					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id_producto", id_producto);
						cmd.Parameters.AddWithValue("@nombre", nombre);
						cmd.Parameters.AddWithValue("@precio", precio);
						cmd.Parameters.AddWithValue("@stock", stock);
						cmd.Parameters.AddWithValue("@fecha", fecha);
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			// Manejo de errores
			catch (Npgsql.PostgresException pgEx) when (pgEx.SqlState == "23505")
			{
				throw new Exception("Error: Ya hay un producto con ese ID.");
			}
			catch (Exception ex)
			{
				throw new Exception("Error al agregar el producto: " + ex.Message);
			}
		}
		//Actualizar un producto en la base de datos
		public bool ActualizarProducto(int id_producto, string nombre, decimal precio, int stock, string fecha)
		{
			try
			{
				using (NpgsqlConnection conn = dbConn.GetConnection())
				{
					conn.Open();
					string query = @"UPDATE productos
									 SET nombre = @nombre,
										 precio = @precio,
										 stock = @stock,
										 fecha_registro = TO_DATE(@fecha, 'DD/MM/YYYY')
									 WHERE id_producto = @id_producto";
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id_producto", id_producto);
						cmd.Parameters.AddWithValue("@nombre", nombre);
						cmd.Parameters.AddWithValue("@precio", precio);
						cmd.Parameters.AddWithValue("@stock", stock);
						cmd.Parameters.AddWithValue("@fecha", fecha);
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			// Manejo de errores
			catch (Exception ex)
			{
				throw new Exception("Error al actualizar el producto: " + ex.Message);
			}
		}
		//Eliminar un producto de la base de datos
		public bool EliminarProducto(int id_producto)
		{
			try
			{
				using (NpgsqlConnection conn = dbConn.GetConnection())
				{
					conn.Open();
					string query = @"DELETE FROM productos WHERE id_producto = @id_producto";
					using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@id_producto", id_producto);
						int rowsAffected = cmd.ExecuteNonQuery();
						return rowsAffected > 0;
					}
				}
			}
			// Manejo de errores
			catch (Exception ex)
			{
				throw new Exception("Error al eliminar el producto: " + ex.Message);
			}
		}
        public int ObtenerConteoProductos()
        {
            try
            {
                using (NpgsqlConnection conn = dbConn.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM productos";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener conteo: " + ex.Message);
            }
        }
    }
}
