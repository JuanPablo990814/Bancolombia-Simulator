namespace Vista
{
    partial class SolicitudCredito
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
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtPrestamo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvSolicitudCredito = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbTipoPrestamo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCarta = new System.Windows.Forms.Button();
            this.cmbNumCuotas = new System.Windows.Forms.ComboBox();
            this.lblCalculado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCedula
            // 
            this.txtCedula.BackColor = System.Drawing.Color.LightGreen;
            this.txtCedula.Location = new System.Drawing.Point(35, 123);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(161, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            // 
            // txtPrestamo
            // 
            this.txtPrestamo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPrestamo.Location = new System.Drawing.Point(328, 71);
            this.txtPrestamo.Name = "txtPrestamo";
            this.txtPrestamo.Size = new System.Drawing.Size(161, 20);
            this.txtPrestamo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1  Cedula";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2    Valor del prestamo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(194, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 24);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvSolicitudCredito
            // 
            this.dgvSolicitudCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSolicitudCredito.Location = new System.Drawing.Point(3, 193);
            this.dgvSolicitudCredito.Name = "dgvSolicitudCredito";
            this.dgvSolicitudCredito.Size = new System.Drawing.Size(956, 196);
            this.dgvSolicitudCredito.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(447, 163);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.txtCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "- Calcular Posivilida de Credito";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(834, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "3";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de Prestamo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(526, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "- Incluir la Cedula";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbTipoPrestamo
            // 
            this.cmbTipoPrestamo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbTipoPrestamo.FormattingEnabled = true;
            this.cmbTipoPrestamo.Items.AddRange(new object[] {
            "Libre Inversion",
            "Vehiculos",
            "Vivienda"});
            this.cmbTipoPrestamo.Location = new System.Drawing.Point(328, 116);
            this.cmbTipoPrestamo.Name = "cmbTipoPrestamo";
            this.cmbTipoPrestamo.Size = new System.Drawing.Size(161, 21);
            this.cmbTipoPrestamo.TabIndex = 15;
            this.cmbTipoPrestamo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPrestamo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(325, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "# de Cuotas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(728, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 39);
            this.label6.TabIndex = 19;
            this.label6.Text = "Creditos de libre inversion: 12,24 o 36 meses\r\nCreditos de vehiculos 12,35,48 o 6" +
    "0 meses\r\nCreditos de vivienda de 120 a 360 meses\r\n";
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(852, 160);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(75, 23);
            this.btnCarta.TabIndex = 20;
            this.btnCarta.Text = "Generar Carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            this.btnCarta.Click += new System.EventHandler(this.btnCartar_Click);
            // 
            // cmbNumCuotas
            // 
            this.cmbNumCuotas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbNumCuotas.FormattingEnabled = true;
            this.cmbNumCuotas.Items.AddRange(new object[] {
            "12",
            "24",
            "35",
            "48",
            "60",
            "120",
            "360"});
            this.cmbNumCuotas.Location = new System.Drawing.Point(328, 163);
            this.cmbNumCuotas.Name = "cmbNumCuotas";
            this.cmbNumCuotas.Size = new System.Drawing.Size(76, 21);
            this.cmbNumCuotas.TabIndex = 21;
            this.cmbNumCuotas.SelectedIndexChanged += new System.EventHandler(this.cmbNumCuotas_SelectedIndexChanged);
            // 
            // lblCalculado
            // 
            this.lblCalculado.AutoSize = true;
            this.lblCalculado.ForeColor = System.Drawing.Color.Green;
            this.lblCalculado.Location = new System.Drawing.Point(543, 123);
            this.lblCalculado.Name = "lblCalculado";
            this.lblCalculado.Size = new System.Drawing.Size(71, 13);
            this.lblCalculado.TabIndex = 22;
            this.lblCalculado.Text = "No Calculado";
            this.lblCalculado.Click += new System.EventHandler(this.label10_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bancolombia.Properties.Resources.Bancolombia;
            this.pictureBox1.Location = new System.Drawing.Point(3, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // SolicitudCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(971, 401);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCalculado);
            this.Controls.Add(this.cmbNumCuotas);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbTipoPrestamo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dgvSolicitudCredito);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrestamo);
            this.Controls.Add(this.txtCedula);
            this.Name = "SolicitudCredito";
            this.Text = "Solicitud Credito";
            this.Load += new System.EventHandler(this.SolicitudCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSolicitudCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtPrestamo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvSolicitudCredito;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbTipoPrestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.ComboBox cmbNumCuotas;
        private System.Windows.Forms.Label lblCalculado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}