using System;
// Professor nesse exercicio tive quq ter um auxilio do chat gpt :/

class Program
{
    int[] vetor;

    Program()
    {
        vetor = null;
    }

    static void Main(string[] args)
    {
        Program programa = new Program();
        int opcao;

        do
        {
            Console.WriteLine("Opções:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares nas posições ímpares");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares nas posições pares");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    programa.CarregarVetor();
                    break;
                case 2:
                    programa.ListarVetor();
                    break;
                case 3:
                    programa.NumerosPares();
                    break;
                case 4:
                    programa.NumerosImpares();
                    break;
                case 5:
                    programa.QntParesPosicoesImpares();
                    break;
                case 6:
                    programa.QntImparesPosicoesPares();
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();

        } while (opcao != 0);
    }

    private void CarregarVetor()
    {
        Console.Write("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());
        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o valor para a posição {i}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!");
    }

    public void ListarVetor()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
            return;
        }

        Console.WriteLine("Vetor:");
        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
    }

    public void NumerosPares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
            return;
        }

        Console.WriteLine("Números pares:");
        foreach (int num in vetor)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    public void NumerosImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
            return;
        }

        Console.WriteLine("Números ímpares:");
        foreach (int num in vetor)
        {
            if (num % 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }

    public void QntParesPosicoesImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
            return
