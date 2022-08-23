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


            IFuncionario salarioReajustado = new Funcionario();

            double resultadoInss = salarioReajustado.CalucularInss(salario);
            Console.WriteLine($"Seu salario com desconto do INSS é {resultadoInss.ToString("C")}");


            double resultadoImpostoRende = salarioReajustado.CalcularImpostoRenda(salario);
            Console.WriteLine($"Seu salario com desconto do imposto de renda é {resultadoImpostoRende.ToString("C")}");


            Console.ReadKey();
        }
    }
}
