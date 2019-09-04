using System;

public class Program
{
	public static void Main()
	{
		Smartphone ipon = new Smartphone();
		ipon.Name = "Ipon";
		ipon.Rom = 32; // 32 GB
		ipon.Ram = 4; // 4 GB
		Console.WriteLine("The Price of Smartphone "+ ipon.Name + " with ROM "+ ipon.Rom + "GB and RAM "+ ipon.Ram + "GB is Rp "+ ipon.getPrice());
		
		Smartphone samsul = new Smartphone();
		samsul.Name = "Samsul";
		samsul.Rom = 16; // 16 GB
		samsul.Ram = 4; // 4 GB
		Console.WriteLine("The Price of Smartphone "+ samsul.Name + " with ROM "+ samsul.Rom + "GB and RAM "+ samsul.Ram + "GB is Rp "+ samsul.getPrice());
	}
}

public class Smartphone // membuat class smartphone
{
	private string name;
	private int rom;
	private int ram;
	
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
	public int getPrice() //  method untuk output harga&rom&ram samsul.getPrice sama ipon.getPrice 
	{
		return rom * 100000 + ram*150000; // menyimpan return untuk getPice // mengembalikan nilai dari int getPrice
	}
}