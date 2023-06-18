// Everton Fernandes Abrantes - SIS
using System;

class Program
{
    static void Main(string[] args)
    {
        decimal valor;
        int codigo;
        decimal totalavista = 0;
        decimal totalaprazo = 0 ;
        decimal totalgeral = 0 ;

        for(int i = 1;i <= 15; i++)
        {
            Console.WriteLine("Digite o código da {i} transação (1 para a vista, 2 para a prazo):") ; 
            codigo = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da {i} transição:");
            valor = decimal.Parse(Console.ReadLine());

            if (codigo == '1')
            {
                totalavista += valor;
            }
            else if (codigo == '2')
            {
                totalaprazo += valor;
            }
            totalgeral += valor;
        }

        Console.WriteLine("Esse é o valor total das compras a vista: {totalavista:C}");
        Console.WriteLine("Esse é o valor total das compras a prazo: {totalaprazo:C}");
        Console.WriteLine("Esse é o valor total das compras gerais: {totalageral:C}");



    }
}
