
class ChessBoardPattern
{
  static void Main()
  {
    int gridSize = 8; // The size of the chessboard (8x8)

    // Outer loop: iterates over each row of the chessboard
    for (int row = 0; row < gridSize; row++)
    {
      // Inner loop: iterates over each column in the current row
      for (int col = 0; col < gridSize; col++)
      {
        // The sum of row and col determines the pattern.
        // If (row + col) is even, print 'X'; if odd, print 'O'.
        // This alternates the characters to create the chessboard pattern.
        char cell = ((row + col) % 2 == 0) ? 'X' : 'O';

        // Print the character followed by a space, so the board is spaced out
        Console.Write($"{cell} ");
      }
      // After finishing a row, move to the next line to start a new row
      Console.WriteLine();
    }
  }
}
