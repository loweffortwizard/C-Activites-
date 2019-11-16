/*
	prog will display use of for loops.
	
	The for loop has similar logic to the while loop, but the counter variable and its increment is no part
	of the loops definition:
	
	for("variable to check"; "condition"; "increment the value")
	if true - do this.
*/

//declaring class.
class Program
{
	//declaring main.
	static void Main(string[] args)
	{
		for(int counter = 1; counter <= 10; counter++)
		{
			Console.WriteLine("This is loop number " + counter);
			//print above. 
		}//end of for loop.
	
		Console.ReadKey();
		
	}//end of main. 
}//end of program class.