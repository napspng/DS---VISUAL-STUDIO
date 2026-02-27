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
            primeiro_digito = int.Parse(textBox1.Text); //o intparse converte apenas string
            segundo_digito = Convert.ToInt32(textBox2.Text); //o convert converte qualquer tipo
            resultado = primeiro_digito + segundo_digito;

            label4.Text = "A soma dos numeros " + primeiro_digito.ToString() + " + " + segundo_digito.ToString() + " = " + resultado.ToString() ; //tostring é para converter para string

            //outras conversoes

            //double V double.parse(Textbox1.text) conversao de string para double
            //ou double v = convert.todouble(textobo1.text) 
            //bool R=  boll.parse(textobox1.text) //conversao de string para booleano
            //ou bool r = convert.toboolean(textbox1.text)
            //char L = char.parse(textobox1.text) conversao de string para char
            //ou char L = convert.tochar(textbox1.text)

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
