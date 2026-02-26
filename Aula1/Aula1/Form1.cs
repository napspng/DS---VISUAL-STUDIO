using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace Aula1
{
    public partial class aula1 : Form
    {
        public aula1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declaração de variaveis

            string nome, sobrenome;
            sobrenome = textBox2.Text;
            nome = textBox1.Text; //a variavel nome recebe o conteudo da textbox1
            label4.Text = nome + " " + sobrenome;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aula1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
