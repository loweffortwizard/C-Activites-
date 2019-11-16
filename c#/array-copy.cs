/*
	prog will be one array from 1 to 10.
	and another array that copies from the original array.
*/

#creating original array.
int[] originalarray = new int[10]{0, 1 ,2, 3, 4, 5, 6, 7, 8, 9};

int[] newarray = new int[10];

for(int index = 0; originalarray.Length > newarray.Length; index++)
{	
	#copying value
	newarray = originalarray[index];
	
}//end of for

#print below
Console.WriteLine("Array 1:\n" + originalarray);

#print below
Console.WriteLine("Array 2:\n" + newarray);