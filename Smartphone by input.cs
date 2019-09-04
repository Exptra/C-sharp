using System;
using System.Collections.Generic;
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How many Smartphone ? "); // mengambil inputan banyaknya smartphone
		int n = Convert.ToInt32(Console.ReadLine());
		List<Smartphone> listData = new List<Smartphone>();  // tampung nilai data pada smartphone
		
		
		for (int a = 0; a < n; a++) { 
			Console.WriteLine("Smartphone name ");
			string name = Console.ReadLine();
			Console.WriteLine("Smartphone ROM ");
			int rom1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Smartphone RAM ");
			int ram1 = Convert.ToInt32(Console.ReadLine());
			
			
			Smartphone ipon = new Smartphone();  // membuat objeck/instances ipon
			ipon.Name = name;
			ipon.Rom = rom1; // 
			ipon.Ram = ram1; //
			listData.Add(ipon);  // mengambil data dari object/instance ipon
		}
		foreach(Smartphone item in listData){   // mengambil nilai Smartphone pada tampungan dari item
			Console.WriteLine("The Price of Smartphone "+ item.Name + " with ROM "+ item.Rom + "GB and RAM "+ item.Ram + "GB is Rp "+ item.getPrice());
		}
	}
}
public class Smartphone // membuat class smartphone
{
	private string name;    // private accessible
	private int rom;            // private accessible
	private int ram;				// private accessible
	
	public string Name {
		set { name = value; }
		get { return name; }
	}
	public int Rom {
		set { rom = value; }
		get { return rom;}
	}
	public int Ram {
		set {ram = value;}
		get {return ram;}	
	}
	public int getPrice() //  method untuk count harga&rom&ram samsul.getPrice sama ipon.getPrice // tipe data int pada return 
	{
		return rom * 100000 + ram*150000; // menyimpan return untuk int getPice 
	}
}