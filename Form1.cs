using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClase4_6_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region variables estáticas y métodos del dominio del problema
        static int cont;
        static double acum;
        static double CalcularPromedio()
        {
            double promedio = 0;
            if (cont > 0)
            {
                promedio = acum / cont;
            }
            return promedio;
        }
        static void RegistrarNota(double nota)
        {
            acum+= nota;
            cont++;
        }
        #endregion

        private void btnIngresarNota_Click(object sender, EventArgs e)
        {
            double nota = Convert.ToDouble(tbNota.Text);
            RegistrarNota(nota);
            tbNota.Clear();
        }
        private void ConsultaPromedio_Click(object sender, EventArgs e)
        {
            double promedio=CalcularPromedio();
            lbPromedio.Text = promedio.ToString("0.00");
        }
    
    }

}
