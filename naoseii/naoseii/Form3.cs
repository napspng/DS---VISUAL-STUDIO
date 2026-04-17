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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dinheiro;
            dinheiro = Double.Parse(textBox1.Text);
            if (dinheiro > 100.00)
            {
                MessageBox.Show("Voce tem muito dinheiro! " + dinheiro,"atencao",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("voce precisa de mais dinheiro;.;;" + dinheiro, "atencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
