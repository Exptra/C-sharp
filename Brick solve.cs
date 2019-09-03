using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("X_Brick :");
		string input = Console.ReadLine();
		int n = Convert.ToInt32(input);
		
		Console.Write("Total_Brick :");
		string masuk = Console.ReadLine();
		int x = Convert.ToInt32(masuk);
		
			if ( x%(n+(n*3)) ==0 ){
				Console.WriteLine("Yoga");
			}else if ( x%(n+(n*3)) <= n){
				Console.WriteLine("Adhit");
			}else {
				Console.WriteLine("Yoga");
			}
	}
}
