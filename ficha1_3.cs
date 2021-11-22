using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Insira um número inteiro:");
		string numStr = Console.ReadLine();

		while (string.IsNullOrEmpty(numStr))
		{
    		Console.WriteLine("Nenhum valor introduzido.");
			Console.WriteLine("Por favor insira um número inteiro:");
    		numStr = Console.ReadLine();
		}
		
		if (numStr == "0"){
			Console.WriteLine("Não é possível dividir por zero.");
		} else {
			int num;
			bool tryParse = int.TryParse(numStr, out num);

			if (!tryParse)
    			Console.WriteLine("Isto não é um número inteiro!");
			else
				if (num%2 != 0)
					Console.WriteLine("Resultado da divisão: " + (float)num/2);
				else
					Console.WriteLine("Resultado da divisão:: " + num/2);
		}
	}
}