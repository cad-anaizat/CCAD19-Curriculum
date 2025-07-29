// using System;

// /*
// 🔍 Exercise Prompt: ChessBoardPatternPart3 – Object-Oriented with Class & Instance Method

// Refactor your previous chessboard solution to use a reusable class structure:

// 1. Create a class named `Grid` that:
//    - Stores the grid size and alternating characters as public properties
//    - Has a constructor that receives (size, firstChar, secondChar)
//    - Has a method `Display()` that prints the chessboard pattern

// 2. In your Main method:
//    - Instantiate a Grid object using the constructor
//    - Call the object’s `Display()` method to print the pattern

// 🎯 Your output should look like:

// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX
// */

// class ChessBoardPatternObjectInstance
// {
//   static void Main(string[] args)
//   {
//     // ✅ Step 1: Define the grid parameters
//     int size = 8;
//     char firstChar = 'X';
//     char secondChar = 'O';

//     // ✅ Step 2: Create a new Grid object using the constructor
//     // This encapsulates all the grid settings inside one object
//     Grid chessBoard = new Grid(size, firstChar, secondChar);

//     // ✅ Step 3: Call the instance method Display() to output the grid
//     // Since the data lives inside the object, we don’t need to pass any parameters
//     chessBoard.Display();
//   }
// }

// // 🧱 CLASS: Grid
// // Purpose: Encapsulate both grid configuration (data) and logic (behavior)
// class Grid
// {
//   // ✅ Public auto-implemented properties (good for simple data containers)
//   public int Size { get; set; }
//   public char FirstChar { get; set; }
//   public char SecondChar { get; set; }

//   // ✅ Constructor: sets values when a new Grid is created
//   public Grid(int size, char firstChar, char secondChar)
//   {
//     // Assign parameters to the object's public properties
//     Size = size;
//     FirstChar = firstChar;
//     SecondChar = secondChar;
//   }

//   // 🎯 Instance method: Display
//   // Prints the full chessboard pattern based on internal object data
//   public void Display()
//   {
//     // 🔁 Loop through each row
//     for (int row = 0; row < Size; row++)
//     {
//       // 🔁 Loop through each column in that row
//       for (int col = 0; col < Size; col++)
//       {
//         // 🧠 Pattern logic:
//         // Add row + col. If the sum is even, use FirstChar; if odd, use SecondChar.
//         // This one-line parity check replaces multiple conditionals

//         Console.Write((row + col) % 2 == 0 ? FirstChar : SecondChar);
//       }

//       // ⬇️ Move to the next line after printing each row
//       Console.WriteLine();
//     }
//   }
// }
