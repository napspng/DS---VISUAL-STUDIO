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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro; //declarar variavel
            dinheiro = Double.Parse(textBox1.Text);
            if (dinheiro > 100.0)
            {
                //MessageBox.Show("voce tem muito dinheiro")
                MessageBox.Show("Voce tem muito dinheiro " + dinheiro, "atenção", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tem certeza que deseja sair? ", "ATENÇÃO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                //nao faz nada
            }
            
        }
    }
}
