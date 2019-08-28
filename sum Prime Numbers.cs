using System;
					
public class Program
{
	public static void Main()
	{
			
			int l,r, sum = 0;
			
			Console.WriteLine("Enter ");
            string a = Console.ReadLine();
			string[] values = a.Split(' ');
		
			l = int.Parse(values[0]);
			r = int.Parse(values[1]);
			
			int container; // initialial var penampung
			for (int i = l+1; i < r; i++) // ambil dari inputan ++
			{		container = 0; // set value var penampung
				for (int j = 1; j <= i ; j++) // jika var j dinisialisasi = 0; dia tidak bisa mengeksekusi (Attempted to divide by zero)
				{
						if (i%j == 0) 
						{
							container = container +1;   // save // or container ++;
						} 
				}
				if (container == 2){
					sum += i;
				}
			}
			Console.WriteLine(sum);
		}
}