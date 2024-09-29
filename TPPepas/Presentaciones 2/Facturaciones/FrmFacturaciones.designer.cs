namespace TPPepas.Presentaciones_2.Facturaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxTotal = new System.Windows.Forms.TextBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.cIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdRecetas = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBoxTipoProducto = new System.Windows.Forms.ComboBox();
            this.cboBoxProducto = new System.Windows.Forms.ComboBox();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.labelMutual = new System.Windows.Forms.Label();
            this.txtNombreMutual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTotal
            // 
            this.txtBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotal.Location = new System.Drawing.Point(547, 541);
            this.txtBoxTotal.Name = "txtBoxTotal";
            this.txtBoxTotal.ReadOnly = true;
            this.txtBoxTotal.Size = new System.Drawing.Size(129, 22);
            this.txtBoxTotal.TabIndex = 8;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.BackColor = System.Drawing.Color.Transparent;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHora.Location = new System.Drawing.Point(537, 18);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(18, 25);
            this.labelHora.TabIndex = 21;
            this.labelHora.Text = ".";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(242, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 37);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nueva Factura";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label3_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(87, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(105, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Producto";
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
            this.cIdAcciones});
            this.dgvDetalles.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvDetalles.Location = new System.Drawing.Point(31, 355);
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.Size = new System.Drawing.Size(645, 167);
            this.dgvDetalles.TabIndex = 5;
            this.dgvDetalles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalles_CellContentClick);
            this.dgvDetalles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvDetalles_RowsAdded);
            this.dgvDetalles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvDetalles_RowsRemoved_1);
            // 
            // cIdProducto
            // 
            this.cIdProducto.HeaderText = "ProductoID";
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
            // 
            // cIdAcciones
            // 
            this.cIdAcciones.HeaderText = "Acciones";
            this.cIdAcciones.Name = "cIdAcciones";
            this.cIdAcciones.ReadOnly = true;
            this.cIdAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cIdAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCliente.Location = new System.Drawing.Point(219, 97);
            this.txtCliente.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(264, 22);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Location = new System.Drawing.Point(31, 308);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(645, 41);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(166, 530);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 45);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(489, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 25);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConfirmar.Location = new System.Drawing.Point(41, 530);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(109, 45);
            this.btnConfirmar.TabIndex = 6;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(469, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(112, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cliente";
            // 
            // cboBoxTipoProducto
            // 
            this.cboBoxTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxTipoProducto.FormattingEnabled = true;
            this.cboBoxTipoProducto.Location = new System.Drawing.Point(219, 129);
            this.cboBoxTipoProducto.Name = "cboBoxTipoProducto";
            this.cboBoxTipoProducto.Size = new System.Drawing.Size(355, 24);
            this.cboBoxTipoProducto.TabIndex = 1;
            this.cboBoxTipoProducto.SelectedIndexChanged += new System.EventHandler(this.cboBoxTipoProducto_SelectedIndexChanged_1);
            // 
            // cboBoxProducto
            // 
            this.cboBoxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxProducto.FormattingEnabled = true;
            this.cboBoxProducto.Location = new System.Drawing.Point(219, 162);
            this.cboBoxProducto.Name = "cboBoxProducto";
            this.cboBoxProducto.Size = new System.Drawing.Size(218, 24);
            this.cboBoxProducto.TabIndex = 2;
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(663, 0);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(51, 25);
            this.btnSalir2.TabIndex = 24;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel5.Controls.Add(this.btnSalir2);
            this.panel5.Controls.Add(this.labelHora);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(0, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(714, 70);
            this.panel5.TabIndex = 32;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Crimson;
            this.lblAviso.Location = new System.Drawing.Point(297, 268);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(186, 16);
            this.lblAviso.TabIndex = 25;
            this.lblAviso.Text = "Complete los campos faltantes";
            this.lblAviso.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(443, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Cantidad";
            // 
            // numCantidad
            // 
            this.numCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCantidad.Location = new System.Drawing.Point(518, 162);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(56, 22);
            this.numCantidad.TabIndex = 34;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(70, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Formas de Pago";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(219, 199);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(355, 24);
            this.cboFormaPago.TabIndex = 36;
            // 
            // labelMutual
            // 
            this.labelMutual.AutoSize = true;
            this.labelMutual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMutual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMutual.Location = new System.Drawing.Point(112, 237);
            this.labelMutual.Name = "labelMutual";
            this.labelMutual.Size = new System.Drawing.Size(52, 16);
            this.labelMutual.TabIndex = 37;
            this.labelMutual.Text = "Mutual";
            // 
            // txtNombreMutual
            // 
            this.txtNombreMutual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMutual.Location = new System.Drawing.Point(219, 234);
            this.txtNombreMutual.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.txtNombreMutual.Name = "txtNombreMutual";
            this.txtNombreMutual.ReadOnly = true;
            this.txtNombreMutual.Size = new System.Drawing.Size(355, 22);
            this.txtNombreMutual.TabIndex = 38;
            // 
            // FrmFacturaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(716, 589);
            this.Controls.Add(this.txtNombreMutual);
            this.Controls.Add(this.labelMutual);
            this.Controls.Add(this.cboFormaPago);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboBoxTipoProducto);
            this.Controls.Add(this.cboBoxProducto);
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "FrmFacturaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturaciones";
            this.Load += new System.EventHandler(this.FrmFacturaciones_Load_1);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmFacturaciones_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxTotal;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBoxTipoProducto;
        private System.Windows.Forms.ComboBox cboBoxProducto;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.Label labelMutual;
        private System.Windows.Forms.TextBox txtNombreMutual;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdPrecio;
        private System.Windows.Forms.DataGridViewButtonColumn cIdRecetas;
        private System.Windows.Forms.DataGridViewButtonColumn cIdAcciones;
    }
}