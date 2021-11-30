using System;

public class Function
{
	public static int validateIntegerInput(string prompt){
		Console.WriteLine(prompt);
		string numStr = Console.ReadLine();
		if(string.IsNullOrEmpty(numStr))
		{
    		Console.WriteLine("Nenhum valor introduzido.");
    		return validateIntegerInput(prompt);
		}
		
		int num;
		bool tryParse = int.TryParse(numStr, out num);
		if (!tryParse){
    		Console.WriteLine("Isto não é um número inteiro!");
			return validateIntegerInput(prompt);
		}
		
		return num;
	}
	
    public static string checkIfEvenOdd()
	{		
		if (validateIntegerInput("Insira um número inteiro: ") % 2 == 0)
			return "Número par.";
		return "Número ímpar.";
	}
	
	public static string checkIfLeapYear()
	{
		int a = validateIntegerInput("Insira um ano: ");
		
		if ((a%4 != 0) && (a%100 != 0) && (a%400 != 0))
			return "Ano não bissexto.";
		return "Ano bissexto.";
	}
}

public class Program
{
	public static void Main()
	{
		Console.WriteLine(Function.checkIfEvenOdd());
		Console.WriteLine(Function.checkIfLeapYear());
	}
}