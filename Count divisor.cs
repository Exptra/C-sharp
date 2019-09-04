using System;
					
public class Program
{
	public static void Main()
	{
			int l,r,k, sum = 0;
			Console.WriteLine("Enter ");
           		string a = Console.ReadLine();
			string[] values = a.Split(' ');  
		
			l = int.Parse(values[0]);        //untuk inputan ke -1 menjadi [0]  //Console.WriteLine(l); //Console.WriteLine(r); //Console.WriteLine(k);
			r = int.Parse(values[1]);         //untuk inputan ke -2 menjadi [1]
			k = int.Parse(values[2]);			//untuk inputan ke -3 menjadi [2]
	
			Console.WriteLine("Output ");
			for (int i = l+1; i < r; i++){        //Console.Write(i);
				if ( i % k == 0 ){
					sum += i;		                 //Console.WriteLine(sum);
				}                                           //Console.WriteLine(sum);
			}Console.WriteLine(sum);
		}
	}
