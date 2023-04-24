namespace Clase_Windows_Form
{
    public partial class Form1 : Form
    {
        //LOGICA
        public Form1()
        {
            InitializeComponent();
        }
        //sender: objeto que genero al objeto - EventArgs maneja al evento
        private void btnMostrar_Click(object sender, EventArgs e)
        {




            String nombre;
            int edad;
            String genero;
            String estadoCivil;
            bool futbol, tenis, natacion;



            nombre = txtNombre.Text;
            edad = int.Parse(txtEdad.Text);// parseo porque txt recibe una cadena
            futbol = chkFutbol.Checked;
            tenis = chkTenis.Checked;
            natacion = chkNatacion.Checked;
            /*if (chkFutbol.Checked)
            {
                MessageBox.Show("Futbol");
            }
            if (chkTenis.Checked)
            {
                MessageBox.Show("Tenis");
            }
            if (chkNatacion.Checked)
            {
                MessageBox.Show("Natacion");
            }*/
            if (radFemenino.Checked)
            {
                genero = radFemenino.Text;
            }
            else
            {
                genero = radMasculino.Text;
            }
            if (radCasado.Checked)
            {
                estadoCivil = radCasado.Text;
            }
            else
            {
                estadoCivil = radSoltero.Text;
            }
            Persona miPersona = new Persona(nombre, edad, estadoCivil, genero, futbol, tenis, natacion);
            // MessageBox.Show("Bienvenido " + nombre + " Tu edad es: " + edad, "Pestaña ATR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            MessageBox.Show(miPersona.ToString());


        }

        private void lblEdad_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}