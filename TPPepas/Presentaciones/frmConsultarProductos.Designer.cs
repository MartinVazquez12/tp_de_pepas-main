namespace TPPepas.Presentaciones
{
    partial class frmConsultarProductos
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvConsultarProductos = new System.Windows.Forms.DataGridView();
            this.cIdObjectProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdVentaLibre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cIdTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cIdDeshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoProductos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(108, 29);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(181, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvConsultarProductos
            // 
            this.dgvConsultarProductos.AllowUserToAddRows = false;
            this.dgvConsultarProductos.AllowUserToDeleteRows = false;
            this.dgvConsultarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdObjectProducto,
            this.cIdDescripcion,
            this.cIdPrecio,
            this.cIdVentaLibre,
            this.cIdTipoProducto,
            this.cIdLaboratorio,
            this.cIdAcciones,
            this.cIdDeshabilitar});
            this.dgvConsultarProductos.Location = new System.Drawing.Point(9, 170);
            this.dgvConsultarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarProductos.Name = "dgvConsultarProductos";
            this.dgvConsultarProductos.ReadOnly = true;
            this.dgvConsultarProductos.RowHeadersWidth = 62;
            this.dgvConsultarProductos.RowTemplate.Height = 28;
            this.dgvConsultarProductos.Size = new System.Drawing.Size(767, 250);
            this.dgvConsultarProductos.TabIndex = 3;
            this.dgvConsultarProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsultarProductos_CellContentClick);
            // 
            // cIdObjectProducto
            // 
            this.cIdObjectProducto.HeaderText = "Objeto Producto";
            this.cIdObjectProducto.Name = "cIdObjectProducto";
            this.cIdObjectProducto.ReadOnly = true;
            this.cIdObjectProducto.Visible = false;
            // 
            // cIdDescripcion
            // 
            this.cIdDescripcion.HeaderText = "Descripcion";
            this.cIdDescripcion.Name = "cIdDescripcion";
            this.cIdDescripcion.ReadOnly = true;
            // 
            // cIdPrecio
            // 
            this.cIdPrecio.HeaderText = "Precio";
            this.cIdPrecio.Name = "cIdPrecio";
            this.cIdPrecio.ReadOnly = true;
            // 
            // cIdVentaLibre
            // 
            this.cIdVentaLibre.HeaderText = "Venta Libre";
            this.cIdVentaLibre.Name = "cIdVentaLibre";
            this.cIdVentaLibre.ReadOnly = true;
            // 
            // cIdTipoProducto
            // 
            this.cIdTipoProducto.HeaderText = "Tipo Producto";
            this.cIdTipoProducto.Name = "cIdTipoProducto";
            this.cIdTipoProducto.ReadOnly = true;
            this.cIdTipoProducto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIdTipoProducto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIdLaboratorio
            // 
            this.cIdLaboratorio.HeaderText = "Laboratorio";
            this.cIdLaboratorio.Name = "cIdLaboratorio";
            this.cIdLaboratorio.ReadOnly = true;
            this.cIdLaboratorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIdLaboratorio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cIdAcciones
            // 
            this.cIdAcciones.HeaderText = "Stock";
            this.cIdAcciones.Name = "cIdAcciones";
            this.cIdAcciones.ReadOnly = true;
            this.cIdAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIdAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cIdAcciones.Text = "Consultar Stock";
            // 
            // cIdDeshabilitar
            // 
            this.cIdDeshabilitar.HeaderText = "Deshabilitar";
            this.cIdDeshabilitar.Name = "cIdDeshabilitar";
            this.cIdDeshabilitar.ReadOnly = true;
            this.cIdDeshabilitar.Text = "Deshabilitar";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(39, 125);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(90, 24);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(196, 125);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 24);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(353, 125);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 24);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo de producto";
            // 
            // cboTipoProductos
            // 
            this.cboTipoProductos.FormattingEnabled = true;
            this.cboTipoProductos.Location = new System.Drawing.Point(108, 61);
            this.cboTipoProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoProductos.Name = "cboTipoProductos";
            this.cboTipoProductos.Size = new System.Drawing.Size(181, 21);
            this.cboTipoProductos.TabIndex = 9;
            // 
            // frmConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 428);
            this.Controls.Add(this.cboTipoProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvConsultarProductos);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConsultarProductos";
            this.Text = "frmConsultarProductos";
            this.Load += new System.EventHandler(this.frmConsultarProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvConsultarProductos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdObjectProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPrecio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIdVentaLibre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdTipoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdLaboratorio;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
        private System.Windows.Forms.DataGridViewButtonColumn cIdDeshabilitar;
    }
}