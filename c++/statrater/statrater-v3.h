/*
	prog will rate score and use else-if clause.
*/

#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

int main(){
	int score;
	//var score.
	std::cout<<"Enter your score: "<<std::endl;
	sleep(1);
	cin>>score;
	
	if(score >= 1000){
		std::cout<<"\n\nImpressive.\n\n"<<std::endl;
		sleep(1);
		main();
	}//end if
	
	else if(score >= 500){
		std::cout<<"\n\nNice.\n\n"<<std::endl;
		sleep(1);
		main();
	}//end else if
	
	else if(score >= 250){
		std::cout<<"\n\nDecent.\n\n"<<std::endl;
		sleep(1);
		main();
	}//end else if
	
	else{
		std::cout<<"\n\nCrap.\n\n"<<std::endl;
		sleep(1);
		main();
	}//end of else
	
	return 0;
}//end of main.