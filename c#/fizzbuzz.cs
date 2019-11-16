/*
	trying to solve the fizzbuzz program with input
*/

/*
//class for time/pause.
class time{
	static void timewait(int[] args){
		//wait 1 second.
		sleep(1);
		
	}//end timewait
}//end class.
*/

//declaring class.
class Program
{
	//declaring main.
	static void Main(string[] args)
	{
	/*
		//adding nice 'grahpic' 
		for(int row = 1; row < 5; row++)
		{
			for(int column = 0; column < 10; column++)
			{
				Console.Write("*");
			}//end of for loop for column.
			
			Console.Write();
			//print.
			
		}//end of for loop for row.
	*/
	
		//var declaration.
		int inputnumber;
		
		//printing enter input text.
		Console.Write("Enter number: ");
		
		//getting input.
		string inputnumber = Console.Readline();
		
		//converting input from string to int.
		thevalue = Convert.ToInt16(inputnumber);
		
		//add 1 to var thevalue if var thevalue is greater than of equal to 100
		for(thevalue = 1; thevalue <= 100; thevalue++)
		{
			//declaring vars
			int fizz = thevalue % 3;
			int buzz = thevalue % 5;
			
			//determining if input from user is fizz, buzz or fizzbuzz. 
			if(fizz && buzz){
				Console.WriteLine("Fizzbuzz");
			}//end if - fizz and buzz.
			
			else if(fizz){
				Console.WriteLine("Fizz");
			}//end elif - fizz
			
			else if(buzz){
				Console.WriteLine("Buzz");
			}//end elif - buzz
			
			else{
				Console.WriteLine(thevalue);
			}//end else.
				
		}//end of for loop.
		
		Console.ReadKey();
		
	}//end of main. 
}//end of program class.