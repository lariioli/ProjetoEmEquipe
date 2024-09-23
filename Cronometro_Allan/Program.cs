using System;
using System.Threading;

class Program 
{
    static void Main()
    {
        Console.Write("Digite o tempo do cronômetro em segundos: ");
        int segundos;
        
        while (!int.TryParse(Console.ReadLine(), out segundos) || segundos < 0)
        {
            Console.WriteLine("Por favor, insira um número inteiro positivo.");
        }
        
        
        Console.WriteLine("Cronômetro iniciado...");
        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(segundos);
        
        while (DateTime.Now < fim)
        {
            Console.Clear();
            TimeSpan tempoRestante = fim - DateTime.Now;
            Console.WriteLine($"\nTempo restante: {tempoRestante.Seconds} segundos");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine("\nTempo esgotado!");
    }
}
