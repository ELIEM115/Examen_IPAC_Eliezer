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
    public partial class Formulario_1 : Form
    {
        public Formulario_1()
        {
            InitializeComponent();
        }
        private void Formilario_1()
        {
            // Agregar los meses al ListBox
            listBoxMeses.Items.Add("Enero");
            listBoxMeses.Items.Add("Febrero");
            listBoxMeses.Items.Add("Marzo");
            listBoxMeses.Items.Add("Abril");
            listBoxMeses.Items.Add("Mayo");
            listBoxMeses.Items.Add("Junio");
            listBoxMeses.Items.Add("Julio");
            listBoxMeses.Items.Add("Agosto");
            listBoxMeses.Items.Add("Septiembre");
            listBoxMeses.Items.Add("Octubre");
            listBoxMeses.Items.Add("Noviembre");
            listBoxMeses.Items.Add("Diciembre");
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad depositada por el usuario
            double capital = 200000;

            // Definir la tasa de interés mensual
            double tasaInteresMensual = 0.015;

            // Calcular el interés ganado cada mes y mostrarlo en el ListBox
            for (int mes = 1; mes <= 12; mes++)
            {
                double interes = capital * tasaInteresMensual * mes;
                string nombreMes = ObtenerNombreMes(mes);
                listBoxMeses.Items.Add($"{nombreMes}: L {interes:N2}");


            }
        }
        private string ObtenerNombreMes(int numeroMes)
        {
            switch (numeroMes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentException("Número de mes inválido");
            }
        }

        private void listBoxMeses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

