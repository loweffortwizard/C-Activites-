/*
	prog will count down.
	it will skip number 5.
*/

//importing libs
#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

//creating sleep def
int sleep(){
    sleep(1);  
    return 0;
}//end of sleep

//creating main def
int main(){
	
	std::cout<<"Begin prog"<<std::endl;
	//print above.
	sleep();
	//sleep for 1 sec
			
	int count = 0;
	//var count has value of 0
	
	//do add 1 while condition is ture.
	do{
		count += 1;
		//adding 1 to count
		
		//end loop if var count is greater than 10
		if(count > 10){
			break;
		}//end of (count > 10) if
		
		//skipping num 5
		if(count == 5){
			continue;
			//skipping
			sleep();
			//sleep for 1 sec
		}//end of (count == 5) if
		
		std::cout<<count<<std::endl;
		//print count value.
		sleep();
		//sleep for 1 sec
	}while(true);
	//end of loop.
	
	std::cout<<"End of prog"<<std::endl;
	//print above.
	
	return 0;
	//return 0.
}//end of main.

//end of prog.