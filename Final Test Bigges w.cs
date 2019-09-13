using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		//Input variable
		string input = Console.ReadLine();
		
		//Split to array
		string[] arrInput = input.Split(' ');
		
		//Create list to collect set of count
		List<int> baseNumber = new List<int>();
		List<int> listNumber = new List<int>();
		
		//Put all number
		foreach(string str in arrInput){
			baseNumber.Add(Convert.ToInt32(str));
		}
		
		foreach(int item in baseNumber){
			//Console.WriteLine(item);
		}
		
		//Put all form number
		for(int i = 0 ; i< baseNumber.Count ;i++){
			
			int temp = 0;
			int start_j = i;
			for(int j = start_j; j<= baseNumber.Count; j++){
				
				if(j == baseNumber.Count){
					if(start_j < (baseNumber.Count)-1){
						start_j++;
						temp=baseNumber.ElementAt(i);
						j=start_j;
					}
					else{
						break;
					}
				}
				
				temp += baseNumber.ElementAt(j);
				
				listNumber.Add(temp);
				//Console.WriteLine(temp);
				
			}
		}
		
		//Check biggest W
		int w = 1;
		while(true){
			
			if(listNumber.Contains(w)){
				w++;
			}
			else{
				Console.WriteLine(w-1);
				return;
			}
			
		}
		
	}
}