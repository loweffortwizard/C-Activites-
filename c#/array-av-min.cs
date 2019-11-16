#array array = new int array with value between {} (9 along)
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

#Declaring vars
#var total = 0
int total = 0;
#var currentmin has value of max value for 32 bit.
int min = Int32.MaxValue;

#for each time var index is less then the length of the array
for (int index =0; index < array.Length; index++)
{
	if(array[index] < min)
	{
		#var min = index no in array
		min = array[index];
		
		#var total = array[index] + array[index]
		total += array[index]
	
	}//end if
}//end of for loop.

#var av has floating point value of total divided by array.length
float av = (float)total / array.Length;

#print below
Console.WriteLine("Min value = " + min);
Console.WriteLine("Av value = " + av);

#end console.
Console.ReadKey();