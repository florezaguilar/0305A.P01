using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        bool operacion=false;
        int temp;
        string signo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.StartsWith("0"))
            {
                if (textBox1.Text.Contains("."))
                {
                    textBox1.Text += "0";
                }
                else { }
            }
            else
                textBox1.Text = textBox1.Text + "0";
                operacion = false;

        }

        private void buttonpunto_Click(object sender, EventArgs e)

        {

            if (textBox1.Text.StartsWith("."))
                textBox1.Text=("0.");
            
                if (textBox1.Text.Contains("."))
                {
                    
                }
                else if  (textBox1.Text.StartsWith(""))
                {
                    textBox1.Text+=".";
                }

            
            else
                textBox1.Text += ".";

        }

        private void Cmd7_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-7";
            }
            else
                textBox1.Text += "7";
            
        }

        private void Cmd1_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-1";
            }
            else
                textBox1.Text += "1";
        }

        private void Cmd2_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-2";
            }
            else
                textBox1.Text += "2";
        }

        private void Cmd3_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-3";
            }
            else
                textBox1.Text += "3";
        }

        private void Cmd4_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-4";
            }
            else
                textBox1.Text += "4";
        }

        private void Cmd5_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-5";
            }
            else
                textBox1.Text += "5";
        }

        private void Cmd6_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-6";
            }
            else
                textBox1.Text += "6";
        }

        private void Cmd8_Click(object sender, EventArgs e)
        {
           
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-8";
            }
            else
                textBox1.Text += "8";
        }

        private void Cmd9_Click(object sender, EventArgs e)
        {
            if (operacion == true)
            {
                textBox1.Text = "";
            }
            if (signo == "menos")
            {
                textBox1.Text += "-9";
            }
            else
                textBox1.Text += "9";
        }

        private void CmdMenos_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos");
            }
            else
            {
                temp = Convert.ToInt16(textBox1.Text);
                signo = "resta";
                textBox1.Text = "";

            }

        }

        private void CmdC_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            signo = "";
            
        }

        private void CmdMas_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos");
            }
            else
            {
                temp = Convert.ToInt16(textBox1.Text);
                signo = "suma";
                textBox1.Text="";
                
            }
        }

        private void CmdIgual_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos en los campos");
            }
            else
                switch (signo)
                {
                    case "suma":
                        textBox1.Text = Convert.ToString (temp + Convert.ToInt64(textBox1.Text));
                        signo = "";
                        break;

                    case "resta":
                       textBox1.Text = Convert.ToString (temp - Convert.ToInt64(textBox1.Text));
                        signo = "";
                        break;

                    case "multiplicacion":
                        textBox1.Text = Convert.ToString (temp * Convert.ToInt64(textBox1.Text));
                        signo = "";
                        break;
                        

                    case "division":
                        textBox1.Text = Convert.ToString (temp / Convert.ToInt64(textBox1.Text));
                        signo = "";
                        break;
                       

                    case "porcentaje":
                        textBox1.Text = Convert.ToString (temp + Convert.ToInt64(textBox1.Text));
                        signo = "";
                        break;
                        
                }
            
        }

        private void Cmdpor_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos");
            }
            else
            {
                temp = Convert.ToInt16(textBox1.Text);
                signo = "multiplicacion";
                textBox1.Text = "";

            }
        }

        private void Cmdentre_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos");
            }
            else
            {
                temp = Convert.ToInt16(textBox1.Text);
                signo = "division";
                textBox1.Text = "";

            }
        }

        private void CmdPorcentaje_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("No existen datos");
            }
            else
            {
                temp = Convert.ToInt16(textBox1.Text);
                signo = "porcentaje";
                textBox1.Text = "";

            }
        }

    }
}
