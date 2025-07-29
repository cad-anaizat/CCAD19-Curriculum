// using System;

// /*
// 🔍 Exercise Prompt: ChessBoardPatternMethodWithParameter

// Modify your previous chessboard pattern solution by doing the following:

// 1. Create a **separate method** named `DisplayGrid()` to handle all grid output.
// 2. This method should accept three parameters:
//    - `int size`: the number of rows and columns (square grid)
//    - `char firstChar`: the character to start with on even rows
//    - `char secondChar`: the character to alternate with on odd rows
// 3. Inside the method, use **nested for loops** to print an alternating grid pattern.
// 4. Call the method from `Main()` using sample values: (8, 'X', 'O')

// 🎯 Your output should still look like:
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX
// */

// class ChessBoardPattern_MethodWithParameters
// {
//   static void Main()
//   {
//     // ✅ Step 1: Define the grid configuration
//     int size = 8;           // 8x8 grid (rows and columns)
//     char firstChar = 'X';   // Starting character for even-numbered rows
//     char secondChar = 'O';  // Starting character for odd-numbered rows

//     // ✅ Step 2: Call a method and pass in the grid settings
//     // This separates logic from the main program — a good design practice
//     DisplayGrid(size, firstChar, secondChar);
//   }

//   // ✅ Method: DisplayGrid
//   // Purpose: Generate and print an alternating pattern based on provided characters
//   static void DisplayGrid(int size, char firstChar, char secondChar)
//   {
//     // 🔁 Outer loop: controls each row in the grid
//     for (int row = 0; row < size; row++)
//     {
//       // 🔁 Inner loop: prints each column in the current row
//       for (int col = 0; col < size; col++)
//       {
//         // 🧠 CONTROL STRUCTURE:
//         // Use % (modulus) to determine parity:
//         // - even rows alternate X/O starting with X
//         // - odd rows alternate O/X starting with O

//         if (row % 2 == 0)
//         {
//           // Even row: index 0, 2, 4...
//           Console.Write((col % 2 == 0) ? firstChar : secondChar);
//         }
//         else
//         {
//           // Odd row: index 1, 3, 5...
//           Console.Write((col % 2 == 0) ? secondChar : firstChar);
//         }
//       }

//       // ⬇️ Print a newline after finishing each row
//       Console.WriteLine();
//     }
//   }
// }
