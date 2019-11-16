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

int main(){
	//main will run game -- aim to get high score.
	
	//declaring unsigned int (.
	unsigned int score = 5000;
	std::cout<<"Score: "<<score<<std::endl;
	
	//altering the value of score.
	score = score + 100;//score equals itself + 100 (combine op).
	std::cout<<"Score: "<<score<<std::endl;
	
	//combined operator.
	score += 100;//score equals itself + 100 (combine op).
	std::cout<<"Score: "<<score<<std::endl;
	
	//incrementing operators
	int lives = 3;
	++lives;//op will 
	std::cout<<"Lives: "<<lives<<std::endl;
	
	//
	lives = 3;
	lives++;//op will 
	std::cout<<"Lives: "<<lives<<std::endl;
	
	lives = 3;
	int bonus = ++lives * 10;
	std::cout<<"Lives, Bonus: "<<lives<<","<<bonus<<std::endl;
	
	lives = 3;
	bonus = lives++ * 10;
	std::cout<<"Lives, Bonus: "<<lives<<","<<bonus<<std::endl;
	
	if(bonus < 30){
		std::cout<<"Score more than 30."<<std::endl;
	}
	
	//int wrap around
	score = 4294967295;
	std::cout<<"Score: "<<score<<std::endl;
	++score;
	std::cout<<"Score: "<<score<<std::endl;
	
	//end game line.
	std::cout<<"End of game"<<std::endl;
	
	return 0;
	//return 0.
}//end of main.