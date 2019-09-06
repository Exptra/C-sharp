using System;  
public class Exercise9  
{  
    public static void Main() 
{
    string str;
    int consonant, vokal; // deklarasi variable vokal & consonant
	vokal = 0; // [i]
 	consonant = 0; // [i]
		
	Console.WriteLine("Berapa Karakter ?");
    	int Bkarakter = Convert.ToInt16(Console.ReadLine());
	for (int j=0; j<Bkarakter; j++) {
		vokal = 0; // [i]
 		consonant = 0; // [i]
		Console.Write("Input Karakter : ");
   		str = Console.ReadLine();			
    		for(int i=0; i<str.Length; i++)
    		{
       		if(str[i] =='a' || str[i]=='i' || str[i] == 'u' || str[i] == 'e' || str[i] == 'o' || str[i] == 'A' || str[i] == 'I' || str[i] == 'U' || str[i] == 'E' || str[i] == 'O')        
        	{
            	vokal++; // jika string[i] == 'a.i.u.e.o'
         	}
			else if((str[i]>='a' && str[i]<='z') || (str[i]>='A' && str[i]<='Z')) // ngecek.menghitung string A-Z jika string[i] tidak ada vokal lalu dihitung 
        	{
            	consonant++;  // jika string[i] == 'selain a.i.u.e.o'
        	}
    	}
	Console.WriteLine("Jumlah huruf vokal : {0}", vokal);
	Console.WriteLine("Jumlah huruf konsonan : {0}", consonant);
	Console.WriteLine();
	}
    }
}
