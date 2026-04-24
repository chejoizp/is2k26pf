using System;
using System.Data.Odbc; // Librería necesaria para usar el DSN de ODBC
using System.Windows.Forms;

namespace Capa_Modelo_MOVINV
{
    public class Conexion
    {
        // Método para abrir la conexión
        public OdbcConnection conectar()
        {
            // Usamos el nombre del DSN que configuraste en el Panel de Control
            string cadena = "DSN=bd_SIG";
            OdbcConnection conn = new OdbcConnection(cadena);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                // Esto ayudará a tus compañeros si olvidan crear el DSN en sus máquinas
                MessageBox.Show("Error: No se pudo conectar al DSN 'bd_SIG'. " +
                                "Verifica la configuración en el Administrador de ODBC.\n\n" + ex.Message);
            }

            return conn;
        }

        // Es buena práctica tener un método para cerrar la conexión y liberar memoria
        public void desconectar(OdbcConnection conn)
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cerrar la conexión: " + ex.Message);
            }
        }
    }
}