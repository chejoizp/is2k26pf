using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador_Ventas;

namespace Capa_Vista_Ventas
{
    public partial class Frm_Asignacion_Clientes : Form
    {
        Cls_Asignacion_Clientes_Controlador controlador = new Cls_Asignacion_Clientes_Controlador();
        public Frm_Asignacion_Clientes()
        {
            InitializeComponent();
            this.Load += Frm_Asignacion_Clientes_Load;
        }
        private void Frm_Asignacion_Clientes_Load(object sender, EventArgs e)
        {
            CargarVendedores();
            CargarClientes();
            CargarGrid();
        }
        private void CargarVendedores()
        {
            Cbo_Id_Vendedor.DataSource = controlador.ObtenerVendedores();
            Cbo_Id_Vendedor.DisplayMember = "NombreCompleto";
            Cbo_Id_Vendedor.ValueMember = "Pk_Id_Vendedor";
            Cbo_Id_Vendedor.SelectedIndex = -1;
        }
        private void CargarClientes()
        {
            Cbo_Id_Cliente.DataSource = controlador.ObtenerClientes();
            Cbo_Id_Cliente.DisplayMember = "NombreCompleto";
            Cbo_Id_Cliente.ValueMember = "Pk_Id_Cliente";
            Cbo_Id_Cliente.SelectedIndex = -1;
        }
        private void CargarGrid()
        {
            Dgv_Asignacion_clientes.DataSource = controlador.ObtenerAsignacionesConNombres();
            //Ocultar columnas ID
            Dgv_Asignacion_clientes.Columns["Pk_Id_Vendedor"].Visible = false;
            Dgv_Asignacion_clientes.Columns["Pk_Id_Cliente"].Visible = false;
        }
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cbo_Id_Vendedor.SelectedValue == null || Cbo_Id_Cliente.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar vendedor y cliente.");
                    return;
                }

                int idVendedor = Convert.ToInt32(Cbo_Id_Vendedor.SelectedValue);
                int idCliente = Convert.ToInt32(Cbo_Id_Cliente.SelectedValue);

                var resultado = controlador.GuardarAsignacion(idVendedor, idCliente);

                MessageBox.Show(resultado.message);

                if (resultado.success)
                {
                    CargarGrid(); 
                    Cbo_Id_Vendedor.SelectedIndex = -1;
                    Cbo_Id_Cliente.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Reporte_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
