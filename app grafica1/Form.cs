using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraLogicLayer;

namespace app_grafica1
{
    public partial class Form : System.Windows.Forms.Form
    {
        public double digito1 = 0;
        public double digito2 = 0;
        public string operacionARealizar = "/";
        public bool fueCalculado = false;
        public double resultadoTotal = 0;

        public Form()
        {
            InitializeComponent();
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            textBox.Text += (sender as Button).Text;
            operacionARealizar = "*";
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            textBox.Text += (sender as Button).Text;
            operacionARealizar = "-";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            textBox.Text += (sender as Button).Text;
            operacionARealizar = "+";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            textBox.Text += (sender as Button).Text;
            operacionARealizar = "/";


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Sterminar
            if (textBox.Text.Length > 0)
            {
                var retorno = textBox.Text.Substring(0, textBox.Text.Length - 1);
                textBox.Text = retorno;

                fueCalculado = true;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
          calcular();
            
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox.Text += (sender as Button).Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            
            textBox.Text += (sender as Button).Text;

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (fueCalculado)
            {
                textBox.Text = "";
                fueCalculado = false;
            }
            textBox.Text += (sender as Button).Text;
        }

        public void  calcular()
        {
            try
            {

                switch (textBox.Text.Substring(0, 1))
                {
                    case "+":
                        MessageBox.Show("No puedes usar un operardor sin antes especificar un numero", "Error");
                        textBox.Text = "0";
                        break;
                    case "-":
                        MessageBox.Show("No puedes usar un operardor sin antes especificar un numero", "Error");
                        textBox.Text = "0";
                        break;
                    case "*":
                        MessageBox.Show("No puedes usar un operardor sin antes especificar un numero", "Error");
                        textBox.Text = "0";
                        break;
                    case "/":
                        MessageBox.Show("No puedes usar un operardor sin antes especificar un numero", "Error");
                        textBox.Text = "0";
                        break;
                    default:
                        var split = textBox.Text.Split(operacionARealizar);
                        if (digito1 >= 0 && digito2 >= 0)
                        {
                            digito1 = double.Parse(split[0]);
                            digito2 = double.Parse(split[1]);

                        }

                        Calcular iniciarCalcular = new Calcular();
                        switch (operacionARealizar)
                        {
                            case "+":
                                var retornoSum = iniciarCalcular.sumar(digito1, digito2);
                                textBox.Text = retornoSum.ToString();
                                break;
                            case "-":
                                var retornoRes = iniciarCalcular.restar(digito1, digito2);
                                textBox.Text = retornoRes.ToString();
                                break;
                            case "*":
                                var retornoMultip = iniciarCalcular.multiplicar(digito1, digito2);
                                textBox.Text = retornoMultip.ToString();
                                break;
                            case "/":
                                var retornoDiv = iniciarCalcular.dividir(digito1, digito2);
                                textBox.Text = retornoDiv.ToString();
                                break;
                        }
                        break;
                }
                fueCalculado = true;


            }


            catch
            {
                MessageBox.Show("No puedes usar digitos que no sean  numeros", "Error");
                textBox.Text = "0";
            }
        }
    }
}
