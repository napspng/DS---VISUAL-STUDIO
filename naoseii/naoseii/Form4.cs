using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace naoseii
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota;
            nota = Convert.ToDouble(textBox1.Text);
            if (nota <= 10 && nota >= 9){
                MessageBox.Show("A");
            }else if (nota <9 && nota >= 7)
            {
                MessageBox.Show("B");
            }else if (nota<7 && nota >= 5){
                MessageBox.Show("C");
            }else if (nota<5 && nota >= 0){
                MessageBox.Show("D");
            }
            else
            {
                MessageBox.Show("Valor invalido");
            }
}

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
