using System;

namespace HelloWorld
{
  	class Program
	{
    		static void Main(string[] args)
    		{
			Console.WriteLine("CALCULADORA");
			Console.WriteLine("Digite O Primeiro Numero Inteiro.");
			string xs = Console.ReadLine();
			int x = int.Parse(xs);
			Console.WriteLine("Qual Sera A Operacao?");
			Console.WriteLine("[+,-,*,/]");
			string op = Console.ReadLine();
			Console.WriteLine("Digite O Segundo Numero Inteiro.");
			string ys = Console.ReadLine();
			int y = int.Parse(ys);
			if (op == "+")
			{
				Console.WriteLine(x + y);
			}
			if (op == "-")
			{
				Console.WriteLine(x - y);
			}
			if (op == "*")
			{
				Console.WriteLine(x * y);
			}
			if (op == "/")
			{
				Console.WriteLine(x / y);
			}
    		}
  	}
}

