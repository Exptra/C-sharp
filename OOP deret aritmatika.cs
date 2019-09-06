using System;

public class Math
{
	private int jumlah_angka;
	
	public int JumlahAngka{
		set { jumlah_angka = value; }
		get { return jumlah_angka; }
	}
	
	public void Hitung(){
		for(int i = 1 ; i<= this.jumlah_angka ;i++){
			Console.Write(i + (i-1) + " ");
		}
		
	}
	
	public void Hitung2(){
		for(int i = 1 ; i<= this.jumlah_angka ;i++){
			//Bilangan ganjil
			if(i % 2 == 1){
				//Console.Write((i / 2));
				Console.Write((((i / 2) + 1) * 3) + " ");
			}
			else{
				Console.Write((((i / 2) + 1) * 2) + " ");
			}
		}
		
	}
	
}
					
public class Program
{
	public static void Main()
	{
		Math obj_math = new Math();
		
		Console.WriteLine("Input X Number ");
		obj_math.JumlahAngka = Convert.ToInt16(Console.ReadLine());
		obj_math.Hitung2();
		
	}
}
























