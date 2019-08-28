using System;
					
public class Program
{
	public static void Main()
	{
		int x = 0;
		int y = 0;
		
		string input = Console.ReadLine();
		for (int i = 0; i < input.Length; i++){
			if (input[i] == 'R' || input[i] == 'r')
			{x++;}
			else if (input[i] == 'L' || input[i] == 'l')
			{x--;}
			else if (input[i] == 'U' || input[i] == 'u')
			{y++;}
			else if (input[i] == 'D' || input[i] == 'd')
			{y--;}
			else 
			{Console.WriteLine("Error"); return;}    // Console.WriteLine("{0} {1}" x,y);
		}
		Console.WriteLine(x+","+y);
	}
}
