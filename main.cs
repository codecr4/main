using System;

class MainClass {
  public static void Main (string[] args) {
    
	//first calculator using c sharp
	Console.WriteLine("C# calculator _________ ;");
	Console.WriteLine("by @codebrat12 :");
	
	//declare operand variables and initializing
	int x = 0 ; int y = 0 ;

	//grab the first operand
	Console.Write("Enter the first number and press enter : ");
	x = Convert.ToInt32(Console.ReadLine());

	//grab the second operand
	Console.Write("Enter the second number and press enter : ");
	y = Convert.ToInt32(Console.ReadLine());

	//grab operator
	Console.WriteLine("Choose an operator from the following ;");
	Console.WriteLine("/ta - Add");
	Console.WriteLine("/ts - Subtract");
	Console.WriteLine("/tm - Multiply");
	Console.WriteLine("/td - Divide");
	Console.Write("Your option : ");

	//calculation  logic
	switch (Console.ReadLine())
	{
		case "a" :
			Console.WriteLine($"results of  {x} + {y} = " + (x + y));
			break;	
		case "s" :
			Console.WriteLine($"results of  {x} - {y} = " + (x - y));
			break;
		case "m" :
			Console.WriteLine($"results of  {x} * {y} = " + (x * y));
			break;	
		case "d" :
			Console.WriteLine($"results of  {x} / {y} = " + (x / y));
			break;					
		
	}

	//delay execution
	Console.WriteLine("Press any key to close the program : ");
	Console.Read();




  }
}