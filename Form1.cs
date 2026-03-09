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
                aumento = 0.50f * salarioatual;
            }
            else if (codigocargo == 2)
            {
                cargo = "Secretário";
                aumento = 0.35f * salarioatual;
            }
            else if (codigocargo == 3)
            {
                cargo = "Caixa";
                aumento = 0.2f * salarioatual;
            }
            else if (codigocargo == 4)
            {
                cargo = "Gerente";
                aumento = 0.1f * salarioatual;
            }
            else if (codigocargo == 5)
            {
                cargo = "Diretor";
                aumento = 0f * salarioatual;
            }
            else
            {
                cargo = " ";
                aumento = 0f;
            }

            novosalario = salarioatual + aumento;
            label6.Text = cargo;
            label7.Text = aumento.ToString("F2");
            label8.Text = novosalario.ToString("F2");
        }
    }
}