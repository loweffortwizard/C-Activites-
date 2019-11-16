/*
	program will be a score rater.
	will also demonstrate the if statment.
*/

#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

int main()
{
	if(true){
		std::cout<<"This is always displayed.\n\n"<<std::endl;
		sleep(1);
	}//end of ture if
	
	if(false){
		std::cout<<"this will never display.\n\n"<<std::endl;
		sleep(1);
	}//end of false if
	
	int score = 1000;
	
	if(score){
		std::cout<<"At least not 0.\n\n"<<std::endl;
		sleep(1);
	}//end of score if
	
	if(score>=250){
		std::cout<<"Decent.\n\n"<<std::endl;
		sleep(1);
	}//end of score >= 250 if
	
	if(score>=500){
		std::cout<<"Nice.\n\n"<<std::endl;
		sleep(1);
		
		if(score>=1000){
			std::cout<<"Impressive.\n\n"<<std::endl;
			sleep(1);
		}//end of score >= 1000 if
		
	}//end of score >= 500 if
	
	return 0;	
}//end of main.