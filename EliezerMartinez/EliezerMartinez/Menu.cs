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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Formulario1Button_Click(object sender, EventArgs e)
        {
            Formulario_1 formulario_1 = new Formulario_1();
            formulario_1.Show();
        }

        private void Formulario2Button_Click(object sender, EventArgs e)
        {
            Formulario_2 formulario_2 = new Formulario_2();
            formulario_2.Show();
        }

        private void Formulario3Button_Click(object sender, EventArgs e)
        {
            Formulario_3 formulario_3 = new Formulario_3();
            formulario_3.Show();
        }
    }
}
