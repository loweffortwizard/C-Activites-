/*
	prog will demonstrate switch statments.
	Note: Switch do not check logic in conditions. 
	
	Switch statements work in a similar fashion to if/else if/else statements. There are research papers
	that say that switch statements are more efficient, but for this to be relevant the program would
	need to be substantial in size. The key factor in deciding whether to use an if/else block or a switch
	statement really comes down to which is most readable. 
*/

class Program
{
	static void Main(string[] args)
	{
		//var declaration.
		int menuchoice;
		
		//printing menu
		Console.Write("Please choose and option: \n" +
			"1 - Coke.\n" +
			"2 - Sprite. \n" +
			"3 - Dr Pepper. \n4 - 7up\n5 - Tango\n");
		
		//getting input.
		string menuchoiceastext = Console.Readline();
		
		//converting input from string to int.
		menuchoice = Convert.ToInt16(menuchoiceastext);
		
		//switch to determine menu choice. 
		switch(menuchoice)
		{
			case 1:
				Console.WriteLine("Choose option 1.");
				break;
			case 2:
				Console.WriteLine("Choose option 2.");
				break;
			case 3:
				Console.WriteLine("Choose option 3.");
				break;
			case 4:
				Console.WriteLine("Choose option 4.");
				break;
			case 5:
				Console.WriteLine("Choose option 5.");
				break;
			default:
				Console.WriteLine("Not an option.");
				break;
		}//end of switch.
		
		Console.ReadKey();
		
	}//end of main.
	
}//end of program class.