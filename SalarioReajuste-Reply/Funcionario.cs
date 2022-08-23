using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioReajuste_Reply
{
    class Funcionario : IFuncionario
    {
        public double CalcularImpostoRenda(double salario)
        {
            double imposto, salarioReajustado = 0;

            if(salario <= 1903.98)
            {
                salarioReajustado = salario;
            }
            else if(salario > 1903.99 && salario < 2826.65)
            {
                imposto = salario * 0.075;
                salarioReajustado = salario - imposto;
            }
            else if (salario > 2826.65 && salario < 3751.05)
            {
                imposto = salario * 0.15;
                salarioReajustado = salario - imposto;
            }
            else if (salario > 3751.05 && salario > 4664.68)
            {
                imposto = salario * 0.255;
                salarioReajustado = salario - imposto;
            }
            else
            {
                imposto = salario * 0.275;
                salarioReajustado = salario - imposto;
            }


            return salarioReajustado;

        }

        public double CalucularInss(double salario)
        {
            double inss, salarioreajustado = 0;

            if (salario <= 1100.00)
            {
                inss = salario * 0.075;
                salarioreajustado = salario - inss;

            }
            else if (salario >= 1100.00 && salario <= 2203.48)
            {
                inss = salario * 0.09;
                salarioreajustado = salario - inss;
            }
            else if (salario >= 2203.49 && salario <= 3305.22)
            {
                inss = salario * 0.12;
                salarioreajustado = salario - inss;
            }
            else if (salario >= 3305.23 && salario <= 6433.57)
            {
                inss = (salario * 0.14);
                salarioreajustado = salario - inss;
            }

            return salarioreajustado;
        }
    }
}
