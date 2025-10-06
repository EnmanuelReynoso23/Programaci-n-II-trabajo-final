using System;
using Npgsql;

namespace Proyecto.base_de_datos
{
    public class Conexion
    {
        private string conexionString;

        public Conexion()
        {
            conexionString = "Host=db.pztlyjvnukuikgxnkgxo.supabase.co;" +
                "Username=postgres;" +
                "Password=o25rx0LEoO57IhDm;" +
                "Database=postgres;" +
                "Port=5432;" +
                "Pooling=true;" +
                "SSL Mode=Require;" +
                "Trust Server Certificate=true";
        }

        public NpgsqlConnection GetConnection() 
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection(conexionString);
                return conn;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo conectar con la base de datos:" + ex.Message);
            }
        }
    }
}
