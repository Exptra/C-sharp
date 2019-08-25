using System;

public class Program
{
	public static void Main()
	{
	 int L, W, H, N;
	 Console.WriteLine("Input L");
	 L = Convert.ToInt32(Console.ReadLine());
	 Console.WriteLine("Input N");
	 N = Convert.ToInt32(Console.ReadLine());
	 /*Console.WriteLine("Input W and H");
	 string s = Console.ReadLine();
	 string[] values = s.Split(' ');
	 W = int.Parse(values[0]);
	 H = int.Parse(values[1]);
		//for(int i =0;i<N;i++)	
		if(W>=L && H>=L)
		{
			if(W==H)
			{
			Console.WriteLine("ACCEPTED");
			}
			else
			{
			Console.WriteLine("CROP IT");
			}	
		}
		else
		{
		Console.WriteLine("UPLOAD ANOTHER");
		}	
		*/
		/*
		for(int i =0; i < N;i++){
			Console.WriteLine("Input W and H");
			 string s = Console.ReadLine();
			 string[] values = s.Split(' ');
			 W = int.Parse(values[0]);
			 H = int.Parse(values[1]);
				//for(int i =0;i<N;i++)	
				if(W>=L && H>=L)
				{
					if(W==H)
					{
					Console.WriteLine("ACCEPTED");
					}
					else
					{
					Console.WriteLine("CROP IT");
					}	
				}
				else
				{
				Console.WriteLine("UPLOAD ANOTHER");
				}	
		}
		*/
		
		//Tampung input dari user maks.1000 input
		string[] tempArray = new string[1000];
		
		for(int i =0; i < N;i++){
			Console.WriteLine("Input W and H");
			 string s = Console.ReadLine();
			 tempArray[i] = s;
				
		}
		
		//Olah untuk output
		for(int i =0; i < N;i++){
			 string[] values = tempArray[i].Split(' ');
			 W = int.Parse(values[0]);
			 H = int.Parse(values[1]);
				//for(int i =0;i<N;i++)	
				if(W>=L && H>=L)
				{
					if(W==H)
					{
					Console.WriteLine("ACCEPTED");
					}
					else
					{
					Console.WriteLine("CROP IT");
					}	
				}
				else
				{
				Console.WriteLine("UPLOAD ANOTHER");
				}	
		}
		
	}
}