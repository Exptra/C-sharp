using System;
using System.Linq;
using System.Collections.Generic;
					
public class Program
{
	static void printResult(List<char> input)
	{
		foreach(char item in input){
			Console.Write(item);
		}
	}
	
	public static void Main()
	{
		
		Console.WriteLine("Input String : ");
		string input = Console.ReadLine();
		
		//Sort the string
		input = input.Replace(" ", "").ToLower();
		char[] characters = input.ToArray();
		Array.Sort(characters);
		
		//Create list for vowel and consonant
		List<char> vowel = new List<char>();
		List<char> consonant = new List<char>();
		
		foreach(char item in characters){
			if(item == 'a' || item == 'A' || item == 'i' || item == 'I' || item == 'u' || item == 'U' || item == 'e' || item == 'E' || item == 'o' || item == 'O'){
				vowel.Add(item);
			}
			else{
				consonant.Add(item);
			}
		}
		
		Console.WriteLine("Vowel Characters : ");
		printResult(vowel);
		Console.WriteLine("\nConsonant Characters : ");
		printResult(consonant);
	}
} 