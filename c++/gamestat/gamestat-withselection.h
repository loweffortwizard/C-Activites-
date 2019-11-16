/*
	program will determain score of the game.
	
	Notes (for math op:
		addition: +=
		subtraction: -=
		multiplication: *=
		division: /=
		modulus (remainder): %=
*/

//allow input and output though terminal.
#include<iostream>
//use standered dictinary. 
using namespace std;
#include <stdlib.h> 
#include <stdio.h>
#include <time.h>
#include <unistd.h>

int main(){
	//main will run game -- aim to get high score.
	
	//declaring unsigned int (.
	unsigned int score = 5000;
	std::cout<<"Score: "<<score<<std::endl;
	sleep(1);
	
	//altering the value of score.
	score = score + 100;//score equals itself + 100 (combine op).
	std::cout<<"Score: "<<score<<std::endl;
	sleep(1); 
	
	//combined operator.
	score += 100;//score equals itself + 100 (combine op).
	std::cout<<"Score: "<<score<<std::endl;
	sleep(1);
	
	//incrementing operators
	int lives = 3;
	++lives;//op will 
	std::cout<<"Lives: "<<lives<<std::endl;
	sleep(1);
	
	//
	lives = 3;
	lives++;//op will 
	std::cout<<"Lives: "<<lives<<std::endl;
	sleep(1);
	
	lives = 3;
	int bonus = ++lives * 10;
	std::cout<<"Lives, Bonus: "<<lives<<","<<bonus<<std::endl;
	sleep(1);
	
	if(bonus > 30){
		std::cout<<"Bonus more than 30."<<std::endl;
	}
	sleep(1);
	
	lives = 3;
	bonus = lives++ * 10;
	std::cout<<"Lives, Bonus: "<<lives<<","<<bonus<<std::endl;
	sleep(1);
	
	if(bonus <= 30){
		std::cout<<"Bonus less than 40."<<std::endl;
	}
	sleep(1);

	//int wrap around
	score = 4294967295;
	std::cout<<"Score: "<<score<<std::endl;
	++score;
	std::cout<<"Score: "<<score<<std::endl;
	
	//end game line.
	std::cout<<"End of game"<<std::endl;
	sleep(1);
	
	return 0;
	//return 0.
}//end of main.