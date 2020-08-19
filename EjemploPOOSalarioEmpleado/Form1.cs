using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploPOOSalarioEmpleado
{
    public partial class Form1 : Form
    {          //objeto de la clase   
        Nomina nomina = new Nomina();

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double horasTrabajadas;
            double valorHora;

            horasTrabajadas = Convert.ToDouble(txthorastrabajadas.Text);
            valorHora = Convert.ToDouble(txtvalorhora.Text);

            nomina.setHorasTrabajadas(horasTrabajadas);
            nomina.setValorHora(valorHora);

            lblpagosalud.Visible = true;
            lbltotal.Visible = true;

            lblpagosalud.Text = Convert.ToString(nomina.calcularSalud());
            lbltotal.Text = Convert.ToString(nomina.calcularSalarioFinal());

        }
    }
}
