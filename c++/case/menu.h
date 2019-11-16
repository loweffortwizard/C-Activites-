/*
	prog will allow user to choose difficulty
	with switch statments.
*/

#include<iostream>
//input and output
using namespace std;
//standerd lib
#include <unistd.h>
//time function

int main(){
	
	std::cout<<"Choose your difficulty.\n\n"<<std::endl;
	sleep(1);
	std::cout<<"1 - Easy\n"<<std::endl;
	sleep(1);
	std::cout<<"2 - Normal\n"<<std::endl;
	sleep(1);
	std::cout<<"3 - Hard\n"<<std::endl;
	sleep(1);
	std::cout<<"4 - Insane\n"<<std::endl;
	sleep(1);
	std::cout<<"5 - Nightmare\n"<<std::endl;
	sleep(1);
	
	int choice;
	std::cout<<"Choice: "<<std::endl;
	cin>>choice;
	
	switch(choice){
		case 1:
			std::cout<<"You picked easy... wimp.\n"<<std::endl;
			main();
			sleep(1);
			break;//end of 1
		case 2:
			std::cout<<"You picked normal.\n"<<std::endl;
			main();
			sleep(1);
			break;//end of 2
		case 3:
			std::cout<<"You picked hard. A challenge is what you seek ah?\n"<<std::endl;
			main();
			sleep(1);
			break;//end of 3
		case 4:
			std::cout<<"You picked insane. Ultimate Gamer.\n"<<std::endl;
			main();
			sleep(1);
			break;//end of 4
		case 5:
			std::cout<<"You picked nightmare. Trying to compensate?\n"<<std::endl;
			main();
			sleep(1);
			break;//end of 5
		default:
			std::cout<<"Pick again:\n\n 1 - Easy\n2 - Normal\n3 - Hard\n4 - Insane\n5 - Nightmare\n"<<std::endl;
			sleep(1);
	}//end of switch
	
	return 0;
}//end of main.