/*
	program will determain score of the game.
*/

#include<iostream>
using namespace std;

int main(){
	//main will run game -- aim to get high score.
	
	//declaring local vars.
	int score;
	double distance;
	char playAgain;
	bool shieldsUp;
	short lives, aliensKilled;
	
	//assigning LV values.
	score = 0;
	distance = 1200.76;
	playAgain = 'y';
	shieldsUp = true;
	lives = 3;
	aliensKilled = 10;
	double engineTemp = 6572.89;
	
	//main prog -- print out below:
	std::cout<<"\nScore: "<<score<<std::endl;
	std::cout<<"Distance: "<<distance<<std::endl;
	std::cout<<"Play again: "<<playAgain<<std::endl;
	std::cout<<"Lives: "<<lives<<std::endl;
	std::cout<<"Aliens Killed: "<<aliensKilled<<std::endl;
	std::cout<<"Engine Temp: "<<engineTemp<<std::endl;
	
	//getting user input.
	int fuel;
	//create fuel int.
	std::cout<<"\nHow much fuel? "<<std::endl;
	//print above.
	
    cin >> fuel;
	//get input for how much fuel.
	
	std::cout<<"Fuel: "<<fuel<<std::endl;
	
	//using unassigned short for generating bonus.
	typedef unsigned short int ushort;
	ushort bonus = 10;
	std::cout<<"\nBonus "<<bonus<<std::endl;
	
	std::cout<<"End of game"<<std::endl;
	
	return 0;
	//return 0.
}//end of main.