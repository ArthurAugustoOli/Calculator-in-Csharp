using System;
class CalculatoRr
{
	static void Main()
	{
		string Lobby, LobbyUp;
		Console.Clear();
		Restart:
		Console.Write("(E) English\n(P) Portuguese\n(S) Simplificate\n Answer / Resposta : ");
		Lobby = Console.ReadLine();
		LobbyUp = Lobby.ToUpper();
		//Its a literaly lobby
		
		
		if (LobbyUp == "E")
		{
			
		string NameUser;
		char Operator;
		double Result, Number1, Number2;
		// Declaration of variables
		Console.Write("Hey user, please, write your name: ");
		NameUser = Console.ReadLine();
		// just to have a name to talk to
		start:
		Console.Write("Hello {0}, take a number now to start calculating: ", NameUser);
		Number1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Ok, which operation do you want to do?\n The operation valid is\n---> ('+') - ('-') - ('*') - ('/') <---\n");
		Operator = char.Parse(Console.ReadLine());
		Console.Write("Give me the second number now to finish the program: ");
		Number2 = Convert.ToDouble(Console.ReadLine());
		
		switch (Operator)
		{
			case ('+'):
				Result = Number1 + Number2;
				break;
			case ('-'):
				Result = Number1 - Number2;
				break;
			case ('*'):
				Result = Number1 * Number2;
				break;
			case ('/'):
				Result = Number1 / Number2;
				break;
			default:
				Console.Clear();
				Console.Write("You give a wrong information, repeat program...\n");
				goto start;
			
		}
		Console.Write("Ok {0}, The result is\n {1} {2} {3} = {4} ", NameUser, Number1, Operator, Number2, Result);	
		}
		
		
		
		
		else if (LobbyUp == "P")
		{
			string NameUser;
		char Operator;
		double Result, Number1, Number2;
		// Declaration of variables
		Console.Write("Hey Usuario, por favor me dê seu nome: ");
		NameUser = Console.ReadLine();
		// just to have a name to talk to
		start:
		Console.Write("Oi {0}, Me dê o primeiro número do calculo: ", NameUser);
		Number1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Ok, Qual operação você deseja fazer?\n As operações validas são:\n---> ('+') - ('-') - ('*') - ('/') <---\n");
		Operator = char.Parse(Console.ReadLine());
		Console.Write("Forneça-me o segundo número para o fim do programa: ");
		Number2 = Convert.ToDouble(Console.ReadLine());
		
		switch (Operator)
		{
			case ('+'):
				Result = Number1 + Number2;
				break;
			case ('-'):
				Result = Number1 - Number2;
				break;
			case ('*'):
				Result = Number1 * Number2;
				break;
			case ('/'):
				Result = Number1 / Number2;
				break;
			default:
				Console.Clear();
				Console.Write("Você forneceu uma operação inválida, repita o programa...\n");
				goto start;
			
		}
		Console.Write("Ok {0}, O resultado é\n {1} {2} {3} = {4} ", NameUser, Number1, Operator, Number2, Result);	
		}
		else if (LobbyUp == "S")
		{
		char Operator;
		double Result, Number1, Number2;
		start:
			Console.WriteLine("Enter the first value: ");
		Number1 = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter the operator now...\n---> ('+') - ('-') - ('*') - ('/') <---\n");
		Operator = char.Parse(Console.ReadLine());
			Console.WriteLine("Enter the second value: ");
		Number2 = Convert.ToDouble(Console.ReadLine());
		switch (Operator)
		{
			case ('+'):
				Result = Number1 + Number2;
				break;
			case ('-'):
				Result = Number1 - Number2;
				break;
			case ('*'):
				Result = Number1 * Number2;
				break;
			case ('/'):
				Result = Number1 / Number2;
				break;
			default:
				Console.Clear();
				Console.Write("You give a wrong information, repeat program...\n");
				goto start;
			
		}
		Console.Write("\n---Answer---\n{0} {1} {2} = {3} \n---Answer---\n", Number1, Operator, Number2, Result);	
		}
		
		else
		{
			Console.Clear();
			Console.Write("You give a wrong information, repeat program...\n");
			goto Restart;
		}


		Console.WriteLine("\n\n\n\n______________________\nThanks for Atencion!!!\n\n...\nMade by Arthur Augusto.\n...\n\n\nPress any key...");
		Console.ReadKey();
		
		
		
		
		
		
		
		
		
		
		
	}
}