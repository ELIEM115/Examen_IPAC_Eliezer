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
    public partial class Formulario_2 : Form
    {
        public Formulario_2()
        {
            InitializeComponent();
        }

        private async Task<decimal> DescuentoAsync(decimal n1, decimal n2)
        {
            decimal suma = n1 + n2;
            decimal descuento = await Task.Run(() =>
            {
                return (n1 + n2) * 0.15m;
            });
            return suma - descuento;

        }



        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Precio1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Precio2TextBox.Text);

            decimal total = await DescuentoAsync((decimal)num1, (decimal)num2);
            MessageBox.Show($"EL total a pagar  es :{total}");
        }
    }
}
