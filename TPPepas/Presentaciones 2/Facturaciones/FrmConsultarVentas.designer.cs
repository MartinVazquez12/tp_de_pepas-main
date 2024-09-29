namespace TPPepas.Presentaciones_2.Facturaciones
{
    partial class FrmConsultarVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdRecetas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(645, 141);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(645, 100);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 34);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(522, 141);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(109, 22);
            this.dtpHasta.TabIndex = 3;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(522, 109);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(109, 22);
            this.dtpDesde.TabIndex = 2;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroFactura.Location = new System.Drawing.Point(217, 138);
            this.txtNroFactura.Margin = new System.Windows.Forms.Padding(2);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(182, 22);
            this.txtNroFactura.TabIndex = 1;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(217, 106);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(182, 22);
            this.txtCliente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(409, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(406, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(108, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nro Factura";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cliente.Location = new System.Drawing.Point(131, 109);
            this.Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(55, 16);
            this.Cliente.TabIndex = 12;
            this.Cliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(279, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consulta de Ventas";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(841, 0);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(51, 25);
            this.btnSalir2.TabIndex = 25;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel5.Controls.Add(this.btnSalir2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(2, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(892, 60);
            this.panel5.TabIndex = 30;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Crimson;
            this.lblAviso.Location = new System.Drawing.Point(213, 172);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(186, 16);
            this.lblAviso.TabIndex = 26;
            this.lblAviso.Text = "Complete los campos faltantes";
            this.lblAviso.Visible = false;
            // 
            // dgvDetalles
            // 
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AllowUserToOrderColumns = true;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdProducto,
            this.cIdDescripcion,
            this.cIdCantidad,
            this.cIdDescuento,
            this.cIdPrecio,
            this.cIdRecetas,
            this.dataGridViewButtonColumn1});
            this.dgvDetalles.Location = new System.Drawing.Point(111, 233);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(644, 239);
            this.dgvDetalles.TabIndex = 32;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
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
            // dgvConsultarVentas
            // 
            this.dgvConsultarVentas.AllowUserToAddRows = false;
            this.dgvConsultarVentas.AllowUserToDeleteRows = false;
            this.dgvConsultarVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvConsultarVentas.Location = new System.Drawing.Point(9, 210);
            this.dgvConsultarVentas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarVentas.Name = "dgvConsultarVentas";
            this.dgvConsultarVentas.ReadOnly = true;
            this.dgvConsultarVentas.RowHeadersWidth = 62;
            this.dgvConsultarVentas.Size = new System.Drawing.Size(865, 262);
            this.dgvConsultarVentas.TabIndex = 31;
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
            this.cIdEmpleado.Visible = false;
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
            // FrmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(894, 495);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvConsultarVentas);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.panel5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarVentas";
            this.Load += new System.EventHandler(this.FrmConsultarVentas_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConsultarVentas_MouseDown);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIdRecetas;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridView dgvConsultarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdObjectFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdNroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdFormaPago;
        private System.Windows.Forms.DataGridViewButtonColumn cIdDetalles;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
    }
}