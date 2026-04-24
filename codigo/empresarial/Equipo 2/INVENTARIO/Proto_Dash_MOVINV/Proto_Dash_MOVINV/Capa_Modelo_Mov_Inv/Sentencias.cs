using System;
using System.Data;
using System.Data.Odbc; // Asegúrate de usar ODBC para tu DSN bd_SIG

namespace Capa_Modelo_MOVINV
{
    public class Sentencias
    {
        Conexion con = new Conexion();

        // Para el Dashboard (Ultimos movimientos)
        public DataTable ObtenerTabla(string tabla)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM " + tabla + " LIMIT 10;";
                OdbcDataAdapter adp = new OdbcDataAdapter(sql, con.conectar());
                adp.Fill(dt);
            }
            catch (Exception ex) { /* Manejo de error */ }
            return dt;
        }

        // 1. Método para obtener el inventario filtrado
        // Recibe los IDs de los combos. Si vienen vacíos o en "0", no filtra.
        public DataTable obtenerInventarioFiltrado(string idBodega, string idTipo)
        {
            DataTable dt = new DataTable();
            try
            {
                // Consulta base con JOINs para que el usuario vea NOMBRES y no solo IDs
                string sql = @"SELECT 
                                e.Fk_Id_Producto AS 'Código', 
                                p.Cmp_Nombre_Producto AS 'Producto', 
                                b.Cmp_Nombre_Bodega AS 'Bodega', 
                                e.Cmp_Cantidad_Existencia AS 'Existencia'
                               FROM tbl_existencias e
                               INNER JOIN tbl_producto p ON e.Fk_Id_Producto = p.Pk_Id_Producto
                               INNER JOIN tbl_bodega b ON e.Fk_Id_Bodega = b.Pk_Id_Bodega
                               WHERE 1=1"; // El 1=1 permite agregar filtros con "AND" fácilmente

                // Filtro por Bodega
                if (!string.IsNullOrEmpty(idBodega) && idBodega != "0")
                {
                    sql += " AND e.Fk_Id_Bodega = '" + idBodega + "'";
                }

                // Filtro por Tipo de Producto (Línea)
                if (!string.IsNullOrEmpty(idTipo) && idTipo != "0")
                {
                    sql += " AND p.Fk_Id_Linea = '" + idTipo + "'";
                }

                OdbcDataAdapter adp = new OdbcDataAdapter(sql, con.conectar());
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al filtrar inventario: " + ex.Message);
            }
            return dt;
        }

        // 2. Método para llenar los ComboBox (necesario para que el usuario elija la bodega)
        public DataTable obtenerDatosCombo(string tabla, string campoId, string campoNombre)
        {
            DataTable dt = new DataTable();
            try
            {
                string sql = $"SELECT {campoId}, {campoNombre} FROM {tabla} WHERE Cmp_Estado = 1";
                OdbcDataAdapter adp = new OdbcDataAdapter(sql, con.conectar());
                adp.Fill(dt);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al cargar datos de combo: " + ex.Message);
            }
            return dt;
        }
    }
}