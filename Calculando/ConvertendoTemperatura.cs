using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculando
{
    public partial class form_convertendo_temperatura : Form
    {
        public form_convertendo_temperatura()
        {
            InitializeComponent();
        }

        decimal n1 = 0;

        private void btnOne_Click(object sender, EventArgs e)
        {
            //valor do botão 1
            lblResultado.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            //valor do botão 2
            lblResultado.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            //valor do botão 3
            lblResultado.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            //valor do botão 4
            lblResultado.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            //valor do botão 5
            lblResultado.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            //valor do botão 6
            lblResultado.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            //valor do botão 7
            lblResultado.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            //valor do botão 8
            lblResultado.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            //valor do botão 9
            lblResultado.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            //valor do botão 0
            lblResultado.Text += "0";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //valor do botão .
            lblResultado.Text += ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //quando o botão C for clicado tudo isso tem que ser limpo:
            //a label resultado
            lblResultado.Text = "";
            //as variáveis dos números
            n1 = 0;
            //os radio buttons não ficam mais checkados
            radioCelsius.Checked = false;
            radioFahrenheit.Checked = false;
            radioKelvin.Checked = false;
            radioConverterCelsius.Checked = false;
            radioConverterFahrenheit.Checked = false;
            radioConverterKelvin.Checked = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            decimal conversao = 0;
            //variável do número e guardando nele
            n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);

            if (lblResultado.Text == "")
            {
                //ele não faz nenuma conversão e avisa
                MessageBox.Show("Precisamos do valor primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (radioCelsius.Checked && radioConverterFahrenheit.Checked)
                {
                    //conversao de celsius para fahrenheit
                    conversao = n1 * 1.8M + 32;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioCelsius.Checked && radioConverterKelvin.Checked)
                {
                    //conversao de celsius para kelvin
                    conversao = n1 + 273.15M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioFahrenheit.Checked && radioConverterCelsius.Checked)
                {
                    //conversao de fahrenheit para celsius
                    conversao = (n1 - 32) / 1.8M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioFahrenheit.Checked && radioConverterKelvin.Checked)
                {
                    //conversao de fahrenheit para kelvin
                    conversao = (n1 + 459.67M) / 1.8M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioKelvin.Checked && radioConverterCelsius.Checked)
                {
                    //conversao de kelvin para celsius
                    conversao = n1 - 273.15M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioKelvin.Checked && radioConverterFahrenheit.Checked)
                {
                    //conversao de kelvin para Fahrenheit
                    conversao = n1 * 1.8M - 459.67M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if ((radioCelsius.Checked && radioConverterCelsius.Checked) || (radioFahrenheit.Checked && radioConverterFahrenheit.Checked) || (radioKelvin.Checked && radioConverterKelvin.Checked))
                {
                    //se forem os memos radio buttons, ele avisa o erro
                    MessageBox.Show("Impossível fazer essa conversão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form_calculando calculando = new Form_calculando();
            //esse form fecha
            this.Hide();
            //abre o form principal
            calculando.Show();
        }
    }
}
