namespace TPPepas.Presentaciones_2.Consultas
{
    partial class FrmConsultas
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
            this.panel6 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboNroConsulta = new System.Windows.Forms.ComboBox();
            this.lblEnunc = new System.Windows.Forms.Label();
            this.lblParam = new System.Windows.Forms.Label();
            this.txtParam2 = new System.Windows.Forms.TextBox();
            this.txtParam1 = new System.Windows.Forms.TextBox();
            this.lblParam1 = new System.Windows.Forms.Label();
            this.lblParam2 = new System.Windows.Forms.Label();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEnunciado = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblParam3 = new System.Windows.Forms.Label();
            this.txtParam3 = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir2
            // 
            this.btnSalir2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.btnSalir2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir2.Location = new System.Drawing.Point(749, 0);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(51, 25);
            this.btnSalir2.TabIndex = 25;
            this.btnSalir2.Text = "X";
            this.btnSalir2.UseVisualStyleBackColor = false;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.btnSalir2);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(2, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(800, 66);
            this.panel6.TabIndex = 31;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel6_MouseDown);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(119)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(841, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 25);
            this.button5.TabIndex = 25;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(306, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 37);
            this.label6.TabIndex = 22;
            this.label6.Text = "Consultas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Seleccion de Consulta";
            // 
            // cboNroConsulta
            // 
            this.cboNroConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNroConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNroConsulta.FormattingEnabled = true;
            this.cboNroConsulta.Items.AddRange(new object[] {
            "Consulta 1",
            "Consulta 2",
            "Consulta 3",
            "Consulta 4",
            "Consulta 5",
            "Consulta 6"});
            this.cboNroConsulta.Location = new System.Drawing.Point(195, 80);
            this.cboNroConsulta.Name = "cboNroConsulta";
            this.cboNroConsulta.Size = new System.Drawing.Size(253, 24);
            this.cboNroConsulta.TabIndex = 32;
            this.cboNroConsulta.SelectedIndexChanged += new System.EventHandler(this.cboNroConsulta_SelectedIndexChanged);
            // 
            // lblEnunc
            // 
            this.lblEnunc.AutoSize = true;
            this.lblEnunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnunc.Location = new System.Drawing.Point(24, 121);
            this.lblEnunc.Name = "lblEnunc";
            this.lblEnunc.Size = new System.Drawing.Size(84, 16);
            this.lblEnunc.TabIndex = 34;
            this.lblEnunc.Text = "Enunciado:";
            // 
            // lblParam
            // 
            this.lblParam.AutoSize = true;
            this.lblParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParam.Location = new System.Drawing.Point(24, 216);
            this.lblParam.Name = "lblParam";
            this.lblParam.Size = new System.Drawing.Size(91, 16);
            this.lblParam.TabIndex = 36;
            this.lblParam.Text = "Parametros:";
            // 
            // txtParam2
            // 
            this.txtParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam2.Location = new System.Drawing.Point(499, 213);
            this.txtParam2.Margin = new System.Windows.Forms.Padding(2);
            this.txtParam2.Name = "txtParam2";
            this.txtParam2.Size = new System.Drawing.Size(163, 22);
            this.txtParam2.TabIndex = 38;
            // 
            // txtParam1
            // 
            this.txtParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam1.Location = new System.Drawing.Point(184, 213);
            this.txtParam1.Margin = new System.Windows.Forms.Padding(2);
            this.txtParam1.Name = "txtParam1";
            this.txtParam1.Size = new System.Drawing.Size(170, 22);
            this.txtParam1.TabIndex = 37;
            // 
            // lblParam1
            // 
            this.lblParam1.AutoSize = true;
            this.lblParam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParam1.Location = new System.Drawing.Point(121, 216);
            this.lblParam1.Name = "lblParam1";
            this.lblParam1.Size = new System.Drawing.Size(24, 16);
            this.lblParam1.TabIndex = 39;
            this.lblParam1.Text = "p1";
            // 
            // lblParam2
            // 
            this.lblParam2.AutoSize = true;
            this.lblParam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParam2.Location = new System.Drawing.Point(392, 216);
            this.lblParam2.Name = "lblParam2";
            this.lblParam2.Size = new System.Drawing.Size(24, 16);
            this.lblParam2.TabIndex = 40;
            this.lblParam2.Text = "p2";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(57, 295);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(676, 253);
            this.dgvConsulta.TabIndex = 41;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(466, 79);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(143, 24);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLimpiar.Location = new System.Drawing.Point(631, 79);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 24);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEnunciado
            // 
            this.txtEnunciado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEnunciado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnunciado.Location = new System.Drawing.Point(0, 0);
            this.txtEnunciado.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnunciado.Multiline = true;
            this.txtEnunciado.Name = "txtEnunciado";
            this.txtEnunciado.Size = new System.Drawing.Size(650, 74);
            this.txtEnunciado.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtEnunciado);
            this.panel1.Location = new System.Drawing.Point(124, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 74);
            this.panel1.TabIndex = 50;
            // 
            // lblParam3
            // 
            this.lblParam3.AutoSize = true;
            this.lblParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParam3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblParam3.Location = new System.Drawing.Point(121, 255);
            this.lblParam3.Name = "lblParam3";
            this.lblParam3.Size = new System.Drawing.Size(24, 16);
            this.lblParam3.TabIndex = 53;
            this.lblParam3.Text = "p3";
            // 
            // txtParam3
            // 
            this.txtParam3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParam3.Location = new System.Drawing.Point(184, 252);
            this.txtParam3.Margin = new System.Windows.Forms.Padding(2);
            this.txtParam3.Name = "txtParam3";
            this.txtParam3.Size = new System.Drawing.Size(170, 22);
            this.txtParam3.TabIndex = 51;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsultar.Location = new System.Drawing.Point(395, 251);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(267, 24);
            this.btnConsultar.TabIndex = 54;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(802, 585);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblParam3);
            this.Controls.Add(this.txtParam3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lblParam2);
            this.Controls.Add(this.lblParam1);
            this.Controls.Add(this.txtParam2);
            this.Controls.Add(this.txtParam1);
            this.Controls.Add(this.lblParam);
            this.Controls.Add(this.lblEnunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboNroConsulta);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboNroConsulta;
        private System.Windows.Forms.Label lblEnunc;
        private System.Windows.Forms.Label lblParam;
        private System.Windows.Forms.TextBox txtParam2;
        private System.Windows.Forms.TextBox txtParam1;
        private System.Windows.Forms.Label lblParam1;
        private System.Windows.Forms.Label lblParam2;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtEnunciado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblParam3;
        private System.Windows.Forms.TextBox txtParam3;
        private System.Windows.Forms.Button btnConsultar;
    }
}