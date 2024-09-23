using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        string continuar;

        do
        {
            int resultado = random.Next(1, 7); 
            Console.WriteLine($"Resultado do dado: {resultado}");
            
            Console.Write("Deseja lançar o dado novamente? (sim ou não): ");
            continuar = Console.ReadLine()?.ToLower();
        } while (continuar == "sim");

        Console.WriteLine("Obrigado por jogar!");
    }
}