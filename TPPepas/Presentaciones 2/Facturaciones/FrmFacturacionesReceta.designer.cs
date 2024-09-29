namespace TPPepas.Presentaciones_2.Facturaciones
{
    partial class FrmFacturacionesReceta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir2 = new System.Windows.Forms.Button();
            this.lblMedico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricula)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipoReceta
            // 
            this.cboTipoReceta.FormattingEnabled = true;
            this.cboTipoReceta.Location = new System.Drawing.Point(120, 139);
            this.cboTipoReceta.Name = "cboTipoReceta";
            this.cboTipoReceta.Size = new System.Drawing.Size(198, 21);
            this.cboTipoReceta.TabIndex = 0;
            // 
            // numCantidad
            // 
            this.numCantidad.Location = new System.Drawing.Point(121, 72);
            this.numCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(197, 20);
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Agregar Receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo Receta";
            // 
            // Producto
            // 
            this.Producto.AutoSize = true;
            this.Producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Producto.Location = new System.Drawing.Point(36, 176);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(69, 16);
            this.Producto.TabIndex = 3;
            this.Producto.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(36, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cantidad";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmar.Location = new System.Drawing.Point(64, 212);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(180, 23);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtBoxProducto
            // 
            this.txtBoxProducto.Location = new System.Drawing.Point(120, 172);
            this.txtBoxProducto.Name = "txtBoxProducto";
            this.txtBoxProducto.ReadOnly = true;
            this.txtBoxProducto.Size = new System.Drawing.Size(198, 20);
            this.txtBoxProducto.TabIndex = 6;
            // 
            // numMatricula
            // 
            this.numMatricula.Location = new System.Drawing.Point(121, 104);
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
            this.numMatricula.Size = new System.Drawing.Size(197, 20);
            this.numMatricula.TabIndex = 2;
            this.numMatricula.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel1.Controls.Add(this.btnSalir2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-9, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 50);
            this.panel1.TabIndex = 7;
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(312, 3);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(29, 23);
            this.btnSalir2.TabIndex = 26;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedico.ForeColor = System.Drawing.Color.Crimson;
            this.lblMedico.Location = new System.Drawing.Point(75, 192);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(159, 16);
            this.lblMedico.TabIndex = 26;
            this.lblMedico.Text = "No se encontro el medico";
            this.lblMedico.Visible = false;
            // 
            // FrmFacturacionesReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(330, 256);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBoxProducto);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.Producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numMatricula);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.cboTipoReceta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturacionesReceta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturacionesReceta";
            this.Load += new System.EventHandler(this.frmFacturacionesReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMatricula)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Label lblMedico;
    }
}