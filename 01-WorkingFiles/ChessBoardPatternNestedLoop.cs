// using System;

// /*
// 🔍 Exercise Prompt: ChessBoardPatternNestedLoop

// Perform the following steps to practice nested for loops and decision structures:

// 1. Use nested loops to create an 8x8 grid pattern.
// 2. Alternate each row's starting character between 'X' and 'O'.
// 3. Use a decision structure (if/else) to ensure each row starts with the opposite character of the one before it — just like a real chessboard.
// 4. Print the characters using Console.Write or Console.WriteLine as appropriate.

// 🎯 Output should look like:

// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX
// */

// class ChessBoardPattern_NestedLoop
// {
//   static void Main()
//   {
//     // ✅ Outer loop controls the rows (8 total)
//     for (int row = 0; row < 8; row++)
//     {
//       // ✅ Inner loop controls the columns within the current row
//       for (int col = 0; col < 8; col++)
//       {
//         // 🧠 Key Concept: (row % 2) determines if the row is even or odd
//         // Even-numbered rows (0, 2, 4...) start with 'X'
//         // Odd-numbered rows (1, 3, 5...) start with 'O'

//         if (row % 2 == 0)
//         {
//           // ✅ Even row logic: alternate X and O starting with 'X'
//           Console.Write(col % 2 == 0 ? "X" : "O");
//         }
//         else
//         {
//           // ✅ Odd row logic: alternate O and X starting with 'O'
//           Console.Write(col % 2 == 0 ? "O" : "X");
//         }
//       }

//       // ✅ Move to the next line after each row is complete
//       Console.WriteLine();
//     }
//   }
// }
