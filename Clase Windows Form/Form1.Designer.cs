namespace Clase_Windows_Form
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
            btnMostrar = new Button();
            lblNombre = new Label();
            lblEdad = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            chkTenis = new CheckBox();
            chkNatacion = new CheckBox();
            chkFutbol = new CheckBox();
            radFemenino = new RadioButton();
            radMasculino = new RadioButton();
            lblSexo = new Label();
            radSoltero = new RadioButton();
            radCasado = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.FromArgb(128, 255, 255);
            btnMostrar.Location = new Point(325, 201);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 0;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 34);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(50, 73);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            lblEdad.Click += lblEdad_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 31);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 3;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(108, 70);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 23);
            txtEdad.TabIndex = 4;
            // 
            // chkTenis
            // 
            chkTenis.AutoSize = true;
            chkTenis.Location = new Point(23, 34);
            chkTenis.Name = "chkTenis";
            chkTenis.Size = new Size(52, 19);
            chkTenis.TabIndex = 6;
            chkTenis.Text = "Tenis";
            chkTenis.UseVisualStyleBackColor = true;
            // 
            // chkNatacion
            // 
            chkNatacion.AutoSize = true;
            chkNatacion.Location = new Point(23, 59);
            chkNatacion.Name = "chkNatacion";
            chkNatacion.Size = new Size(74, 19);
            chkNatacion.TabIndex = 7;
            chkNatacion.Text = "Natacion";
            chkNatacion.UseVisualStyleBackColor = true;
            // 
            // chkFutbol
            // 
            chkFutbol.AutoSize = true;
            chkFutbol.Location = new Point(23, 13);
            chkFutbol.Name = "chkFutbol";
            chkFutbol.Size = new Size(60, 19);
            chkFutbol.TabIndex = 9;
            chkFutbol.Text = "Futbol";
            chkFutbol.UseVisualStyleBackColor = true;
            // 
            // radFemenino
            // 
            radFemenino.AutoSize = true;
            radFemenino.Location = new Point(16, 18);
            radFemenino.Name = "radFemenino";
            radFemenino.Size = new Size(78, 19);
            radFemenino.TabIndex = 10;
            radFemenino.TabStop = true;
            radFemenino.Text = "Femenino";
            radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            radMasculino.AutoSize = true;
            radMasculino.Location = new Point(17, 58);
            radMasculino.Name = "radMasculino";
            radMasculino.Size = new Size(80, 19);
            radMasculino.TabIndex = 11;
            radMasculino.TabStop = true;
            radMasculino.Text = "Masculino";
            radMasculino.UseVisualStyleBackColor = true;
            radMasculino.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Location = new Point(344, 227);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(32, 15);
            lblSexo.TabIndex = 13;
            lblSexo.Text = "Sexo";
            // 
            // radSoltero
            // 
            radSoltero.AutoSize = true;
            radSoltero.Location = new Point(11, 26);
            radSoltero.Name = "radSoltero";
            radSoltero.Size = new Size(62, 19);
            radSoltero.TabIndex = 14;
            radSoltero.TabStop = true;
            radSoltero.Text = "Soltero";
            radSoltero.UseVisualStyleBackColor = true;
            radSoltero.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radCasado
            // 
            radCasado.AutoSize = true;
            radCasado.Location = new Point(12, 51);
            radCasado.Name = "radCasado";
            radCasado.Size = new Size(64, 19);
            radCasado.TabIndex = 15;
            radCasado.TabStop = true;
            radCasado.Text = "Casado";
            radCasado.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radMasculino);
            groupBox1.Controls.Add(radFemenino);
            groupBox1.Location = new Point(50, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(99, 85);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Genero";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radCasado);
            groupBox2.Controls.Add(radSoltero);
            groupBox2.Location = new Point(155, 124);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(86, 77);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estado Civil";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkTenis);
            groupBox3.Controls.Add(chkNatacion);
            groupBox3.Controls.Add(chkFutbol);
            groupBox3.Location = new Point(235, 31);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(118, 84);
            groupBox3.TabIndex = 17;
            groupBox3.TabStop = false;
            groupBox3.Text = "Deportes";
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblSexo);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Controls.Add(btnMostrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrar;
        private Label lblNombre;
        private Label lblEdad;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private CheckBox chkTenis;
        private CheckBox chkNatacion;
        private CheckBox chkFutbol;
        private RadioButton radFemenino;
        private RadioButton radMasculino;
        private Label lblSexo;
        private RadioButton radSoltero;
        private RadioButton radCasado;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private FileSystemWatcher fileSystemWatcher1;
    }
}