using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class Form1 : Form
    {
        public double Num1, Num2, Resultado;
        public bool Is1, Is2, Es_op;
        int operación;
        int angulo = 0;
        bool s = true;

        private void btn0_Click(object sender, EventArgs e)
        {
            UpdateDisplay("0");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            UpdateDisplay("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            UpdateDisplay("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            UpdateDisplay("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            UpdateDisplay("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            UpdateDisplay("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            UpdateDisplay("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            UpdateDisplay("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            UpdateDisplay("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            UpdateDisplay("9");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            CleanDisplay();
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_valor(); /*Actualizamos el valor  de la variable de control*/
                Is1 = true;                /*"0" indicará la operación matemática "suma"*/
                operación = 0;
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_valor(); /*Actualizamos el valor  de la variable de control*/
                Is1 = true;                /*"1" indicará la operación matemática "resta"*/
                operación = 1;
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_valor(); /*Actualizamos el valor  de la variable de control*/
                Is1 = true;                /*"2" indicará la operación matemática "multiplicacion"*/
                operación = 2;
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Is1)
                {
                    Num1 = Obtener_valor(); /*Actualizamos el valor  de la variable de control*/
                    Is1 = true;                /*"3" indicará la operación matemática "división"*/
                    operación = 3;
                }
            }
            catch (Exception a)
            {

                Console.WriteLine("\nSucedió la excepción");

                Console.WriteLine("Fuente/Programa: {0}", a.Source);
                Console.WriteLine("Clase donde ocurrió: {0}", a.TargetSite.DeclaringType);
                Console.WriteLine("Tipo de miembro: {0}", a.TargetSite.MemberType);
                Console.WriteLine("En el método: {0}", a.TargetSite);
                Console.WriteLine("Con el mensaje de error: {0}", a.Message);

                Console.WriteLine("\n Stack: {0}", a.StackTrace);
                Console.WriteLine("\n Help link {0}", a.HelpLink);

            }
        }
        private void btnangulo_Click(object sender, EventArgs e)
        {
            if (angulo == 0)
            {
                angulo = 1; //si no esta activado radianes, los activa
                btnangulo.Text = "Rad";
            }
            else
            {
                angulo = 0; // si está activado rad lo desactiva
                btnangulo.Text = "Deg";
            }
        }
        private void btnexponente_Click(object sender, EventArgs e)
        {
            if (!Is1)
            {
                Num1 = Obtener_valor(); /*Actualizamos el valor  de la variable de control*/
                Is1 = true;                /*"0" indicará la operación matemática "suma"*/
                operación = 4;
            }
        }
        private void btnSin_Click(object sender, EventArgs e)
        {
            try
            {
                Is1 = true;
                if (Is1) // Sí se ha presionado el botón de seno
                {
                    UpdateDisplay(Operar2("Seno").ToString());

                }
            }
            catch
            {
                    MessageBox.Show("Seleccione una operación para realizarla");
            }
        }
        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                Is1 = true;
                if (Is1) // Sí se ha presionado el botón de coseno
                {
                    UpdateDisplay(Operar2("Coseno").ToString());

                }
            }
            catch
            {
                    MessageBox.Show("Seleccione una operación para realizarla");
            } 
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            try
            {
                Is1 = true;
                if (Is1) // Sí se ha presionado el botón de tangente
                {
                    UpdateDisplay(Operar2("Tangente").ToString());
                }
            }
            catch
            {
                {
                    MessageBox.Show("Seleccione una operación para realizarla");
                }
            }

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                Is1 = true;
                if (Is1) // Sí se ha presionado el botón de logarítmo base 10
                {
                    UpdateDisplay(Operar2("Logaritmo10").ToString());
                }
            }
           
            catch
            {
                MessageBox.Show("Seleccione una operación para realizarla");
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            try
            {
                Is1 = true;
                if (Is1) // Sí se ha presionado el botón de logarítmo natural
                {
                    UpdateDisplay(Operar2("LogaritmoLn").ToString());

                }
            }
            
          catch
            {
                MessageBox.Show("Seleccione una operación para realizarla");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            int Contador = 0;
            string Borrado = txtPantalla.Text;
            Contador = Borrado.Length - 1;
            Borrado = Borrado.Substring(0, Contador);
            txtPantalla.Text = Borrado;

            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";
                s = true;
            }
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
            {
                txtPantalla.Text += ".";
            }
        }


        private void btnigual_Click(object sender, EventArgs e)
        {
            //Suma
            try
            {
                if (operación == 0) // Sí se ha presionado el botón de sumar
                {
                    if (Is1)
                    {
                        Num2 = Obtener_valor(); //Para obtener el segundo operando de la operación suma
                        UpdateDisplay(Operar(Num1, Num2, "+").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizarla");
                    }                 
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere de dos operandos");
            }
            // Resta
            try
            {
                if (operación == 1) // Sí se ha presionado el botón de restar
                {
                    if (Is1)
                    {
                        Num2 = Obtener_valor(); //Para obtener el segundo operando de la operación suma
                        UpdateDisplay(Operar(Num1, Num2, "-").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizarla");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere de dos operandos");
            }
            //Multiplicación
            try
            {
                if (operación == 2) // Sí se ha presionado el botón de multiplicar
                {
                    if (Is1)
                    {
                        Num2 = Obtener_valor(); //Para obtener el segundo operando de la operación suma
                        UpdateDisplay(Operar(Num1, Num2, "*").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizarla");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Esta operación requiere de dos operandos");
            }
            //División
            try
            {
                if (operación == 3) // Sí se ha presionado el botón de dividir
                {

                    if (Is1)
                    {

                        Num2 = Obtener_valor();

                        //Para obtener el segundo operando de la operación suma
                        UpdateDisplay(Operar(Num1, Num2, "/").ToString());
                        Is1 = false;
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una operación para realizarla");
                    }
                }
            }
            catch (DivideByZeroException)
            {
                if (Num2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre 0");

                }
            }

            catch 
            {
                MessageBox.Show("Esta operación requiere de dos operandos");

            }

            //Elevar
            if (operación == 4) // Sí se ha presionado el botón de potencia
            {
                if(Is1)
                {
                    Num2 = Obtener_valor();
                    UpdateDisplay(Operar(Num1, Num2, "Potencia").ToString());
                    Is1 = false;
                }
            }
        }


        //        Num1 y Num2 las utilizaremos para capturar los operandos a utilizar.
        //Resultado manejará lógicamente el resultado de cada operación realizada por la calculadora.
        //Operacion indicará cuál es la operación matemática seleccionada por el usuario.
        //Is1, Is2, Es_op nos ayudarán a controlar la operatividad de nuestra calculadora.
        public Form1()
        {
            InitializeComponent();
            Is1 = Is2 = false;
        }
        public void CleanDisplay()
        {
            txtPantalla.Text= "";
        }

        public double Obtener_valor() /*Para transformar lo que se digite en el textbox a formato numérico*/
        {
            double valor = Convert.ToDouble(txtPantalla.Text);
            CleanDisplay();
            return valor;
        }
        public void UpdateDisplay(string texto) /*Para actualizar lo que se visualize en el textbox*/
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "";
            txtPantalla.Text = txtPantalla.Text + texto;
        }
        public double Operar(double operador1, double operador2, string signo)
        {
               double Resultado = 0.0;
                switch (signo)
                {
                    case "+":
                        Resultado = operador1 + operador2;
                        break;
                    case "-":
                        Resultado = operador1 - operador2;
                        break;
                    case "*":
                        Resultado = operador1 * operador2;
                        break;

                     case "/":
                        Resultado = operador1 / operador2;
                        break;
                case "Potencia":
                    Resultado = Potencia(Num1, Num2);
                        break;
                    default:
                        break;
                }
            return Resultado;
        }
        public double Operar2(string operacion)
        {
            double Resultado = 0.0;
            switch (operacion)
            {
                case "Seno":
                    Resultado = Convert.ToDouble(CalcularSeno());
                    break;
                case "Coseno":
                Resultado = Convert.ToDouble(CalcularCoseno());
                    break;
                case "Tangente":
                    Resultado = Convert.ToDouble(CalcularTangente());
                    break;
                case "Logaritmo10":
                    Resultado = Convert.ToDouble(CalcularLog10());
                    break;
                case "LogaritmoLn":
                    Resultado = Convert.ToDouble(CalcularLn());
                    break;
                    default:
                    break;
            }
            return Resultado;
        }
        //Potencia (X ^ Y)
        static double Potencia(double n1, double n2)
        {
            double r = 0.0;
            r = Math.Pow(n1, n2);
            return r;
        }
        static double RadianesaGrados(double n1, double n2) //Función que permite convertir de radianes a grados
        {
            double r = 0;
            r = n1 * (n2 / 180);
            return r;
        }
        //Funciones trigonométricas basicas
        public string CalcularSeno()
        {
            string ResultadoSeno = "";
            double a = Obtener_valor();

            if (angulo == 0) //Si está en 0, en default, lo hace en grados
            {
                ResultadoSeno = txtPantalla.Text = Convert.ToString(Math.Sin(RadianesaGrados(a, Math.PI)));
            }
            else //sino si hace el calculo en radianes
            {
                ResultadoSeno = txtPantalla.Text = Convert.ToString(Math.Sin(a));
            }
            return ResultadoSeno;
        }
        public string CalcularCoseno()
        {
            string ResultadoCoseno = "";
            double a = Obtener_valor();

            if (angulo == 0) //Si está en 0, en default, lo hace en grados
            {
                ResultadoCoseno = txtPantalla.Text = Convert.ToString(Math.Cos(RadianesaGrados(a, Math.PI)));
            }
            else //sino si hace el calculo en radianes
            {
                ResultadoCoseno = txtPantalla.Text = Convert.ToString(Math.Cos(a));
            }
            return ResultadoCoseno;
        }
        public string CalcularTangente()
        {
            string ResultadoTangente = "";
            double a = Obtener_valor();

            if (angulo == 0) //Si está en 0, en default, lo hace en grados
            {
                ResultadoTangente = txtPantalla.Text = Convert.ToString(Math.Tan(RadianesaGrados(a, Math.PI)));
            }
            else //sino si hace el calculo en radianes
            {
                ResultadoTangente = txtPantalla.Text = Convert.ToString(Math.Cos(a));
            }
            return ResultadoTangente;
        }
        public string CalcularLog10()
        {
            string ResultadoLog10 = "";
            double a = Obtener_valor();
            ResultadoLog10 = txtPantalla.Text = Convert.ToString(Math.Log10(a));
            return ResultadoLog10;
        }
        public string CalcularLn()
        {
            string ResultadoLn = "";
            double a = Obtener_valor();
            ResultadoLn = txtPantalla.Text = Convert.ToString(Math.Log(a));
            return ResultadoLn;
        }
    }
}
