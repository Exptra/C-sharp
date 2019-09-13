using System;
					
public class Program
{
	public static int reverseNum(int number){
		int reverse = 0;  
		while(number>0)  
		{  
			int remainder = number % 10;  
			reverse = (reverse * 10) + remainder;  
			number = number / 10;  
		}  
		
		return reverse;
	}
	
	public static bool checkPrime(int number){
		
		for(int i = 2; i<number ;i++){
			
			if(number % i == 0){
				return false;
			}
			
		}
		return true;
	}
	
	public static void Main()
	{
		Console.WriteLine("Input N Number : ");
		int input = Convert.ToInt32(Console.ReadLine());
		
		int count=0;
		int start = 10;
		
		while(count < input){
			
			//If found the number
			if(checkPrime(start) == true && checkPrime(reverseNum(start)) == true){
				Console.WriteLine(start + " and " + reverseNum(start) + " are Match");
				
				count++;
			}
			
			start++;
		}
		
		
		
		
	}
}