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

namespace Calculadora
{
    public partial class form_calculadora : Form
    {
        public form_calculadora()
        {
            InitializeComponent();
        }

        //variável numero um
        decimal n1 = 0;
        //variável numero dois
        decimal n2 = 0;
        //variável operador
        string operador = "";
        
        private void btnZero_Click(object sender, EventArgs e)
        {
            //o valor do botão 0
            lblResultado.Text += "0";
        }

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

        private void btnPlus_Click(object sender, EventArgs e)
        {
            //se a label que mostra o resultado estiver vazia
            if(lblResultado.Text =="")
            {
                //ele abre uma caixinha e informa que existe um erro
                MessageBox.Show("Informe um número antes de informar o operador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do primeiro número e guardando nele
                n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //informando qual operador está sendo utilizado
                lblOperador.Text = n1 + "+";
                //depois que a pessoa clicar no botão, a label do resultado ficará vazia para receber o segundo valor
                lblResultado.Text = "";
                //salvando em uma variável o operador utilizado
                operador = "soma";
            }
            
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            //se a label que mostra o resultado estiver vazia
            if (lblResultado.Text == "")
            {
                //ele abre uma caixinha e informa que existe um erro
                MessageBox.Show("Informe um número antes de informar o operador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do primeiro número e guardando nele
                n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //informando qual operador está sendo utilizado
                lblOperador.Text = n1 + "-";
                //depois que a pessoa clicar no botão, a label do resultado ficará vazia para receber o segundo valor
                lblResultado.Text = "";
                //salvando em uma variável o operador utilizado
                operador = "sub";
            }   
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            //se a label que mostra o resultado estiver vazia
            if (lblResultado.Text == "")
            {
                //ele abre uma caixinha e informa que existe um erro
                MessageBox.Show("Informe um número antes de informar o operador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do primeiro número e guardando nele
                n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //informando qual operador está sendo utilizado
                lblOperador.Text = n1 + "/";
                //depois que a pessoa clicar no botão, a label do resultado ficará vazia para receber o segundo valor
                lblResultado.Text = "";
                //salvando em uma variável o operador utilizado
                operador = "div";
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            //se a label que mostra o resultado estiver vazia
            if (lblResultado.Text == "")
            {
                //ele abre uma caixinha e informa que existe um erro
                MessageBox.Show("Informe um número antes de informar o operador", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do primeiro número e guardando nele
                n1 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //informando qual operador está sendo utilizado
                lblOperador.Text = n1 + "X";
                //depois que a pessoa clicar no botão, a label do resultado ficará vazia para receber o segundo valor
                lblResultado.Text = "";
                //salvando em uma variável o operador utilizado
                operador = "mult";
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //quando o botão C for clicado tudo isso tem que ser limpo:
            //a label resultado
            lblResultado.Text = "";
            //as variáveis dos números
            n1 = 0;
            n2 = 0;
            //e a label do operador
            lblOperador.Text = "";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            //o ponto para informar número decimal
            lblResultado.Text += ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //se o bõtão do operador soma for clicado
            if(operador == "soma")
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do segundo número e guardando nele
                n2 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //na label do resultado, tera a soma do n1 e n2
                lblResultado.Text = Convert.ToString(n1 + n2);
                //apagando o que tem nessa label
                lblOperador.Text = "";
            }
            //se o bõtão do operador subtração for clicado
            else if (operador == "sub")
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do segundo número e guardando nele
                n2 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //na label do resultado, tera a subtração do n1 e n2
                lblResultado.Text = Convert.ToString(n1 - n2);
                //apagando o que tem nessa label
                lblOperador.Text = "";
            }
            else if(operador == "mult")
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do segundo número e guardando nele
                n2 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //na label do resultado, tera a multiplicação do n1 e n2
                lblResultado.Text = Convert.ToString(n1 * n2);
                //apagando o que tem nessa label
                lblOperador.Text = "";
            }
            else
            {
                // CultureInfo.InvariantCulture = serve para converter o texto no formato correto
                //variável do segundo número e guardando nele
                n2 = decimal.Parse(lblResultado.Text, CultureInfo.InvariantCulture);
                //se o n2 for maior que zero
                if (n2 > 0)
                {
                    //então vai ter o resultado:
                    //na label do resultado, tera a divisão do n1 e n2
                    lblResultado.Text = Convert.ToString(n1 / n2);
                    //apagando o que tem nessa label
                    lblOperador.Text = "";
                }
                //se o n2 for menor que zero
                else
                {
                    //ele abre uma caixinha e informa que existe um erro
                    MessageBox.Show("É impossível dividir por 0", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            
        }

    }
}
