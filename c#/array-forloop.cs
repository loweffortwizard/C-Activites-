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
#array scores = between 10 allocations with the following data. 
int[] scores = new int[10] {100, 95, 98, 80, 75, 72, 68, 61, 59, 55};

#for every time index is less than scores length, do this.
for(int index = 0; index < scores.Length; index++)
{
	#var score has value of score in index for loop
	int score = score[index];
	
	#print index and score
	Console.WriteLine("Score #" + index + ": " + score);
}//end for

#end console.
Console.ReadKey();