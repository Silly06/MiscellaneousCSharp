using System;

public class TicTacToe
{
	public static void Main(string[] args){
		//declares the variable that is the list that contains the data
		char[] grid = new char[9] {'-', '-', '-', '-', '-', '-', '-', '-', '-'};


		
		Console.WriteLine("Play by inputting a number from 1-7, each number correlating to each column.");

		//starts the game, each loop is one turn.
		char playerTurn = 'X';
		bool running = true; 
		int timesIterated = 0;
		while(running){
			//prints the board by iterating through each row in the list "rows"
			printGrid(grid);
			}
			
			Console.WriteLine("");
			//takes user input for which column to fill
			Console.WriteLine("Input the selected tile");
			string inputPhrase = Console.ReadLine();
			int inputNumber;
			bool success = Int32.TryParse(inputPhrase, out inputNumber);
			//checks if the input reads stop, and if so, it ends code.
			if(inputPhrase == "stop"){
				running = false;
			}
			if(success && inputNumber < 10 && inputNumber > 0 && grid[inputNumber - 1] == '-'){
				grid[inputNumber - 1] = playerTurn;
				//switches turn over to other player
				if(playerTurn == 'X'){
					playerTurn = 'O';
				}
				else{
					playerTurn = 'X';
				}
				timesIterated ++;
			}
			else{
				Console.WriteLine("Not a valid grid space");
			}
			
		}
	}
	public static class PrintGrid(char[] grid){
		for (int row = 0; row < 3; row++){
			for (int column = 0; column < 3; column++){
				Console.Write(grid[row * 3 + column] + " ");
			}
			Console.WriteLine("");
		}
		
	}
}