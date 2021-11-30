using System;

public class Function
{
    public static string checkIfEvenOdd()
	{
		Console.WriteLine("Insira um número inteiro:");
		string numStr = Console.ReadLine();
		
		if(string.IsNullOrEmpty(numStr))
		{
    		Console.WriteLine("Nenhum valor introduzido.");
    		return checkIfEvenOdd();
		}
		
		int num;
		bool tryParse = int.TryParse(numStr, out num);
		if (!tryParse)
        {
    		Console.WriteLine("Isto não é um número inteiro!");
			return checkIfEvenOdd();
		}
		
		if (num % 2 == 0)
			return "Número par.";
		return "Número ímpar.";
	}	
}

public class Program
{
	public static void Main()
	{
		Console.WriteLine(Function.checkIfEvenOdd());
	}
}