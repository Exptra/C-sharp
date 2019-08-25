using System;
					
public class Program
{
	public static void Main()
	{
		int in1 = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < in1; i++){
			for(int j = 0; j < in1; j++){
				if(j < i){
					Console.Write(" ");	
				}
				else{
					Console.Write("*");	
				}
				/*
				if(j < (in1-i)){
					Console.Write("*");	
				}
				else{
					Console.Write(" ");	
				}
				*/
				//Console.Write("*");	
			}
			Console.WriteLine("\n");
		}		
	}
}
