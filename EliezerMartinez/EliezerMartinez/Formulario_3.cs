using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EliezerMartinez
{
    public partial class Formulario_3 : Form
    {
        public Formulario_3()
        {
            InitializeComponent();
        }

        private void MostrarNumeros(ListBox listBox1)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    listBox1.Items.Add("Eliezer Martinez");
                }
                else if (i % 3 == 0)
                {
                    listBox1.Items.Add("Eliezer");
                }
                else if (i % 5 == 0)
                {
                    listBox1.Items.Add("Martinez");
                }
                else
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            MostrarNumeros(listBox1 as ListBox);
        }
    }
}