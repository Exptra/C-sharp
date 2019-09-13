using System;
					
public class Program
{
	public static double ProcNum(double param){
		//Console.WriteLine(param);
		string num = param.ToString();
		
		double result = 0;
		for(int x = 0 ; x < num.Length ; x++){
			double temp = Convert.ToDouble(num[x].ToString());
			result += Math.Pow(temp,2);
			//Console.WriteLine(num[x]);
			//int z = Convert.ToUInt16(num[x].ToString());
			//Console.WriteLine(z);
		}
		
		return result;
	}
	
	public static bool checkNumber(double param){
		while(param > 9){
			param = ProcNum(param);
		}
		
		//Console.WriteLine("param = " + param);
		
		if(param == 1){
			return true;
		}
		else{
			return false;
		}
		
	}
	
	public static void Main()
	{
		//Console.WriteLine(Math.Pow(2,2));
		
		Console.WriteLine("Input N Number : ");
		int input = Convert.ToInt32(Console.ReadLine());
		
		int count=0;
		double start = 100;
		
		while(count < input){
			
			//If found the number
			if(checkNumber(start)){
				//Print out
				Console.WriteLine(start + " is The One Number");
				
				//Increment count
				count++;
				
			}
			
			start++;
		}
		
		
	}
}