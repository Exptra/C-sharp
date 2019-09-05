using System;

public class Math{
	
	private int jumlah_angka;
	
	public int Jumlah_Angka{
		set { jumlah_angka = value; }
		get { return jumlah_angka; }
	}
	
	 public void Hitung() // method
    {
		for (int i = 0; i < jumlah_angka*2; i++) {
		if ( i % 2 == 1 ) {
			Console.Write(i + " ");
    		}
		}
	}
}

public class Program
{
	public static void Main()
	{		 
		Console.WriteLine("Input X number ");
		int jumlah_angka = Convert.ToInt16(Console.ReadLine());
		Math obj_math = new Math();
		obj_math.Jumlah_Angka = jumlah_angka;
		obj_math.Hitung();
	}
}