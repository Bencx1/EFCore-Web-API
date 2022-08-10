using System;
using System.Globalization;
namespace Class1
{
	public Class1()
	{
		static void Main(string[] args)
		{
			int idade = 32;
			double saldo = 10.35784;
			String Nome = "Maria";

			Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", Nome, idade, saldo);
			Console.WriteLine($"{Nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");
			Console.WriteLine(Nome + "tem" + idade + "anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + "reais");
		}
	}
}