using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace calculadora
{
    public partial class FrmCalculadora : Form
    {
        string signo;
        int a,borrar;
        bool estado = false;
        operaciones num = new operaciones();
        
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void CmdIgual_Click(object sender, EventArgs e)
        {
            estado = true;
            
            switch (signo)
            {
                case "suma":
                    
                    num.Var1=(Convert.ToDouble(textBox1.Text));
                    operaciones.suma(num.Var1, num.Var2);
                    textBox1.Text = Convert.ToString(num.Rpta);
                    signo = "";
                    break;

                case "resta":
                    num.Var1=(Convert.ToDouble(textBox1.Text));
                    operaciones.resta(num.Var1, num.Var2);
                    textBox1.Text = Convert.ToString(num.Rpta);
                    signo = "";
                    break;

                case "multiplicacion":
                    num.Var1=(Convert.ToDouble(textBox1.Text));
                    operaciones.multiplicacion(num.Var1, num.Var2);
                    textBox1.Text = Convert.ToString(num.Rpta);
                    signo = "";
                    break;

                case "division":
                    num.Var1=(Convert.ToDouble(textBox1.Text));
                    operaciones.division(num.Var1, num.Var2);
                    textBox1.Text = Convert.ToString(num.Rpta);
                    signo = "";
                    break;

                case "porcentaje":
                    num.Var1=(Convert.ToDouble(textBox1.Text));
                    operaciones.suma(num.Var1, num.Var2);
                    textBox1.Text = Convert.ToString(num.Rpta);
                    signo = "";
                    break;
                    
            }
        }

        private void CmdMas_Click(object sender, EventArgs e)
        {
            
            num.Var2 = Convert.ToDouble(textBox1.Text);
            signo = "suma";
            estado=true;
        }

        private void CmdMenos_Click(object sender, EventArgs e)
        {
            
            num.Var2 = Convert.ToDouble(textBox1.Text);
            signo = "resta";
            estado = true;
        }

        private void Cmdpor_Click(object sender, EventArgs e)
        {
            
            num.Var2 = Convert.ToDouble(textBox1.Text);
            signo = "multiplicacion";
            estado = true;
        }

        private void Cmdentre_Click(object sender, EventArgs e)
        {
            
            num.Var2 = Convert.ToDouble(textBox1.Text);
            signo = "division";
            estado = true;
        }

        private void CmdC_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }

        private void Cmd0_Click(object sender, EventArgs e)
        {
            a = textBox1.TextLength;
            if (textBox1.Text.StartsWith("0") && a==1)
            {
                
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "0";
                    estado = false;
                }
                else
                    textBox1.Text += "0";
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }

            if (signo == "menos")
            {
                textBox1.Text += "-1";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "1";
                    estado = false;
                }
                else
                    textBox1.Text += "1";
            
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }

            if (signo == "menos")
            {
                textBox1.Text += "-2";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "2";
                    estado = false;
                }
                else
                    textBox1.Text += "2";
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }

            if (signo == "menos")
            {
                textBox1.Text += "-3";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "3";
                    estado = false;
                }
                else
                    textBox1.Text += "3";
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-4";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "4";
                    estado = false;
                }
                else
                    textBox1.Text += "4";
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-5";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "5";
                    estado = false;
                }
                else
                    textBox1.Text += "5";
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-6";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "6";
                    estado = false;
                }
                else
                    textBox1.Text += "6";
        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-7";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "7";
                    estado = false;
                }
                else
                    textBox1.Text += "7";
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-8";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "8";
                    estado = false;
                }
                else
                    textBox1.Text += "8";
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0") { textBox1.Text = ""; }
            if (signo == "menos")
            {
                textBox1.Text += "-9";
            }
            else
                if (estado == true)
                {
                    textBox1.Text = "9";
                    estado = false;
                }
                else
                    textBox1.Text += "9";
        }

        private void Cmdpunto_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            if (estado != true)
            {
                borrar = textBox1.TextLength;
                if (borrar == 1)
                {
                    textBox1.Text = "0";
                }
                else
                    textBox1.Text = textBox1.Text.Remove(borrar - 1, 1);
            }
        }
    }
}
