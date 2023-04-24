using Billetes;
using WF_Ejercicio_C01.Properties;

namespace WF_Ejercicio_C01
{
    public partial class Form1 : Form
    {
        bool interruptor = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double cantidadEuro;
            if (double.TryParse(txtCantidadEuro.Text, out cantidadEuro))
            {
                Euro euro = new Euro(cantidadEuro, double.Parse(txtEuro.Text));
                Dolar dolar = (Dolar)euro;
                Peso peso = (Peso)euro;

                txtEuroEuro.Text = double.Parse(txtCantidadEuro.Text).ToString();
                txtEuroDolar.Text = dolar.Cantidad.ToString();
                txtEuroPeso.Text = peso.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("ERROR,Ingresa un numero.\n");
            }
        }
        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double cantidadDolar;
            if (double.TryParse(txtCantidadDolar.Text, out cantidadDolar))
            {
                Dolar dolar = new Dolar(cantidadDolar, double.Parse(txtDolar.Text));
                Euro euro = (Euro)dolar;
                Peso peso = (Peso)dolar;

                txtDolarDolar.Text = double.Parse(txtCantidadDolar.Text).ToString();
                txtDolarEuro.Text = euro.Cantidad.ToString();
                txtDolarPeso.Text = peso.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("ERROR,Ingresa un numero.\n");
            }
        }
        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double cantidadPeso;
            if (double.TryParse(txtCantidadPeso.Text,out cantidadPeso))
            {
                Peso peso = new Peso(cantidadPeso, double.Parse(txtPeso.Text));
                Euro euro = (Euro)peso;
                Dolar dolar = (Dolar)peso;

                txtPesoPeso.Text = double.Parse(txtCantidadPeso.Text).ToString();
                txtPesoEuro.Text = euro.Cantidad.ToString();
                txtPesoDolar.Text = dolar.Cantidad.ToString();
            }
            else
            {
                MessageBox.Show("ERROR,Ingresa un numero.\n");
            }
        }

        private void txtPeso_Load(object sender, EventArgs e)
        {        
            SetEstadoCandado(false);
        }

        private void SetEstadoCandado(bool interruptor2)
        {
            interruptor = interruptor2;
            if (interruptor == false)
            {           
                btnConvertDolar.Enabled = false;
                btnConvertEuro.Enabled = false;
                btnConvertPeso.Enabled = false;
                btnCandado.BackgroundImage = Resources.candadoAbierto;
                txtEuro.ReadOnly = false;
                txtPeso.ReadOnly = false;
            }
            else
            {
                txtEuro.ReadOnly = true;
                txtPeso.ReadOnly = true;
                btnConvertDolar.Enabled = true;
                btnConvertEuro.Enabled = true;
                btnConvertPeso.Enabled = true;
                btnCandado.BackgroundImage = Resources.candadoCerrado;
            }
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPeso.Text, out double auxliarPesoCotizacion) &&
              double.TryParse(txtEuro.Text, out double auxiliarEuroCotizacion))
            {
                Peso.Cotizacion = auxliarPesoCotizacion;
                Euro.Cotizacion = auxiliarEuroCotizacion;
                SetEstadoCandado(!interruptor);
            }
            else
            {
                MessageBox.Show("ERROR, Cargue cotizaciones antes de bloquearlas\n");
            }
        }
    }
}