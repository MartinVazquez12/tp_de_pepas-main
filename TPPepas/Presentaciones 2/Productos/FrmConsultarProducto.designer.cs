namespace TPPepas.Presentaciones_2.PProductos
{
    partial class FrmConsultarProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.cboTipoProductos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAviso = new System.Windows.Forms.Label();
            this.dgvConsultarProductos = new System.Windows.Forms.DataGridView();
            this.cIdObjectProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdVentaLibre = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cIdTipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIdAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cIdDeshabilitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(730, 0);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(51, 25);
            this.btnSalir2.TabIndex = 27;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // cboTipoProductos
            // 
            this.cboTipoProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProductos.FormattingEnabled = true;
            this.cboTipoProductos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboTipoProductos.Location = new System.Drawing.Point(233, 118);
            this.cboTipoProductos.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoProductos.Name = "cboTipoProductos";
            this.cboTipoProductos.Size = new System.Drawing.Size(440, 24);
            this.cboTipoProductos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tipo de producto";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpiar.Location = new System.Drawing.Point(418, 196);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(138, 24);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBuscar.Location = new System.Drawing.Point(261, 196);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(138, 24);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(233, 86);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(440, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(99, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(240, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(311, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Consultar Producto";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnSalir2);
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 60);
            this.panel2.TabIndex = 46;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Crimson;
            this.lblAviso.Location = new System.Drawing.Point(344, 157);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(186, 16);
            this.lblAviso.TabIndex = 47;
            this.lblAviso.Text = "Complete los campos faltantes";
            this.lblAviso.Visible = false;
            // 
            // dgvConsultarProductos
            // 
            this.dgvConsultarProductos.AllowUserToAddRows = false;
            this.dgvConsultarProductos.AllowUserToDeleteRows = false;
            this.dgvConsultarProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.55F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvConsultarProductos.Location = new System.Drawing.Point(11, 233);
            this.dgvConsultarProductos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultarProductos.Name = "dgvConsultarProductos";
            this.dgvConsultarProductos.ReadOnly = true;
            this.dgvConsultarProductos.RowHeadersWidth = 62;
            this.dgvConsultarProductos.RowTemplate.Height = 28;
            this.dgvConsultarProductos.Size = new System.Drawing.Size(765, 250);
            this.dgvConsultarProductos.TabIndex = 48;
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
            // FrmConsultarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(784, 505);
            this.Controls.Add(this.dgvConsultarProductos);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cboTipoProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarProducto";
            this.Load += new System.EventHandler(this.FrmConsultarProducto_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmConsultarProducto_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.ComboBox cboTipoProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.DataGridView dgvConsultarProductos;
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