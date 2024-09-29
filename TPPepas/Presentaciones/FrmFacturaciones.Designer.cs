namespace TPPepas.Presentaciones
{
    partial class FrmFacturaciones
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
            this.cboBoxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtBoxCliente = new System.Windows.Forms.TextBox();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cIdRecetas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.cboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMutual = new System.Windows.Forms.Label();
            this.txtBoxNombreMutual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBoxProducto
            // 
            this.cboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxProducto.FormattingEnabled = true;
            this.cboBoxProducto.Location = new System.Drawing.Point(63, 121);
            this.cboBoxProducto.Name = "cboBoxProducto";
            this.cboBoxProducto.Size = new System.Drawing.Size(202, 21);
            this.cboBoxProducto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cliente";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(9, 367);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtBoxCliente
            // 
            this.txtBoxCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBoxCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxCliente.Location = new System.Drawing.Point(52, 56);
            this.txtBoxCliente.Name = "txtBoxCliente";
            this.txtBoxCliente.Size = new System.Drawing.Size(159, 20);
            this.txtBoxCliente.TabIndex = 4;
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
            this.cIdAcciones,
            this.cIdRecetas});
            this.dgvDetalles.Location = new System.Drawing.Point(12, 181);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(776, 167);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            this.dgvDetalles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetalles_RowsAdded);
            this.dgvDetalles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalles_RowsRemoved);
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
            // cIdAcciones
            // 
            this.cIdAcciones.HeaderText = "Acciones";
            this.cIdAcciones.Name = "cIdAcciones";
            this.cIdAcciones.ReadOnly = true;
            this.cIdAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIdAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cIdRecetas
            // 
            this.cIdRecetas.HeaderText = "Recetas";
            this.cIdRecetas.Name = "cIdRecetas";
            this.cIdRecetas.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(90, 367);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 152);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(776, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(217, 56);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nueva Factura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(193, 9);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(18, 25);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = ".";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboBoxTipoProducto
            // 
            this.cboBoxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxTipoProducto.FormattingEnabled = true;
            this.cboBoxTipoProducto.Location = new System.Drawing.Point(87, 88);
            this.cboBoxTipoProducto.Name = "cboBoxTipoProducto";
            this.cboBoxTipoProducto.Size = new System.Drawing.Size(178, 21);
            this.cboBoxTipoProducto.TabIndex = 0;
            this.cboBoxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboBoxTipoProducto_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total";
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Location = new System.Drawing.Point(377, 369);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(129, 20);
            this.txtBoxTotal.TabIndex = 8;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(359, 122);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(52, 20);
            this.numCantidad.TabIndex = 10;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cantidad";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(540, 58);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(178, 21);
            this.cboFormaPago.TabIndex = 0;
            this.cboFormaPago.SelectedIndexChanged += new System.EventHandler(this.cboBoxTipoProducto_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(460, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Forma de Pago";
            // 
            // labelMutual
            // 
            this.labelMutual.AutoSize = true;
            this.labelMutual.Location = new System.Drawing.Point(226, 59);
            this.labelMutual.Name = "labelMutual";
            this.labelMutual.Size = new System.Drawing.Size(39, 13);
            this.labelMutual.TabIndex = 12;
            this.labelMutual.Text = "Mutual";
            this.labelMutual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxNombreMutual
            // 
            this.txtBoxNombreMutual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNombreMutual.Location = new System.Drawing.Point(271, 56);
            this.txtBoxNombreMutual.Name = "txtBoxNombreMutual";
            this.txtBoxNombreMutual.ReadOnly = true;
            this.txtBoxNombreMutual.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombreMutual.TabIndex = 13;
            // 
            // FrmFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 397);
            this.Controls.Add(this.txtBoxNombreMutual);
            this.Controls.Add(this.labelMutual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtBoxCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.cboBoxTipoProducto);
            this.Controls.Add(this.cboBoxProducto);
            this.Name = "FrmFacturaciones";
            this.Text = "5";
            this.Load += new System.EventHandler(this.FrmFacturaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBoxProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBoxCliente;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.ComboBox cboBoxTipoProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
        private System.Windows.Forms.DataGridViewButtonColumn cIdRecetas;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMutual;
        private System.Windows.Forms.TextBox txtBoxNombreMutual;
    }
}