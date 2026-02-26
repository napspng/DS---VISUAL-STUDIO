using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora_simples
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int primeiro_digito, segundo_digito;
            int resultado;
            primeiro_digito = int.Parse(textBox1.Text);
            segundo_digito = int.Parse(textBox2.Text);
            resultado = primeiro_digito + segundo_digito;

            label4.Text = "A soma dos numeros " + primeiro_digito + " + " + segundo_digito + " = " + resultado ;
        }
    }
}
