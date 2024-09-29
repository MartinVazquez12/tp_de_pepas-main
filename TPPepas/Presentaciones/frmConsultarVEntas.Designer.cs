namespace TPPepas.Presentaciones
{
    partial class frmConsultarVentas
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
            this.dgvConsultarVentas = new System.Windows.Forms.DataGridView();
            this.cIdObjectFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdNroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDetalles = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cliente = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdRecetas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultarVentas
            // 
            this.dgvConsultarVentas.AllowUserToAddRows = false;
            this.dgvConsultarVentas.AllowUserToDeleteRows = false;
            this.dgvConsultarVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdObjectFactura,
            this.cIdNroFactura,
            this.cIdFecha,
            this.cIdEmpleado,
            this.cIdCliente,
            this.cIdSucursal,
            this.cIdFormaPago,
            this.cIdDetalles,
            this.cIdAcciones});
            this.dgvConsultarVentas.Location = new System.Drawing.Point(11, 93);
            this.dgvConsultarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarVentas.Name = "dgvConsultarVentas";
            this.dgvConsultarVentas.ReadOnly = true;
            this.dgvConsultarVentas.RowHeadersWidth = 62;
            this.dgvConsultarVentas.Size = new System.Drawing.Size(909, 174);
            this.dgvConsultarVentas.TabIndex = 0;
            this.dgvConsultarVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarVentas_CellContentClick);
            // 
            // cIdObjectFactura
            // 
            this.cIdObjectFactura.HeaderText = "Factura Object";
            this.cIdObjectFactura.Name = "cIdObjectFactura";
            this.cIdObjectFactura.ReadOnly = true;
            this.cIdObjectFactura.Visible = false;
            // 
            // cIdNroFactura
            // 
            this.cIdNroFactura.HeaderText = "Numero Factura";
            this.cIdNroFactura.Name = "cIdNroFactura";
            this.cIdNroFactura.ReadOnly = true;
            // 
            // cIdFecha
            // 
            this.cIdFecha.HeaderText = "Fecha";
            this.cIdFecha.Name = "cIdFecha";
            this.cIdFecha.ReadOnly = true;
            // 
            // cIdEmpleado
            // 
            this.cIdEmpleado.HeaderText = "Empleado";
            this.cIdEmpleado.Name = "cIdEmpleado";
            this.cIdEmpleado.ReadOnly = true;
            // 
            // cIdCliente
            // 
            this.cIdCliente.HeaderText = "Cliente";
            this.cIdCliente.Name = "cIdCliente";
            this.cIdCliente.ReadOnly = true;
            // 
            // cIdSucursal
            // 
            this.cIdSucursal.HeaderText = "Sucursal";
            this.cIdSucursal.Name = "cIdSucursal";
            this.cIdSucursal.ReadOnly = true;
            // 
            // cIdFormaPago
            // 
            this.cIdFormaPago.HeaderText = "Forma de Pago";
            this.cIdFormaPago.Name = "cIdFormaPago";
            this.cIdFormaPago.ReadOnly = true;
            // 
            // cIdDetalles
            // 
            this.cIdDetalles.HeaderText = "Detalles";
            this.cIdDetalles.Name = "cIdDetalles";
            this.cIdDetalles.ReadOnly = true;
            this.cIdDetalles.Text = "Ver";
            // 
            // cIdAcciones
            // 
            this.cIdAcciones.HeaderText = "Acciones";
            this.cIdAcciones.Name = "cIdAcciones";
            this.cIdAcciones.ReadOnly = true;
            this.cIdAcciones.Text = "Dar de Baja";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(48, 26);
            this.Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 1;
            this.Cliente.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nro Factura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha hasta";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(101, 26);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(143, 20);
            this.txtCliente.TabIndex = 5;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(101, 58);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(143, 20);
            this.txtNroFactura.TabIndex = 6;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(348, 27);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(204, 20);
            this.dtpDesde.TabIndex = 7;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(348, 59);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(204, 20);
            this.dtpHasta.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(568, 27);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 22);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(568, 55);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(85, 22);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdProducto,
            this.cIdDescripcion,
            this.cIdCantidad,
            this.cIdDescuento,
            this.cIdPrecio,
            this.cIdRecetas,
            this.dataGridViewButtonColumn1});
            this.dgvDetalles.Location = new System.Drawing.Point(101, 137);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(776, 167);
            this.dgvDetalles.TabIndex = 12;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cIdProducto
            // 
            this.cIdProducto.HeaderText = "DetalleObj";
            this.cIdProducto.Name = "cIdProducto";
            this.cIdProducto.ReadOnly = true;
            this.cIdProducto.Visible = false;
            // 
            // cIdDescripcion
            // 
            this.cIdDescripcion.HeaderText = "Descripcion";
            this.cIdDescripcion.Name = "cIdDescripcion";
            this.cIdDescripcion.ReadOnly = true;
            // 
            // cIdCantidad
            // 
            this.cIdCantidad.HeaderText = "Cantidad";
            this.cIdCantidad.Name = "cIdCantidad";
            this.cIdCantidad.ReadOnly = true;
            // 
            // cIdDescuento
            // 
            this.cIdDescuento.HeaderText = "Descuento";
            this.cIdDescuento.Name = "cIdDescuento";
            this.cIdDescuento.ReadOnly = true;
            // 
            // cIdPrecio
            // 
            this.cIdPrecio.HeaderText = "Precio";
            this.cIdPrecio.Name = "cIdPrecio";
            this.cIdPrecio.ReadOnly = true;
            // 
            // cIdRecetas
            // 
            this.cIdRecetas.HeaderText = "Recetas";
            this.cIdRecetas.Name = "cIdRecetas";
            this.cIdRecetas.ReadOnly = true;
            this.cIdRecetas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Acciones";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 316);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.dgvConsultarVentas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultarVentas";
            this.Text = "frmConsultarVEntas";
            this.Load += new System.EventHandler(this.frmConsultarVEntas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultarVentas;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdObjectFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFormaPago;
        private System.Windows.Forms.DataGridViewButtonColumn cIdDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIdRecetas;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}