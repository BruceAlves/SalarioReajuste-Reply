using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioReajuste_Reply
{
    class Funcionario : IFuncionario
    {
        public double CalcularDescontosSalarios(double salario)
        {
            double descontoIRRF = CalcularImpostoRenda(salario);
            double descontoINSS = CalucularInss(salario);

            double salarioReajustado = salario - descontoINSS - descontoIRRF;

            return salarioReajustado;
        }

        private  double CalcularImpostoRenda(double salario)
        {
            double descontoIRRF;

            if(salario <= 1903.98)
            {
                descontoIRRF = 0;
            }
            else if(salario > 1903.99 && salario < 2826.65)
            {
                descontoIRRF = salario * 0.075;
            }
            else if (salario > 2826.65 && salario < 3751.05)
            {
                descontoIRRF = salario * 0.15;
            }
            else if (salario > 3751.05 && salario > 4664.68)
            {
                descontoIRRF = salario * 0.255;
            }
            else
            {
                descontoIRRF = salario * 0.275;               
            }

            return descontoIRRF;
        }

        private double CalucularInss(double salario)
        {
            double inss = 0;

            if (salario <= 1100.00)
            {
                inss = salario * 0.075;
            }
            else if (salario >= 1100.00 && salario <= 2203.48)
            {
                inss = salario * 0.09;
            }
            else if (salario >= 2203.49 && salario <= 3305.22)
            {
                inss = salario * 0.12;
            }
            else if (salario >= 3305.23 && salario <= 6433.57)
            {
                inss = salario * 0.14;
            }

            return inss;
        }
    }
}
