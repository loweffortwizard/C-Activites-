/*
	prog will grade based on score.
*/

class Program
{
	static void Main(string[] args)
	{
		int score;
		//declare var score as int.
		
		Console.Write("Enter score: ");
		//print above.
		
		string scoreastext = Console.Readline();
		//getting input, saving in var scoreastext - text.
		
		score = Convert.ToInt32(scoreastext);
		//converting scoreastext to int and saving in var score.
		
		//if score is equal to 100.
		if (score == 100)
			Console.WriteLine("Perfect score for ", score);
			//print above.
		
		//if score >= 90.
		if (score >= 90)
			Console.WriteLine("A");
		
		//else if score >= 80.
		else if (score >= 80)
			Console.WriteLine("B");
		
		//else if score >= 70.
		else if (score >= 70)
			Console.WriteLine("C");
		
		//else if score >= 60.
		else if (score >= 60)
			Console.WriteLine("D");
		
		//default for none of the above. 
		else
			Console.WriteLine("U");
		
		Console.ReadKey();
		
	}//end of main
}//end of class