/*
	prog will display use of nested for loops.
	
	The for loop has similar logic to the while loop, but the counter variable and its increment is no part
	of the loops definition:
	
	for("variable to check"; "condition"; "increment the value")
	if true - do this.


	all below should print * ten times across and 
	5 rows down. 
*/

//declaring class.
class Program
{
	//declaring main.
	static void Main(string[] args)
	{
		for(int row = 1; row < 5; row++)
		{
			for(int column = 0; column < 10; column++)
			{
				Console.Write("*");
			}//end of for loop for column.
			
			Console.Write();
			//print.
			
		}//end of for loop for row.
	
		Console.ReadKey();
		
	}//end of main. 
}//end of program class.