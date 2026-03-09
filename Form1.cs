using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taborda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salarioatual, aumento, novosalario;
            int codigocargo;
            string cargo;

            codigocargo = int.Parse(textBox1.Text);
            salarioatual = float.Parse(textBox2.Text);

            if (codigocargo == 1)
            {
                cargo = "Escrituário";
                aumento = (float)(0.50 * salarioatual);
            }
            else if (codigocargo == 2)
            {
                cargo = "Secretário";
                aumento = (float)(0.35 * salarioatual);
            }
            else if (codigocargo == 3)
            {
                cargo = "Caixa";
                aumento = (float)(0.2 * salarioatual);
            }
            else if (codigocargo == 4)
            {
                cargo = "Gerente";
                aumento = (float)(0.1 * salarioatual);
            }
            else if (codigocargo == 5)
            {
                cargo = "Diretor";
                aumento = (float)(0 * salarioatual);
            }
            else
            {
                cargo = " ";
                aumento = 0;
            }

            novosalario = salarioatual + aumento;
            label6.Text = cargo;
            label7.Text = aumento.ToString();
            label8.Text = novosalario.ToString();
        }
    }
}