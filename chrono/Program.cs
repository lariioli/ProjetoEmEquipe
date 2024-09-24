using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de segundos para o cronômetro:");
        if (int.TryParse(Console.ReadLine(), out int segundos) && segundos > 0)
        {
            StartTimer(segundos);
        }
        else
        {
            Console.WriteLine("Por favor, insira um número válido de segundos.");
        }
    }

    static void StartTimer(int segundos)
    {
        for (int i = 0; i < segundos; i++)
        {
            Console.Clear();
            Console.WriteLine($"Tempo decorrido: {i + 1} segundos.");
            Thread.Sleep(1000);
        }

        
        Console.WriteLine("Cronômetro finalizado!");
    }
}