// Everton Fernandes Abrantes - SIS
// Exercício 01
using apostila;

class Program
{
    static void Main(string[] args)
    {
        Carro objCarro = new Carro();
        objCarro.idCarro = 1;
        objCarro.marcaCarro = "Fiat";
        objCarro.modeloCarro = "Argo";
        objCarro.placaCarro = "prs1301";
        objCarro.corCarro = "branco";

        Console.WriteLine(objCarro.idCarro);
        Console.WriteLine(objCarro.marcaCarro);
        Console.WriteLine(objCarro.modeloCarro);
        Console.WriteLine(objCarro.placaCarro);
        Console.WriteLine(objCarro.corCarro);

        Carro objCarro = new Carro();
        objCarro.idCarro = 2;
        objCarro.marcaCarro = "Volkswagen";
        objCarro.modeloCarro = "Polo";
        objCarro.placaCarro = "wrs2345";
        objCarro.corCarro = "cinza";

        Console.WriteLine(objCarro.idCarro);
        Console.WriteLine(objCarro.marcaCarro);
        Console.WriteLine(objCarro.modeloCarro);
        Console.WriteLine(objCarro.placaCarro);
        Console.WriteLine(objCarro.corCarro);

        Carro objCarro = new Carro();
        objCarro.idCarro = 3;
        objCarro.marcaCarro = "Bmw";
        objCarro.modeloCarro = "320i";
        objCarro.placaCarro = "tys4978";
        objCarro.corCarro = "preto";

        Console.WriteLine(objCarro.idCarro);
        Console.WriteLine(objCarro.marcaCarro);
        Console.WriteLine(objCarro.modeloCarro);
        Console.WriteLine(objCarro.placaCarro);
        Console.WriteLine(objCarro.corCarro);






    }
}
