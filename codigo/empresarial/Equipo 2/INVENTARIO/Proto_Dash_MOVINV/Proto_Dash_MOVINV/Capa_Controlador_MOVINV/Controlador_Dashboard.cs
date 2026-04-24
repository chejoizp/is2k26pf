using System.Data;
using Capa_Modelo_MOVINV;

namespace Capa_Controlador_MOVINV
{
    public class Controlador_Dashboard
    {
        Sentencias sn = new Sentencias();

        // Este es el que ya tenías, lo dejamos para que no truene nada de lo anterior
        public DataTable LlenarGridControlador(string tabla)
        {
            return sn.ObtenerTabla(tabla);
        }

        // NUEVO MÉTODO: Para filtrar según los ComboBox de tu diseño
        // Recibe los IDs seleccionados en la Vista
        public DataTable FiltrarDatosControlador(string idBodega, string idTipo)
        {
            // Aquí llamaremos al método de filtrado que agregaremos en Sentencias
            return sn.obtenerInventarioFiltrado(idBodega, idTipo);
        }

        // NUEVO MÉTODO: Para llenar los ComboBox (Bodegas y Líneas) al cargar el form
        public DataTable LlenarComboControlador(string tabla, string id, string nombre)
        {
            return sn.obtenerDatosCombo(tabla, id, nombre);
        }
    }
}