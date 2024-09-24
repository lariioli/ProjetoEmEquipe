using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Insira o seu peso em kg: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Insira a sua altura em metros: ");
        double altura = Convert.ToDouble(Console.ReadLine());
		
        double imc = peso / (altura * altura);
		
        Console.WriteLine($"Seu IMC é: {imc:F2}");
        
        if (imc < 18.5)
        {
            Console.WriteLine("Categoria: Abaixo do peso");
        }
        else if (imc >= 18.5 && imc < 24.9)
        {
            Console.WriteLine("Categoria: Peso normal");
        }
        else if (imc >= 25 && imc < 29.9)
        {
            Console.WriteLine("Categoria: Sobrepeso");
        }
        else
        {
            Console.WriteLine("Categoria: Obesidade");
        }
    }
}
