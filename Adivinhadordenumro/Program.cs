using System;

class Program
{
    static void Main()
    {
        
        Random random = new Random();
        int numerosecreto = random.Next(1, 101);

        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Tente adivinhar o número entre 1 e 100!");

       
        do 
        {
            Console.Write("Digite o seu palpite: ");
           
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            
            if (palpite < numerosecreto)
            {
                Console.WriteLine("O número é maior!");
            }
            else if (palpite > numerosecreto)
            {
                Console.WriteLine("O número é menor!");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou o número em {tentativas} tentativas.");
            }
			
        }
		while (palpite != numerosecreto);
    }
}

