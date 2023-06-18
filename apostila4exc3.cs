
using System;

class Program
{
    static void Main(string[] args)
    {
        int numpessoas = 200;
        double salario = 0;
        int numerofilhos = 0;
        double somasalario = 0;
        int somafilho = 0;
        double salariomenor = 0;
        dpuble salariomaior = 0;
        int contador1500 = 0;

        for (int i = 1; i <= numpessoas; i++)
        {
            Console.WriteLine("Digite o salário da {i} pessoa:");
            salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero de {i} filhos")
            numerofilhos = int.Parse(Console.ReadLine());

            if (salario > salariomaior)
            {
                salariomaior = salario;

            }

            if (salario < salariomenor)
            {
                salariomenor = salario;
            }

            if (salario <= 1500)
            {
                contador1500++;
            }
        }

        double mediasalario = somasalario / numpessoas;
        double mediafilho = (double)somafilho / numpessoas;
        double percentual1500 = (double)contador1500 / numpessoas * 100;

        Console.WriteLine("A média do salário das pessoas é: {mediasalario:C}");
        Console.WriteLine("A média do número de filhos é: {mediafilho:F}");
        Console.WriteLine("O maior salário das pessoas é: {salariomaior:C}");
        Console.WriteLine("O menor salário das pessoas é: {salariomenor:C}");
        Console.WriteLine("A porcentagem de pessoas com salários de até 1500,00 é: {percentual1500:F}%*");
        Console.ReadLine();
    }
}