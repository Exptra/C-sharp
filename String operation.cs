using System;  
public class Exercise9  
{  
    public static void Main() 
{
    string str;
    int i, vol1, vol2, vol3, vol4, vol5; // mengecek string vokal
		
   	Console.Write("Input : ");
    str = Console.ReadLine();		

    vol1 = 0; // [i]
	vol2 = 0; // [i]
	vol3 = 0; // [i]
	vol4 = 0; // [i]
	vol5 = 0; // [i]
 
    for(i=0; i<str.Length; i++)
    {
       if(str[i] =='a' || str[i]=='A' )        
        {
            vol1++;	// jika string[i] == 'o' || 'O' then +1
        }
		else if (str[i] == 'i' || str[i] == 'I')        
        {
           vol2++;   // jika string[i] == 'o' || 'O' then +1
        }
		else if (str[i] == 'u' || str[i] == 'U')
		{
			vol3++;  // jika string[i] == 'u' || 'U' then +1
		}
		else if (str[i] == 'e' || str[i] == 'E')
		{
			vol4++;	 // jika string[i] == 'e' || 'E' then +1
		}
		else if (str[i] == 'o' || str[i] == 'O')
		{
			vol5++;  // jika string[i] == 'o' || 'O' then +1
		}
	}
		
   	Console.WriteLine(" A : {0}", vol1);
   	Console.WriteLine(" I : {0}", vol2);
   	Console.WriteLine(" U : {0}", vol3);
	Console.WriteLine(" E : {0}", vol4);
	Console.WriteLine(" O : {0}", vol5);
	
	}
}
