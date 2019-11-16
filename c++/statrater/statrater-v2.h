/*
	prog will rate score and use else clause.
*/

#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

int main(){
	
	int score;
	std::cout<<"Enter your score.\n\n"<<std::endl;
	cin>>score;
	
	if(score>=1000){
		std::cout<<"\n\nYou scored 1000 or more. Impressive."<<std::endl;
		sleep(1);
	}//end of if
	
	else{
		std::cout<<"\n\nYou scored less than 1000."<<std::endl;
		sleep(1);
	}//end of else
	
	return 0;
}//end of main