using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculando
{
    
    public partial class Form_calculando : Form
    {
        
        public Form_calculando()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(boxOpcoes.Text =="")
            {
                MessageBox.Show("Primeiro informe qual calculadora você quer utilizar","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //o form da calculadora
                form_calculadora calculadora = new form_calculadora();
                //o form do convertendo moedas
                form_convertendo_moedas moedas = new form_convertendo_moedas();
                //o form do convertendo temperatura
                form_convertendo_temperatura temperatura = new form_convertendo_temperatura();
                //se a pessoa escolher a calculadora
                if (boxOpcoes.Text == "Calculadora")
                {
                    //esse form fecha
                    this.Hide();
                    //abre o form da calculadora
                    calculadora.ShowDialog();
                }
                //se a pessoa escolher o convertendo moeda
                if (boxOpcoes.Text == "Convertendo Moeda")
                {
                    //esse form fecha
                    this.Hide();
                    //abre o form do convertendo moeda
                    moedas.ShowDialog();
                }
                //se a pessoa escolher o convertendo temperatura
                if (boxOpcoes.Text == "Convertendo Temperatura")
                {
                    //esse form fecha
                    this.Hide();
                    //abre o form do convertendo temperatura
                    temperatura.ShowDialog();
                }
            }
        }
    }
}
