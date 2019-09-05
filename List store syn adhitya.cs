using System;
using System.Collections.Generic;
public class Store{
	private List<Smartphone> listPhone;
	private string name;
	
	public Store(){
		listPhone = new List<Smartphone>();
	}
	
	public List<Smartphone> ListPhone{
		set { listPhone = value; }
		get { return listPhone; }
	}
	
	public string Name{
		set { name = value; }
		get { return name; }
	}
	
}

public class Program
{
	public static void Main()
	{
		Smartphone ipon = new Smartphone();
		ipon.Name = "Ipon";
		ipon.Rom = 32;
		ipon.Ram = 4;
		//Console.WriteLine("The Price of Smartphone " + ipon.Name + " with ROM " + ipon.Rom + " GB and RAM " + ipon.Ram + " GB is Rp " + ipon.getPrice());
		
		Smartphone samsul = new Smartphone();
		samsul.Name = "Samsul";
		samsul.Rom = 16;
		samsul.Ram = 4;
		//Console.WriteLine("The Price of Smartphone " + samsul.Name + " with ROM " + samsul.Rom + " GB and RAM " + samsul.Ram + " GB is Rp " + samsul.getPrice());
		
		List<Smartphone> listData = new List<Smartphone>();
		
		List<Store> listStore = new List<Store>();
		
		Console.WriteLine("How many Store ? \n");
		string jml_store = Console.ReadLine();
		
		for(int y = 0 ; y< Convert.ToInt16(jml_store); y++){
			
			//Create an Object of Store Class
			Store objStore = new Store();
			
			Console.WriteLine("What is Store Name ? \n");
			objStore.Name = Console.ReadLine();
			
			Console.WriteLine("How many Smartphone ? \n");
			string jml = Console.ReadLine();

			for(int x = 0 ; x< Convert.ToInt16(jml); x++){
				//Create an object of Smartphone
				Smartphone item = new Smartphone();
				Console.WriteLine("Smartphone Name ?");
				item.Name = Console.ReadLine();

				Console.WriteLine("Smartphone ROM ?");
				item.Rom = Convert.ToInt16(Console.ReadLine());
				Console.WriteLine("Smartphone RAM ?");
				item.Ram = Convert.ToInt16(Console.ReadLine());
				
				//Set List to object Store
				objStore.ListPhone.Add(item);
				Console.WriteLine();
			}
			
			listStore.Add(objStore);
		}
		
		
		
		
		
		Console.WriteLine();
		foreach(Store itemStore in listStore){
			Console.WriteLine("This is List Stock from " + itemStore.Name);
			
			foreach(Smartphone item in itemStore.ListPhone){
				Console.WriteLine("The Price of Smartphone " + item.Name + " with ROM " + item.Rom + " GB and RAM " + item.Ram + " GB is Rp " + item.getPrice());
			}
			
			Console.WriteLine();
		}
		
	}
}

public class Smartphone
{
	private string name;
	private int rom;
	private int ram;
	public Smartphone()
	{
	}

	public string Name
	{
		set
		{
			name = value;
		}

		get
		{
			return name;
		}
	}

	public int Rom
	{
		set
		{
			rom = value;
		}

		get
		{
			return rom;
		}
	}

	public int Ram
	{
		set
		{
			ram = value;
		}

		get
		{
			return ram;
		}
	}

	public int getPrice()
	{
		return ram * 150000 + rom * 100000;
	}
} //animal
