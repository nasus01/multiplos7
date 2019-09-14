using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplos_de_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int i = 0;
            int numero = 50;
            while (i < 50)
            {
                if (numero % 7 == 0)
                {
                    contador++;
                    i++;
                    listBox1.Items.Add(numero);
                }
                numero++;
            }
        }
    }
}
