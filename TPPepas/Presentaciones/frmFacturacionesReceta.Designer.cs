namespace TPPepas.Presentaciones
{
    partial class frmFacturacionesReceta
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
            this.cboTipoReceta = new System.Windows.Forms.ComboBox();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Producto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtBoxProducto = new System.Windows.Forms.TextBox();
            this.numMatricula = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Location = new System.Drawing.Point(73, 128);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoReceta.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(74, 59);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(120, 20);
            this.numCantidad.TabIndex = 2;
            this.numCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Receta";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Location = new System.Drawing.Point(18, 163);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(50, 13);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(12, 187);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(179, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtBoxProducto
            // 
            this.txtBoxProducto.Location = new System.Drawing.Point(74, 160);
            this.txtBoxProducto.Name = "txtBoxProducto";
            this.txtBoxProducto.ReadOnly = true;
            this.txtBoxProducto.Size = new System.Drawing.Size(117, 20);
            this.txtBoxProducto.TabIndex = 6;
            // 
            // numMatricula
            // 
            this.numMatricula.Controls[0].Visible = false;
            this.numMatricula.Location = new System.Drawing.Point(73, 93);
            this.numMatricula.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.numMatricula.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMatricula.Name = "numMatricula";
            this.numMatricula.Size = new System.Drawing.Size(120, 20);
            this.numMatricula.TabIndex = 2;
            this.numMatricula.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmFacturacionesReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 220);
            this.Controls.Add(this.txtBoxProducto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numMatricula);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cboTipoReceta);
            this.Name = "frmFacturacionesReceta";
            this.Text = "frmFacturacionesReceta";
            this.Load += new System.EventHandler(this.frmFacturacionesReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoReceta;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtBoxProducto;
        private System.Windows.Forms.NumericUpDown numMatricula;
    }
}