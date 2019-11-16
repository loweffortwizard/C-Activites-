/*
	trying to solve the fizzbuzz program.
*/

//declaring class.
class Program
{
    //declaring main.
    static void fizzbuzz(string[] args)
    {
        //add 1 to var thevalue if var thevalue is greater than of equal to 100
        for (int thevalue = 1; thevalue <= 100; thevalue++)
        {
            //declaring & defining vars fizz and buzz
            bool fizz == thevalue % 3; bool buzz == thevalue % 5;

            //determining if number is fizz, buzz or fizzbuzz. 
            if (fizz && buzz){Console.WriteLine("Fizzbuzz");}//end if - fizz and buzz.
            else
            {switch(thevalue):case = fizz;Console.WriteLine("Fizz.");break;
					case = buzz;Console.WriteLine("Buzz.");break;
					default Console.WriteLine(thevalue); break;
            }//end else.

        }//end of for loop.

        Console.ReadKey();
        //wait to end prog.

    }//end of main. 
}//end of program class.