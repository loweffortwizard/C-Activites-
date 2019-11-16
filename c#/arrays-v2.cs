/*
	Arrays.
	
	What is an array?
	An array is a variable type that allows a 
	programmer to group together multiple values of the same
	type in to a single collection.
	
	Why bother with arrays?
	Arrays make programs more efficient, 
	for example, imagine that we wanted to keep track 
	of scores
	in a game using a score board, 
	which keeps track of the top 10 scores. 
	Using the knowledge we have
	so far, we would create 10 integer variables – 
	one for each score:
	
	Arrays start at 0.
	structure:
	
	type[]varname = new type[num];
*/
#array array = new int array with value between {} (9 along)
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

#var currentmin has value of max value for 32 bit.
int currentmin = Int32.MaxValue;

#for each time var index is less then the length of the array
for (int index =0; index < array.Length; index++)
{
	if(array[index] < currentmin)
	{
		currentmin = array[index];
	}//end if
}//end of for loop.

Console.WriteLine("Min value = " + currentmin);

#end console.
Console.ReadKey();

