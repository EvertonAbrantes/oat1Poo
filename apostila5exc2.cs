using System;


namespace 
{
    class Carro
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Ano { get; set; }
    }

    class Program
    {
        static List<Carro> carros = new List<Carro>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Cadastrar veículo");
                Console.WriteLine("2 - Excluir veículo");
                Console.WriteLine("3 - Listar do menor para o maior");
                Console.WriteLine("4 - Sair");

                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite a marca do carro: ");
                        string marca = Console.ReadLine();

                        Console.Write("Digite o nome do carro: ");
                        string nome = Console.ReadLine();

                        Console.Write("Digite a cor do carro: ");
                        string cor = Console.ReadLine();

                        Console.Write("Digite o ano do carro: ");
                        string ano = Console.ReadLine();

                        carros.Add(new Carro { Marca = marca, Nome = nome, Cor = cor, Ano = ano });

                        Console.WriteLine("Carro cadastrado!");
                        break;

                    case 2:
                        Console.WriteLine("Escolha o carro que deseja excluir:");
                        for (int i = 0; i < carros.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - Marca: {carros[i].Marca} | Nome: {carros[i].Nome} | Cor: {carros[i].Cor} | Ano: {carros[i].Ano}");
                        }

                        Console.Write("Digite o número do carro que deseja excluir: ");
                        int indicarParaExclusao = int.Parse(Console.ReadLine()) - 1;

                        if (indicarParaExclusao >= 0 && indicarParaExclusao < carros.Count)
                        {
                            carros.RemoveAt(indicarParaExclusao);
                            Console.WriteLine("Carro excluído com sucesso.");
                        }
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                        break;

                    case 3:
                        List<Carro> carrosOrdenados = new List<Carro>(carros);
                        carrosOrdenados.Sort((c1, c2) => c1.Marca.CompareTo(c2.Marca));

                        Console.WriteLine("Carros ordenados por marca:");
                        foreach (Carro carro in carrosOrdenados)
                        {
                            Console.WriteLine($"Marca: {carro.Marca} | Nome: {carro.Nome} | Cor: {carro.Cor} | Ano: {carro.Ano}");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
