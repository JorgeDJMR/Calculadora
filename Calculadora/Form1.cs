using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaTopicos;


namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //varibles para realizar las operaciones
        Double primerNumero = 0;
        Double segundoNumero = 0, resultado = 0;
        string operacionVigente = "";
        
        operacionesCalculadora Libreria = new operacionesCalculadora();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSuma_Click(object sender, EventArgs e)
        {
            try
            {
                primerNumero = Convert.ToDouble(textBox1.Text);
                operacionVigente = Libreria.VCambioOperacionesSuma(operacionVigente);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                operacionVigente = "Suma";
            }


            //try
            //{
            //    primerNumero = Convert.ToDouble(textBox1.Text);
            //    operacionVigente = "Suma";
            //    textBox1.Text = "";
            //}
            //catch (Exception)
            //{
            //    operacionVigente = "Suma";
            //}

        }
        private void btResta_Click(object sender, EventArgs e)
        {

            

            try
            {

                primerNumero = Convert.ToDouble(textBox1.Text);
                operacionVigente = Libreria.VCambioOperacionesrResta(operacionVigente);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                operacionVigente = "Resta";
            }


            //try
            //{
            //    primerNumero = Convert.ToDouble(textBox1.Text);
            //    operacionVigente = "Resta";
            //    textBox1.Text = "";
            //}
            //catch (Exception)
            //{
            //    operacionVigente = "Resta";
            //}

        }
        private void btDivision_Click(object sender, EventArgs e)
        {
            try
            {
                primerNumero = Convert.ToDouble(textBox1.Text);
                operacionVigente = Libreria.VCambioOperacionesrDivision(operacionVigente);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                operacionVigente = "Division";
            }
            //try
            //{
            //    primerNumero = Convert.ToDouble(textBox1.Text);
            //    operacionVigente = "Division";
            //    textBox1.Text = "";
            //}
            //catch (Exception)
            //{
            //    operacionVigente = "Division";
            //}

        }
        private void btMultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                primerNumero = Convert.ToDouble(textBox1.Text);
                operacionVigente = Libreria.VCambioOperacionesMultiplicacion(operacionVigente);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                operacionVigente = "Multiplicacion";
            }
            //try
            //{
            //    primerNumero = Convert.ToDouble(textBox1.Text);
            //    operacionVigente = "Multiplicacion";
            //    textBox1.Text = "";
            //}
            //catch (Exception)
            //{
            //    operacionVigente = "Multiplicacion";
            //}

        }
        private void btElevado_Click(object sender, EventArgs e)
        {
            try
            {
                primerNumero = Convert.ToDouble(textBox1.Text);
                operacionVigente = Libreria.VCambioOperacionesrElevado(operacionVigente);
                textBox1.Text = "";
            }
            catch (Exception)
            {
                operacionVigente = "Elevado";
            }
            //try
            //{
            //    primerNumero = Convert.ToDouble(textBox1.Text);
            //    operacionVigente = "Elevado";
            //    textBox1.Text = "";

            //}
            //catch (Exception)
            //{
            //    operacionVigente = "Elevado";

            //}

        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            operacionesCalculadora objeto = new operacionesCalculadora();
            segundoNumero = Convert.ToDouble(textBox1.Text);

            switch (operacionVigente)
            {
                case "Suma":
                    resultado = objeto.Suma(primerNumero, segundoNumero);
                    textBox1.Text = resultado.ToString();

                    //resultado = primerNumero + segundoNumero;
                    //textBox1.Text =resultado.ToString();
                    break;
                case "Resta":
                    resultado = objeto.Resta(primerNumero, segundoNumero);
                    //resultado = primerNumero - segundoNumero;
                    textBox1.Text = resultado.ToString();
                    break;
                case "Multiplicacion":
                    resultado = objeto.Multi(primerNumero, segundoNumero);
                    //resultado = primerNumero * segundoNumero;
                    textBox1.Text = resultado.ToString();
                    break;
                case "Division":
                    resultado = objeto.Division(primerNumero, segundoNumero);
                    //resultado = primerNumero / segundoNumero;
                    textBox1.Text = resultado.ToString();
                    break;
                case "Elevado":
                    //resultado = Math.Pow(primerNumero, segundoNumero);
                    resultado = objeto.Elevado(primerNumero, segundoNumero);
                    textBox1.Text = resultado.ToString();
                    break;

            }
            
        }


        private void bt1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }
        private void bt3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text += "9";
            }

        }

        private void bt0_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains("0"))
            {
                return;
            }
            else
            {
                textBox1.Text += "0";
            }
            //alternativo
            //if (textBox1.Text.Contains("01"))
            //{
            //    return;
            //}
            //else
            //{
            //    textBox1.Text += "0";
            //}

        }





        private void btBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = Libreria.VBorrarUno(textBox1.Text);
            
            //Origninal
            //try
            //{
            //    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            //}
            //catch (Exception)
            //{
            //    textBox1.Text = null;
            //}
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(e.KeyChar == 'q')
            //{
            //    MessageBox.Show("Tas pendejo");
            //}

            //Bloquea las letras del teclado ORIGINAL
            //if (Char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Tas pendejo, vuelve a intentarlo");
            //    e.Handled = true;
            //}

            //Otra manera, bloquea todo
            //if (true)
            //{
            //    e.Handled = false;
            //}
            //if(true)
            //{
            //    e.Handled = true;
            //}

            Libreria.vLetras(sender, e);


        }

        private void btBorrarTodo_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void btBorrarTotalmente_Click(object sender, EventArgs e)
        {
            primerNumero = 0;
            segundoNumero = 0;
            operacionVigente = "";
            textBox1.Clear();
        }

        private void cambioSigno_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))
            {
                textBox1.Text.Trim();
            }
        }



        private void btRaizCuadrada_Click(object sender, EventArgs e)
        {
            primerNumero = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            resultado = Math.Sqrt(primerNumero);
            textBox1.Text = resultado.ToString();
            
        }

        private void btPunto_Click(object sender, EventArgs e)
        {
            string puntito = ".";
            if (Libreria.ValidacionPunto(textBox1.Text))
            {
                return;
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text += "0.";
                }
                else
                {
                    textBox1.Text += ".";
                }
            }

            //Origninal
            //if (textBox1.Text.Contains("."))
            //{
            //    return;
            //}
            //if (textBox1.Text == "")
            //{
            //    textBox1.Text += "0.";
            //}
            //else
            //{
            //    textBox1.Text += ".";
            //}
        }


    }
}
