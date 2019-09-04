using System;
using System.Collections.Generic;

class Store {
	private string name;
	
	public string Name {
		set { name = value; } 
		get { return name; }
	}	
}

class Smartphone {
	private string name;
	private int rom;
	private int ram;
	private string toko;
	
	public string Name {
		set { name = value;}
		get { return name;}
	}	
	public int Rom {
		set { rom = value;}
		get { return rom;}
	}	
	public int Ram {
		set { ram = value;}
		get { return ram;}
	}
	public string Toko {
		set { toko = value;}
		get { return toko;}
	}
	public int getPrice(){
		rom = rom * 100000; //int price_rom
		ram = ram * 150000; // int price_rom
		//int sum = ram + rom;
		return rom+ram;
	}	
}
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How Many Store?");
		int store =Convert.ToInt32(Console.ReadLine()) ;
		List<Store> listStore = new List<Store>();  //[]
		List<Smartphone> listPhone = new List<Smartphone>(); //[]
		
		for(int i=0; i<store; i++){
			Console.WriteLine("What is store Name?");
			string store_name = Console.ReadLine();
			
			Store stores = new Store();
			stores.Name = store_name;
			listStore.Add(stores); 
			
			Console.WriteLine("How Many Smartphone?");
			int phone =Convert.ToInt32(Console.ReadLine());
			
			for(int j=0; j<phone; j++){
				Console.WriteLine("Smartphone Name?");
				string phone_name = Console.ReadLine();
				Console.WriteLine("Smartphone Rom?");
				int phone_rom = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Smartphone Ram?");
				int phone_ram = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();
				
				Smartphone samsul= new Smartphone();
				samsul.Name = phone_name;
				samsul.Rom = phone_rom;  
				samsul.Ram = phone_ram;
				samsul.Toko = store_name;
				listPhone.Add(samsul);
			}
		}
		
		foreach(Store toko in listStore){ 
			Console.WriteLine("This is List Stock From " + toko.Name );
			foreach(Smartphone phone in listPhone){ 
				if(toko.Name == phone.Toko){
					Console.WriteLine("The Price of Smartphone " + phone.Name + " with ROM " + phone.Rom + "GB and RAM " + phone.Ram + "GB is Rp " + phone.getPrice());
				}
			}
			Console.WriteLine();
		}
	}
}
		
		
		

		
		