/*
	program will ask user to play again.
	will also show while loops.
	
	NOTES:
	While loop does not run (only if condition is true)
	
	
	Notes:
	While Loops And Do Loops Can Be Used Interchangeable And The Choice Of Which To Use Is Usually Down To
	The Choice/Preference Of The Programmer. In Most Profressional Programs, You Will See The While Loop
	Being Used, Unless There Is A Need To Run The Code Of A Loop At Least Once. Most Developers Prefer The
	While Loop As The Condtion Is At The Top Of The Code And So It Is Clear To See What The Test Condition
	Acutally Is.
*/

//importing libs
#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

int sleep(){
    sleep(1);  
    return 0;
}//end of sleep

int main(){
	char again = 'y';
	//var again has value of y
	
	std::cout<<"Prog begin"<<std::endl;
	sleep();
	
	//loop for while again is equal to y
	while(again =='y'){
		std::cout<<"\n**Play the worlds best game**"<<std::endl;
		//print above.
		sleep();
		std::cout<<"\n*Do you want to play? (y/n): "<<std::endl;
		//print above. 
		sleep();
		cin>>again;
		//getting input - storing in var again.
	}//end of while.
	
	std::cout<<"\nOkay, bye boi."<<std::endl;
	//print above.
	sleep();
	
	return 0;
	//return value 0 to int main.
}//end of main.
//end of prog