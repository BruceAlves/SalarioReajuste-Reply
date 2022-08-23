using System;

namespace SalarioReajuste_Reply
{
    class Program
    {
        static void Main(string[] args)
        {

            double salario = 0;

            Console.WriteLine("Informe seu salário");
            salario = Convert.ToDouble(Console.ReadLine());

            IFuncionario funcionario = new Funcionario();

            double salarioReajustado  = funcionario.CalcularDescontosSalarios(salario);

            Console.WriteLine($"Seu salario  é {salarioReajustado.ToString("C")}");


          


            Console.ReadKey();
        }
    }
}
