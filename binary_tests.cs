using System;
					
public class Program
{
	public static void Main()
	{
		int a, b;
		a = b = 1;
		Console.WriteLine(a == b ? true : false);
		
		int x = 8;
		Console.WriteLine(x^= 15);
	}
}