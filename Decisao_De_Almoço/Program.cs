using System;

class Program
{
    static void Main()
    {
        string[] opcoes = { "Pizza", "Hambúrguer", "Sushi", "Salada", "Churrasco" };

        Console.WriteLine("Bem-vindo à Decisão de Almoço!");
        Console.WriteLine("Você quer ver as opções ou deixar o programa escolher por você?");
        Console.WriteLine("Digite 1 para ver as opções, ou 2 para escolha aleatória:");

        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Aqui estão as opções de hoje:");
            foreach (string opcao in opcoes)
            {
                Console.WriteLine("- " + opcao);
            }
        }
        else if (escolha == "2")
        {
            Random random = new Random();
            int indexAleatorio = random.Next(opcoes.Length);
            Console.WriteLine("Escolha aleatória: " + opcoes[indexAleatorio]);
        }
        else
        {
            Console.WriteLine("Opção inválida! Tente novamente.");
        }
    }
}
