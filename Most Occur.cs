using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		string input = Console.ReadLine();		
		
		string[] arrInput = input.Split(' ').ToArray();
		
		int count = 0;
		int lastCount = 0;
		int mostOccureNumber = 0;
		bool sameFreq = false;
		
		for(int i = 0; i<arrInput.Length;i++){
			//Console.WriteLine(arrInput[i]);
			count = 0;
			for(int j = 0; j<arrInput.Length;j++){
				if(arrInput[i] == arrInput[j]){
					count++;
				}
			}
			
			if(count > lastCount){
				lastCount = count;
				mostOccureNumber = Convert.ToInt16(arrInput[i]);
				sameFreq = false;
			}
			else if(count == lastCount && mostOccureNumber != Convert.ToInt16(arrInput[i])){
				sameFreq = true;
			}
			
		}
		
		if(sameFreq){
			Console.WriteLine("Not Found");
		}
		else{
			Console.WriteLine("Found " +  mostOccureNumber + " occurs " + lastCount + " times.");
		}
		
	}
}
