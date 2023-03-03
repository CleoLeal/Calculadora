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
    public partial class form_convertendo_moedas : Form
    {
        public form_convertendo_moedas()
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
            radioReal.Checked = false;
            radioDolar.Checked = false;
            radioEuro.Checked = false;
            radioConverterReal.Checked = false;
            radioConverterDolar.Checked = false;
            radioConverterEuro.Checked = false;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //variavel que salva a conversao
            decimal conversao = 0;
            //se a label estiver vazia

            //variável do número e guardando nele
            n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);

            if (lblResultado.Text == "")
            {
                //ele não faz nenuma conversão e avisa
                MessageBox.Show("Precisamos do valor primeiro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //senao
            else
            {
                if (radioReal.Checked && radioConverterDolar.Checked)
                {
                    //a conversao é o valor em real * o valor de 1 real por dólar 
                    conversao = n1 * 0.19M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioReal.Checked && radioConverterEuro.Checked)
                {
                    //a conversao é o valor em real * o valor de 1 real por euro 
                    conversao = n1 * 0.18M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioDolar.Checked && radioConverterReal.Checked)
                {
                    //a conversao é o valor em dolar * o valor de 1 dolar por real 
                    conversao = n1 * 5.19M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioDolar.Checked && radioConverterEuro.Checked)
                {
                    //a conversao é o valor em dolar * o valor de 1 dolar por euro 
                    conversao = n1 * 0.94M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioEuro.Checked && radioConverterReal.Checked)
                {
                    //a conversao é o valor em euro * o valor de 1 euro por real 
                    conversao = n1 * 5.53M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if (radioEuro.Checked && radioConverterDolar.Checked)
                {
                    //a conversao é o valor em euro * o valor de 1 euro por dolar 
                    conversao = n1 * 1.07M;
                    //mostra na label
                    lblResultado.Text = Convert.ToString(conversao);
                }
                else if ((radioReal.Checked && radioConverterReal.Checked) || (radioDolar.Checked && radioConverterDolar.Checked) || (radioEuro.Checked && radioConverterEuro.Checked))
                {
                    //se a pessoa check os mesmos radio buttons ele informa que é impossível fazer essa conversão
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
