/*
	prog will display use of compound statements. 
	
	Remember that an if statement is checking to see if a condition is true:
		all == when using && all conditions must be true for the if statement to run
		or == when using || only one condition needs to be true for the if statement to run

*/

//declaring program class.
class Program
{
	//declaring main.
	static void Main(string[] args)
	{
		//declaring vars age and colour
		int age = 51;
		string colour = "Blue";
		
		//if state with compound.
		if ((age > 50) || (colour = "Blue"))
		{
			Console.WriteLine("You are over 50 and like blue. ");
			//print above.
		}//end of if.
		
		//default for compound
		else
		{
			Console.WriteLine("Not over 50 or like blue.");
			//print above. 
		}//end of else.
		
		Console.ReadKey();
		
	}//end of main.
	
}//end of program class.