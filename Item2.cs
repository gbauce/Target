using System

class Program
{
	static void Main(string[] args)
	{
		int numero = 88; //numero a ser verificado
		int valoranterior = 0; //inicializa sequencia fibonacci
		int valoratual = 1;
		bool localizado = false; //verifica se consta na sequencia fibonacci
		
		while (valoratual <= numero)
		{
			if (valoratual == numero)
			{
				localizado = true;
				break;
			}
			
			int proximovalor = valoranterior + valoratual;
			valoranterior = valoratual;
			valoratual = proximovalor;
		}
		
		if (localizado) //imprime a mensagem de acordo com o valor inserido
		{
			Console.WriteLine($"{numero} pertence a cadeia Fibonacci.");
		}
		else
		{
			Console.WriteLine($"{numero} não pertence a cadeia Fibonacci.")
		}
	}
}
		