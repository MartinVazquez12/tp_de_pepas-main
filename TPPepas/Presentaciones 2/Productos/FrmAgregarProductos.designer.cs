namespace TPPepas.Presentaciones_2.PProductos
{
    partial class FrmAgregarProductos
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
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboTipoPresentacion = new System.Windows.Forms.ComboBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.nudPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAviso = new System.Windows.Forms.Label();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.nudStockminimo = new System.Windows.Forms.Label();
            this.checkBoxVentaLibre = new System.Windows.Forms.CheckBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(459, 0);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(42, 26);
            this.btnSalir2.TabIndex = 26;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(64, 396);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(392, 31);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cboTipoPresentacion
            // 
            this.cboTipoPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPresentacion.FormattingEnabled = true;
            this.cboTipoPresentacion.Location = new System.Drawing.Point(228, 175);
            this.cboTipoPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPresentacion.Name = "cboTipoPresentacion";
            this.cboTipoPresentacion.Size = new System.Drawing.Size(228, 24);
            this.cboTipoPresentacion.TabIndex = 3;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(228, 215);
            this.cboTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(228, 24);
            this.cboTipoProducto.TabIndex = 4;
            // 
            // nudPrecioUnitario
            // 
            this.nudPrecioUnitario.DecimalPlaces = 2;
            this.nudPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrecioUnitario.Location = new System.Drawing.Point(228, 139);
            this.nudPrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioUnitario.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudPrecioUnitario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudPrecioUnitario.Name = "nudPrecioUnitario";
            this.nudPrecioUnitario.Size = new System.Drawing.Size(228, 22);
            this.nudPrecioUnitario.TabIndex = 1;
            this.nudPrecioUnitario.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(228, 101);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(228, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(33, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "Tipo de presentacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(47, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tipo de producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(69, 328);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 31;
            this.label5.Text = "Venta libre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(57, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Precio unitario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripcion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(109, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 37);
            this.label8.TabIndex = 42;
            this.label8.Text = "Nuevo Producto";
            this.label8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label8_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel3.Controls.Add(this.btnSalir2);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(0, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(501, 59);
            this.panel3.TabIndex = 46;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 254);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Laboratorio";
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Crimson;
            this.lblAviso.Location = new System.Drawing.Point(167, 364);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(186, 16);
            this.lblAviso.TabIndex = 49;
            this.lblAviso.Text = "Complete los campos faltantes";
            this.lblAviso.Visible = false;
            // 
            // nudStockMin
            // 
            this.nudStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockMin.Location = new System.Drawing.Point(228, 289);
            this.nudStockMin.Margin = new System.Windows.Forms.Padding(2);
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(228, 22);
            this.nudStockMin.TabIndex = 50;
            // 
            // nudStockminimo
            // 
            this.nudStockminimo.AutoSize = true;
            this.nudStockminimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockminimo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudStockminimo.Location = new System.Drawing.Point(61, 289);
            this.nudStockminimo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nudStockminimo.Name = "nudStockminimo";
            this.nudStockminimo.Size = new System.Drawing.Size(99, 16);
            this.nudStockminimo.TabIndex = 51;
            this.nudStockminimo.Text = "Stock Minimo";
            // 
            // checkBoxVentaLibre
            // 
            this.checkBoxVentaLibre.AutoSize = true;
            this.checkBoxVentaLibre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxVentaLibre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVentaLibre.Location = new System.Drawing.Point(228, 330);
            this.checkBoxVentaLibre.Name = "checkBoxVentaLibre";
            this.checkBoxVentaLibre.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVentaLibre.TabIndex = 52;
            this.checkBoxVentaLibre.UseVisualStyleBackColor = true;
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(228, 251);
            this.cboLaboratorio.Margin = new System.Windows.Forms.Padding(2);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(228, 24);
            this.cboLaboratorio.TabIndex = 4;
            // 
            // FrmAgregarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(499, 457);
            this.Controls.Add(this.checkBoxVentaLibre);
            this.Controls.Add(this.nudStockMin);
            this.Controls.Add(this.nudStockminimo);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboTipoPresentacion);
            this.Controls.Add(this.cboLaboratorio);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.nudPrecioUnitario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarProductos";
            this.Load += new System.EventHandler(this.FrmAgregarProductos_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmAgregarProductos_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cboTipoPresentacion;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.NumericUpDown nudPrecioUnitario;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.Label nudStockminimo;
        private System.Windows.Forms.CheckBox checkBoxVentaLibre;
        private System.Windows.Forms.ComboBox cboLaboratorio;
    }
}