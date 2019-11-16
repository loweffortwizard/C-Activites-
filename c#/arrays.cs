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

/*
	#array scores = new int with 10 possible values
	int[]scores = new int[10];

	#array scores has value 99 to element 0
	scores[0] = 99;
*/

/*
	make new var called fourth score and assign it
	the value that is in the fourth element of the scores 
	array:
	
	int fourthscore = scores[3]
*/
#array scores = between 10 allocations with the following data. 
int[] scores = new int[10] {100, 95, 98, 80, 75, 72, 68, 61, 59, 55};

#var totalitemsinarray has value of scores array lenght
int totalitemsinarray = scores.Length;

#print results from scores array
Colsole.WriteLine("There are " + totalitemsinarray + "item in the scores array.");

#end console.
Console.ReadKey();

