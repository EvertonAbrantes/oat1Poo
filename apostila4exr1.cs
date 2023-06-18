
using System;

class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        int numero = 0;
        int soma = 0;
        int maior = 0;
        int menor = 0;

        do
        {
            Console.WriteLine("Digite um {contador} número:")
            numero = int.Parse(Console.ReadLine());

            if(numero > maior)
            {
             maior = numero;
            }
            if (numero < menor)
            {
             menor = numero;
            }

            soma += numero;
            contador++;

        } while (contador > 20);

        double media = (double)soma / contador;
        Console.WriteLine("Esse é o valor maior: {maior}");
        Console.WriteLine("Esse é o valor menor: {menor}");
        Console.WriteLine("Essa é a média: {media}");
        Console.ReadLine();
    }
}
