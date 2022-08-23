using System;
using System.Collections.Generic;
using System.Text;

namespace SalarioReajuste_Reply
{
    interface IFuncionario
    {
        double CalcularImpostoRenda(double salario);
        double CalucularInss(double salario);
    }
}
