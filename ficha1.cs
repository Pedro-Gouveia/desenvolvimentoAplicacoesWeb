

using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            void ex10()
            {
                float totalHoras = 48;
                return "Pode faltar a : " + totalHoras * .1 + " horas.";
            }
            
            void ex11()
            {
                int num = 14;
                int num2 = 25;
		
                for (int i = num; i < num2; i++) 
                {
                    if (i%5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            string ex12()
            {
                int num = 3;
                if (num%2 == 0)
                {
                    return "Número par";
                }
                return "Número ímpar";

            }
            
            //ex11();
            Console.WriteLine(ex12());
        }
    }
}