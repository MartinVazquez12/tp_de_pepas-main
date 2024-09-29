namespace TPPepas.Presentaciones
{
    partial class frmAgregarProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.nudPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.nudStockminimo = new System.Windows.Forms.NumericUpDown();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.cboTipoPresentacion = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.checkBoxVentaLibre = new System.Windows.Forms.CheckBox();
            this.cboLaboratorio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockminimo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Laboratorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Venta libre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo de producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tipo de presentacion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(99, 33);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcion.TabIndex = 7;
            // 
            // nudPrecioUnitario
            // 
            this.nudPrecioUnitario.Location = new System.Drawing.Point(99, 86);
            this.nudPrecioUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.nudPrecioUnitario.Name = "nudPrecioUnitario";
            this.nudPrecioUnitario.Size = new System.Drawing.Size(187, 20);
            this.nudPrecioUnitario.TabIndex = 8;
            // 
            // nudStockminimo
            // 
            this.nudStockminimo.Location = new System.Drawing.Point(99, 196);
            this.nudStockminimo.Margin = new System.Windows.Forms.Padding(2);
            this.nudStockminimo.Name = "nudStockminimo";
            this.nudStockminimo.Size = new System.Drawing.Size(187, 20);
            this.nudStockminimo.TabIndex = 10;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(422, 83);
            this.cboTipoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(181, 21);
            this.cboTipoProducto.TabIndex = 12;
            // 
            // cboTipoPresentacion
            // 
            this.cboTipoPresentacion.FormattingEnabled = true;
            this.cboTipoPresentacion.Location = new System.Drawing.Point(423, 138);
            this.cboTipoPresentacion.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoPresentacion.Name = "cboTipoPresentacion";
            this.cboTipoPresentacion.Size = new System.Drawing.Size(181, 21);
            this.cboTipoPresentacion.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(329, 181);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(272, 31);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // checkBoxVentaLibre
            // 
            this.checkBoxVentaLibre.AutoSize = true;
            this.checkBoxVentaLibre.Location = new System.Drawing.Point(422, 33);
            this.checkBoxVentaLibre.Name = "checkBoxVentaLibre";
            this.checkBoxVentaLibre.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVentaLibre.TabIndex = 15;
            this.checkBoxVentaLibre.UseVisualStyleBackColor = true;
            // 
            // cboLaboratorio
            // 
            this.cboLaboratorio.FormattingEnabled = true;
            this.cboLaboratorio.Location = new System.Drawing.Point(100, 139);
            this.cboLaboratorio.Name = "cboLaboratorio";
            this.cboLaboratorio.Size = new System.Drawing.Size(187, 21);
            this.cboLaboratorio.TabIndex = 16;
            // 
            // frmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 238);
            this.Controls.Add(this.cboLaboratorio);
            this.Controls.Add(this.checkBoxVentaLibre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboTipoPresentacion);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.nudStockminimo);
            this.Controls.Add(this.nudPrecioUnitario);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarProducto";
            this.Text = "frmAgregarProducto";
            this.Load += new System.EventHandler(this.frmAgregarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockminimo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.NumericUpDown nudPrecioUnitario;
        private System.Windows.Forms.NumericUpDown nudStockminimo;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.ComboBox cboTipoPresentacion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox checkBoxVentaLibre;
        private System.Windows.Forms.ComboBox cboLaboratorio;
    }
}