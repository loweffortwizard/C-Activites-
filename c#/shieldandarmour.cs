/*
	prog will determain shield and armour left.
*/

//declaring program class
class Program
{
	//declaring main
	static void Main(string[] args)
	{
		//declaring vars shield and armour.
		int shield = 20;
		int armour = 5;
		
		if (shield <= 0)
		{
			if (armour <= 0)
			{
				Console.WriteLine("Shields and armour gone. ");
				//print above.
			}//end nested if.
			
			else
			{
				Console.WriteLine("Shields gone, armour on. ");
			}//end of nested else.
			
		}//end of shield <= 0
		
		else{
			Console.WriteLine("Both shield and armour are fine. ");
		}//end of else for shield <= 0.
		
		Console.ReadKey();
		
	}//end of main.
	
}//end of class.