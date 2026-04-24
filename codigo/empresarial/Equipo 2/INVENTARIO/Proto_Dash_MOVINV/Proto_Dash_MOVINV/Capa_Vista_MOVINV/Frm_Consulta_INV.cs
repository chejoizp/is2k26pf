using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// 1. IMPORTANTE: Asegúrate de tener la referencia al controlador
using Capa_Controlador_MOVINV;

namespace Capa_Vista_MOVINV
{
    public partial class Frm_consulta_INV : Form
    {
        // 2. Instanciamos el controlador una sola vez para usarlo en todo el form
        Controlador_Dashboard cd = new Controlador_Dashboard();

        public Frm_consulta_INV()
        {
            InitializeComponent();
            // Llamamos a la carga de datos inicial
            llenarCombos();
        }

        // 3. Método para llenar las opciones de los filtros al iniciar
        public void llenarCombos()
        {
            // Llenar Bodegas (ajusta los nombres de tabla/campos según tu DB)
            DataTable dtBodega = cd.LlenarComboControlador("tbl_bodega", "Pk_Id_Bodega", "Cmp_Nombre_Bodega");
            Cmb_bodega.DataSource = dtBodega;
            Cmb_bodega.ValueMember = "Pk_Id_Bodega";
            Cmb_bodega.DisplayMember = "Cmp_Nombre_Bodega";

            // Llenar Tipo de Producto (Línea)
            DataTable dtTipo = cd.LlenarComboControlador("tbl_linea", "Pk_Id_Linea", "Cmp_Nombre_Linea");
            Cmb_tipo_prod.DataSource = dtTipo;
            Cmb_tipo_prod.ValueMember = "Pk_Id_Linea";
            Cmb_tipo_prod.DisplayMember = "Cmp_Nombre_Linea";
        }

        // 4. Método principal para actualizar el DataGridView según los filtros
        public void actualizarGrid()
        {
            // Solo ejecutamos si los combos ya tienen un valor seleccionado real
            if (Cmb_bodega.SelectedValue != null && Cmb_tipo_prod.SelectedValue != null)
            {
                // Usamos una pequeña validación por si el valor es un objeto de fila de datos
                if (Cmb_bodega.SelectedValue is DataRowView || Cmb_tipo_prod.SelectedValue is DataRowView) return;

                string idB = Cmb_bodega.SelectedValue.ToString();
                string idT = Cmb_tipo_prod.SelectedValue.ToString();

                dgv_control_INV.DataSource = cd.FiltrarDatosControlador(idB, idT);
            }
        }

        // 5. Eventos: Haz doble clic en los ComboBox en el DISEÑO para generar estos métodos
        private void Cmb_bodega_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void Cmb_tipo_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}