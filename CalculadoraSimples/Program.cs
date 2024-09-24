using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("bem vindo a calculadora");
		Double Valor1, Valor2, calculo;
		Console.Write("insira o primeiro valor: ");
		string texto = Console.ReadLine();
		Console.Write("insira a operação que deseja fazer (+,-,*,/) ");
		string sinal = Console.ReadLine();
		Console.Write("insira o segundo valor:");
		string texto1 = Console.ReadLine();
		if(Double.TryParse(texto, out Valor1)){
	    if(Double.TryParse(texto1, out Valor2)){
		switch(sinal)	
		{
	    case "+":
		calculo = Valor1 + Valor2;
		Console.Write($"O Resultado da Soma é {calculo}");
		break;
		case "-":
		calculo = Valor1 - Valor2;
		Console. Write($"O Resultado da subtração é {calculo}");
		break;
		case "*":
		calculo = Valor1 * Valor2;	
		Console. Write($"O Resultado da multiplicação é  {calculo}");
		break;
		case "/":	
		calculo = Valor1 / Valor2;
	    Console. Write($"O Resultado da divisão é  {calculo}");
		break;
		}
		}
		else{
		Console.Write("valor invalido");
		}
		}
		
		     else{
			     Console.Write("Valor Inválido");
		}
		
		
		
		
		
	}
}