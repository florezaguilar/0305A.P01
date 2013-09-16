using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convertidor
{
    public partial class Form1 : Form
    {
        string escala1,escala2;

        conversor.escala a = new conversor.escala();
       

        public Form1()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            escala1 = Convert.ToString(comboBox1.SelectedItem);
            escala2 = Convert.ToString(comboBox2.SelectedItem);

            if (escala1 == "Celsius" && escala2 == "Fahrenheit")
            {
                a.Var2 = Convert.ToDouble(textBox1.Text);
                conversor.escala.C_F(Convert.ToDouble(textBox1.Text));
                textBox2.Text = Convert.ToString(a.Var3);
            }
            else
                if (escala1 == "Celsius" && escala2 == "Kelvin")
                {
                    a.Var2 = Convert.ToDouble(textBox1.Text);
                    conversor.escala.C_K(Convert.ToDouble(textBox1.Text));
                    textBox2.Text = Convert.ToString(a.Var3);
                }
                else
                    if (escala1 == "Fahrenheit" && escala2 == "Celsius")
                    {
                        a.Var2 = Convert.ToDouble(textBox1.Text);
                        conversor.escala.F_C(Convert.ToDouble(textBox1.Text));
                        textBox2.Text = Convert.ToString(a.Var3);
                    }
                    else
                        if (escala1 == "Fahrenheit" && escala2 == "Kelvin")
                        {
                            a.Var2 = Convert.ToDouble(textBox1.Text);
                            conversor.escala.F_K(Convert.ToDouble(textBox1.Text));
                            textBox2.Text = Convert.ToString(a.Var3);
                        }
                        else
                            if (escala1 == "Kelvin" && escala2 == "Fahrenheit")
                            {
                                a.Var2 = Convert.ToDouble(textBox1.Text);
                                conversor.escala.K_F(Convert.ToDouble(textBox1.Text));
                                textBox2.Text = Convert.ToString(a.Var3);
                            }
                            else
                                if (escala1 == "Kelvin" && escala2 == "Celsius")
                                {
                                    a.Var2 = Convert.ToDouble(textBox1.Text);
                                    conversor.escala.K_C(Convert.ToDouble(textBox1.Text));
                                    textBox2.Text = Convert.ToString(a.Var3);
                                }
                                else
                                    textBox2.Text = textBox1.Text;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
        }
    }
}
