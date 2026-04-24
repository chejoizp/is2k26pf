
namespace Capa_Vista_MOVINV
{
    partial class Frm_consulta_INV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gpb_Control = new System.Windows.Forms.GroupBox();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_ayuda = new System.Windows.Forms.Button();
            this.txb_x_codigo = new System.Windows.Forms.TextBox();
            this.Cmb_tipo_prod = new System.Windows.Forms.ComboBox();
            this.lbl_x_nombre = new System.Windows.Forms.Label();
            this.lbl_bodega = new System.Windows.Forms.Label();
            this.Gpb_Orden = new System.Windows.Forms.GroupBox();
            this.rdb_DESC = new System.Windows.Forms.RadioButton();
            this.rdb_ASC = new System.Windows.Forms.RadioButton();
            this.lbl_tipo_prod = new System.Windows.Forms.Label();
            this.Cmb_bodega = new System.Windows.Forms.ComboBox();
            this.dgv_control_INV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.Gpb_Control.SuspendLayout();
            this.Gpb_Orden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_INV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "730 - CONTROL INVENTARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 52);
            this.panel1.TabIndex = 4;
            // 
            // Gpb_Control
            // 
            this.Gpb_Control.Controls.Add(this.btn_Imprimir);
            this.Gpb_Control.Controls.Add(this.btn_Salir);
            this.Gpb_Control.Controls.Add(this.btn_ayuda);
            this.Gpb_Control.Controls.Add(this.txb_x_codigo);
            this.Gpb_Control.Controls.Add(this.Cmb_tipo_prod);
            this.Gpb_Control.Controls.Add(this.lbl_x_nombre);
            this.Gpb_Control.Controls.Add(this.lbl_bodega);
            this.Gpb_Control.Controls.Add(this.Gpb_Orden);
            this.Gpb_Control.Controls.Add(this.lbl_tipo_prod);
            this.Gpb_Control.Controls.Add(this.Cmb_bodega);
            this.Gpb_Control.Location = new System.Drawing.Point(12, 80);
            this.Gpb_Control.Name = "Gpb_Control";
            this.Gpb_Control.Size = new System.Drawing.Size(1119, 130);
            this.Gpb_Control.TabIndex = 12;
            this.Gpb_Control.TabStop = false;
            this.Gpb_Control.Text = "Control Inventario";
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Location = new System.Drawing.Point(859, 35);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(72, 63);
            this.btn_Imprimir.TabIndex = 19;
            this.btn_Imprimir.Text = "IMPRIMIR";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(1015, 36);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(72, 62);
            this.btn_Salir.TabIndex = 18;
            this.btn_Salir.Text = "SALIR";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_ayuda
            // 
            this.btn_ayuda.Location = new System.Drawing.Point(937, 36);
            this.btn_ayuda.Name = "btn_ayuda";
            this.btn_ayuda.Size = new System.Drawing.Size(72, 62);
            this.btn_ayuda.TabIndex = 17;
            this.btn_ayuda.Text = "AYUDA";
            this.btn_ayuda.UseVisualStyleBackColor = true;
            // 
            // txb_x_codigo
            // 
            this.txb_x_codigo.Location = new System.Drawing.Point(717, 63);
            this.txb_x_codigo.Name = "txb_x_codigo";
            this.txb_x_codigo.Size = new System.Drawing.Size(100, 20);
            this.txb_x_codigo.TabIndex = 15;
            // 
            // Cmb_tipo_prod
            // 
            this.Cmb_tipo_prod.FormattingEnabled = true;
            this.Cmb_tipo_prod.Location = new System.Drawing.Point(211, 62);
            this.Cmb_tipo_prod.Name = "Cmb_tipo_prod";
            this.Cmb_tipo_prod.Size = new System.Drawing.Size(121, 21);
            this.Cmb_tipo_prod.TabIndex = 16;
            this.Cmb_tipo_prod.SelectedIndexChanged += new System.EventHandler(this.Cmb_tipo_prod_SelectedIndexChanged);
            // 
            // lbl_x_nombre
            // 
            this.lbl_x_nombre.AutoSize = true;
            this.lbl_x_nombre.Location = new System.Drawing.Point(714, 46);
            this.lbl_x_nombre.Name = "lbl_x_nombre";
            this.lbl_x_nombre.Size = new System.Drawing.Size(94, 13);
            this.lbl_x_nombre.TabIndex = 14;
            this.lbl_x_nombre.Text = "Buscar por Codigo";
            // 
            // lbl_bodega
            // 
            this.lbl_bodega.AutoSize = true;
            this.lbl_bodega.Location = new System.Drawing.Point(13, 46);
            this.lbl_bodega.Name = "lbl_bodega";
            this.lbl_bodega.Size = new System.Drawing.Size(100, 13);
            this.lbl_bodega.TabIndex = 14;
            this.lbl_bodega.Text = "Seleccione Bodega";
            // 
            // Gpb_Orden
            // 
            this.Gpb_Orden.Controls.Add(this.rdb_DESC);
            this.Gpb_Orden.Controls.Add(this.rdb_ASC);
            this.Gpb_Orden.Location = new System.Drawing.Point(361, 19);
            this.Gpb_Orden.Name = "Gpb_Orden";
            this.Gpb_Orden.Size = new System.Drawing.Size(329, 100);
            this.Gpb_Orden.TabIndex = 13;
            this.Gpb_Orden.TabStop = false;
            this.Gpb_Orden.Text = "Ordenar";
            // 
            // rdb_DESC
            // 
            this.rdb_DESC.AutoSize = true;
            this.rdb_DESC.Location = new System.Drawing.Point(169, 40);
            this.rdb_DESC.Name = "rdb_DESC";
            this.rdb_DESC.Size = new System.Drawing.Size(106, 17);
            this.rdb_DESC.TabIndex = 1;
            this.rdb_DESC.TabStop = true;
            this.rdb_DESC.Text = "DESCENDENTE";
            this.rdb_DESC.UseVisualStyleBackColor = true;
            // 
            // rdb_ASC
            // 
            this.rdb_ASC.AutoSize = true;
            this.rdb_ASC.Location = new System.Drawing.Point(39, 40);
            this.rdb_ASC.Name = "rdb_ASC";
            this.rdb_ASC.Size = new System.Drawing.Size(98, 17);
            this.rdb_ASC.TabIndex = 0;
            this.rdb_ASC.TabStop = true;
            this.rdb_ASC.Text = "ASCENDENTE";
            this.rdb_ASC.UseVisualStyleBackColor = true;
            // 
            // lbl_tipo_prod
            // 
            this.lbl_tipo_prod.AutoSize = true;
            this.lbl_tipo_prod.Location = new System.Drawing.Point(208, 46);
            this.lbl_tipo_prod.Name = "lbl_tipo_prod";
            this.lbl_tipo_prod.Size = new System.Drawing.Size(89, 13);
            this.lbl_tipo_prod.TabIndex = 15;
            this.lbl_tipo_prod.Text = "Tipo de Producto";
            // 
            // Cmb_bodega
            // 
            this.Cmb_bodega.FormattingEnabled = true;
            this.Cmb_bodega.Location = new System.Drawing.Point(16, 62);
            this.Cmb_bodega.Name = "Cmb_bodega";
            this.Cmb_bodega.Size = new System.Drawing.Size(121, 21);
            this.Cmb_bodega.TabIndex = 13;
            this.Cmb_bodega.SelectedIndexChanged += new System.EventHandler(this.Cmb_bodega_SelectedIndexChanged);
            // 
            // dgv_control_INV
            // 
            this.dgv_control_INV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_control_INV.Location = new System.Drawing.Point(12, 216);
            this.dgv_control_INV.Name = "dgv_control_INV";
            this.dgv_control_INV.Size = new System.Drawing.Size(1119, 399);
            this.dgv_control_INV.TabIndex = 13;
            // 
            // Frm_consulta_INV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 655);
            this.Controls.Add(this.dgv_control_INV);
            this.Controls.Add(this.Gpb_Control);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_consulta_INV";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gpb_Control.ResumeLayout(false);
            this.Gpb_Control.PerformLayout();
            this.Gpb_Orden.ResumeLayout(false);
            this.Gpb_Orden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_control_INV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox Gpb_Control;
        private System.Windows.Forms.TextBox txb_x_codigo;
        private System.Windows.Forms.ComboBox Cmb_tipo_prod;
        private System.Windows.Forms.Label lbl_x_nombre;
        private System.Windows.Forms.Label lbl_bodega;
        private System.Windows.Forms.GroupBox Gpb_Orden;
        private System.Windows.Forms.RadioButton rdb_DESC;
        private System.Windows.Forms.RadioButton rdb_ASC;
        private System.Windows.Forms.Label lbl_tipo_prod;
        private System.Windows.Forms.ComboBox Cmb_bodega;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_ayuda;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.DataGridView dgv_control_INV;
    }
}