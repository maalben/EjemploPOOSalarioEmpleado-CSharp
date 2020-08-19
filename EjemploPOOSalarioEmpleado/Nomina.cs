using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploPOOSalarioEmpleado
{
    public class Nomina
    {

        //Atributos
        private double horasTrabajadas;
        private double valorHora;

        public double getHorasTrabajadas() {
            return this.horasTrabajadas;
        }

        public double getValorHora() {
            return this.valorHora;
        }

        public void setHorasTrabajadas(double valor) {
            this.horasTrabajadas = valor;
        }

        public void setValorHora(double valor) {
            this.valorHora = valor;
        }

        public double calcularSalud() { //Método de acción
            double pagoSalud;
            double descuentoSalud;
            pagoSalud = this.getValorHora() * this.getHorasTrabajadas();
            descuentoSalud = pagoSalud * 0.04;
            return descuentoSalud;
        }

        public double calcularSalarioFinal() {
            double salarioBase;
            double salarioFinal;
            salarioBase = this.getHorasTrabajadas() * this.getValorHora();
            salarioFinal = salarioBase - this.calcularSalud();
            return salarioFinal;
        }

    }
}
