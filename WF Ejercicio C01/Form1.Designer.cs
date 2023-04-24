namespace WF_Ejercicio_C01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCotizacion = new Label();
            txtCantidadEuro = new TextBox();
            txtCantidadPeso = new TextBox();
            txtCantidadDolar = new TextBox();
            lblEuro = new Label();
            lblDolar = new Label();
            lblPeso = new Label();
            txtPeso = new TextBox();
            txtDolar = new TextBox();
            txtEuro = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtPesoEuro = new TextBox();
            txtEuroEuro = new TextBox();
            txtDolarEuro = new TextBox();
            txtEuroDolar = new TextBox();
            txtDolarDolar = new TextBox();
            txtPesoDolar = new TextBox();
            txtEuroPeso = new TextBox();
            txtDolarPeso = new TextBox();
            txtPesoPeso = new TextBox();
            btnCandado = new Button();
            SuspendLayout();
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(77, 13);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(81, 20);
            lblCotizacion.TabIndex = 0;
            lblCotizacion.Text = "Cotizacion";
            // 
            // txtCantidadEuro
            // 
            txtCantidadEuro.Location = new Point(77, 70);
            txtCantidadEuro.Name = "txtCantidadEuro";
            txtCantidadEuro.Size = new Size(100, 23);
            txtCantidadEuro.TabIndex = 1;
            // 
            // txtCantidadPeso
            // 
            txtCantidadPeso.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidadPeso.Location = new Point(77, 149);
            txtCantidadPeso.Name = "txtCantidadPeso";
            txtCantidadPeso.Size = new Size(100, 23);
            txtCantidadPeso.TabIndex = 2;
            // 
            // txtCantidadDolar
            // 
            txtCantidadDolar.Location = new Point(77, 109);
            txtCantidadDolar.Name = "txtCantidadDolar";
            txtCantidadDolar.Size = new Size(100, 23);
            txtCantidadDolar.TabIndex = 3;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblEuro.Location = new Point(12, 73);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(41, 20);
            lblEuro.TabIndex = 4;
            lblEuro.Text = "Euro";
            lblEuro.Click += label1_Click;
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblDolar.Location = new Point(12, 109);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(47, 20);
            lblDolar.TabIndex = 5;
            lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblPeso.Location = new Point(12, 151);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(42, 20);
            lblPeso.TabIndex = 6;
            lblPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(574, 10);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Cotizacion ARS";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 7;
            txtPeso.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(437, 9);
            txtDolar.Name = "txtDolar";
            txtDolar.ReadOnly = true;
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 8;
            txtDolar.Text = "1";
            txtDolar.TextAlign = HorizontalAlignment.Center;
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(294, 9);
            txtEuro.Name = "txtEuro";
            txtEuro.PlaceholderText = "Cotizacion EU";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 9;
            txtEuro.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(325, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 10;
            label1.Text = "Euro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(464, 47);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 11;
            label2.Text = "Dolar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(605, 47);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 12;
            label3.Text = "Peso";
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Enabled = false;
            btnConvertEuro.Location = new Point(200, 70);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 13;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Enabled = false;
            btnConvertDolar.Location = new Point(200, 108);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 14;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Enabled = false;
            btnConvertPeso.Location = new Point(200, 148);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 15;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtPesoEuro
            // 
            txtPesoEuro.Location = new Point(294, 148);
            txtPesoEuro.Name = "txtPesoEuro";
            txtPesoEuro.ReadOnly = true;
            txtPesoEuro.Size = new Size(100, 23);
            txtPesoEuro.TabIndex = 16;
            // 
            // txtEuroEuro
            // 
            txtEuroEuro.Location = new Point(294, 74);
            txtEuroEuro.Name = "txtEuroEuro";
            txtEuroEuro.ReadOnly = true;
            txtEuroEuro.Size = new Size(100, 23);
            txtEuroEuro.TabIndex = 17;
            // 
            // txtDolarEuro
            // 
            txtDolarEuro.Location = new Point(294, 110);
            txtDolarEuro.Name = "txtDolarEuro";
            txtDolarEuro.ReadOnly = true;
            txtDolarEuro.Size = new Size(100, 23);
            txtDolarEuro.TabIndex = 18;
            // 
            // txtEuroDolar
            // 
            txtEuroDolar.Location = new Point(437, 74);
            txtEuroDolar.Name = "txtEuroDolar";
            txtEuroDolar.ReadOnly = true;
            txtEuroDolar.Size = new Size(100, 23);
            txtEuroDolar.TabIndex = 19;
            // 
            // txtDolarDolar
            // 
            txtDolarDolar.Location = new Point(437, 109);
            txtDolarDolar.Name = "txtDolarDolar";
            txtDolarDolar.ReadOnly = true;
            txtDolarDolar.Size = new Size(100, 23);
            txtDolarDolar.TabIndex = 20;
            // 
            // txtPesoDolar
            // 
            txtPesoDolar.Location = new Point(437, 149);
            txtPesoDolar.Name = "txtPesoDolar";
            txtPesoDolar.ReadOnly = true;
            txtPesoDolar.Size = new Size(100, 23);
            txtPesoDolar.TabIndex = 21;
            // 
            // txtEuroPeso
            // 
            txtEuroPeso.Location = new Point(574, 74);
            txtEuroPeso.Name = "txtEuroPeso";
            txtEuroPeso.ReadOnly = true;
            txtEuroPeso.Size = new Size(100, 23);
            txtEuroPeso.TabIndex = 22;
            // 
            // txtDolarPeso
            // 
            txtDolarPeso.Location = new Point(574, 109);
            txtDolarPeso.Name = "txtDolarPeso";
            txtDolarPeso.ReadOnly = true;
            txtDolarPeso.Size = new Size(100, 23);
            txtDolarPeso.TabIndex = 23;
            // 
            // txtPesoPeso
            // 
            txtPesoPeso.Location = new Point(574, 149);
            txtPesoPeso.Name = "txtPesoPeso";
            txtPesoPeso.ReadOnly = true;
            txtPesoPeso.Size = new Size(100, 23);
            txtPesoPeso.TabIndex = 24;
            // 
            // btnCandado
            // 
            btnCandado.BackgroundImageLayout = ImageLayout.Zoom;
            btnCandado.Location = new Point(200, 1);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(75, 47);
            btnCandado.TabIndex = 25;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 207);
            Controls.Add(btnCandado);
            Controls.Add(txtPesoPeso);
            Controls.Add(txtDolarPeso);
            Controls.Add(txtEuroPeso);
            Controls.Add(txtPesoDolar);
            Controls.Add(txtDolarDolar);
            Controls.Add(txtEuroDolar);
            Controls.Add(txtDolarEuro);
            Controls.Add(txtEuroEuro);
            Controls.Add(txtPesoEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEuro);
            Controls.Add(txtDolar);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            Controls.Add(txtCantidadDolar);
            Controls.Add(txtCantidadPeso);
            Controls.Add(txtCantidadEuro);
            Controls.Add(lblCotizacion);
            Name = "Form1";
            Text = "Convertidor";
            Load += txtPeso_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCotizacion;
        private TextBox txtCantidadEuro;
        private TextBox txtCantidadPeso;
        private TextBox txtCantidadDolar;
        private Label lblEuro;
        private Label lblDolar;
        private Label lblPeso;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private TextBox txtEuro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtPesoEuro;
        private TextBox txtEuroEuro;
        private TextBox txtDolarEuro;
        private TextBox txtEuroDolar;
        private TextBox txtDolarDolar;
        private TextBox txtPesoDolar;
        private TextBox txtEuroPeso;
        private TextBox txtDolarPeso;
        private TextBox txtPesoPeso;
        private Button btnCandado;
    }
}