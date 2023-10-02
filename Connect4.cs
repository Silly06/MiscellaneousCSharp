using System;

class Connect4
{
	static void Main(string[] args)
	{
		//declares the variables that are the lists that contain the data
		char[] row1 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row2 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row3 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row4 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row5 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row6 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		char[] row7 = new char[7] {'-', '-', '-', '-', '-', '-', '-'};
		
		char[][] rows = new char[][] {row1, row2, row3, row4, row5, row6, row7};
		
		Console.WriteLine("Play by inputting a number from 1-7, each number correlating to each column.");

		//starts the game, each loop is one turn.
		char playerTurn = 'X';
		while(true){
			//prints the board by iterating through each row in the list "rows"
			for(int selectedRowIndex = 0; selectedRowIndex <= 6; selectedRowIndex++){
				//iterates through the characters in each row, seperating it by 2 spaces
				for (int selectedColumnIndex = 0; selectedColumnIndex <= 6; selectedColumnIndex++){
					Console.Write(rows[selectedRowIndex][selectedColumnIndex] + "  ");
				}
				Console.WriteLine("");
			}
			Console.WriteLine("");
			//takes user input for which column to fill
			Console.WriteLine("Input a column");
			string inputPhrase = Console.ReadLine();
			int inputColumn;
			bool success = Int32.TryParse(inputPhrase, out inputColumn);
			//checks if the input reads stop, and if so, it ends code.
			if(inputPhrase == "stop"){
				return;
			//iterates through each row, and checks the value at the requested column, and sets it to a value if it is blank
			}
			if(success && inputColumn < 8 && inputColumn > 0){
				inputColumn = inputColumn - 1;
				for (int rowToCheck = 6; rowToCheck >= 0; rowToCheck--){
					if(rows[rowToCheck][inputColumn] == '-'){
						rows[rowToCheck][inputColumn] = playerTurn;
						break;
					}
				}
				//switches turn over to other player
				if(playerTurn == 'X'){
					playerTurn = 'O';
				}
				else{
					playerTurn = 'X';
				}
			}
			else{
				Console.WriteLine("Not a valid column");
			}
		}
	}
}