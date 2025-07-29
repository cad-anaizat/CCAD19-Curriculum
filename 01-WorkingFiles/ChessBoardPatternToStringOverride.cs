// using System;

// /*
// 🔍 Exercise Prompt: ChessBoardPatternToStringOverride

// 1. Create a class named `Grid` that accepts:
//    - An `int size`
//    - A `char firstChar`
//    - A `char secondChar`

// 2. Override the built-in `.ToString()` method so that:
//    - It returns the chessboard pattern as a string
//    - It replaces the default "Namespace.ClassName" behavior

// 3. In your `Main()` method:
//    - Instantiate a `Grid` object
//    - Print it using both `.ToString()` and `Console.WriteLine(object)`
//    - BONUS: Add a method called `ToBase()` that uses `base.ToString()` to call the original object-level version (for debugging)

// 🎯 Output should still look like:
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX  
// XOXOXOXO  
// OXOXOXOX
// */

// class ChessBoardPattern_ToStringOverride
// {
//   static void Main(string[] args)
//   {
//     // 🟢 Step 1: Define grid configuration
//     int size = 8;
//     char firstChar = 'X';
//     char secondChar = 'O';

//     // 🧱 Step 2: Create an instance of Grid using constructor
//     Grid chessBoard = new Grid(size, firstChar, secondChar);

//     // 🖨️ Step 3: Use overridden ToString() to get chessboard pattern
//     string string1 = chessBoard.ToString();
//     Console.WriteLine("👉 Overridden ToString() Output:");
//     Console.WriteLine(string1);

//     // 🔁 Step 4: Show that Console.WriteLine(object) auto-calls ToString()
//     Console.WriteLine("👉 Console.WriteLine(chessBoard) uses ToString() automatically:");
//     Console.WriteLine(chessBoard); // Same as chessBoard.ToString()

//     // 🧪 Step 5: Call the base version of ToString() using custom method
//     string original = chessBoard.ToBase(); // Calls object.ToString() via base
//     Console.WriteLine("👉 Base object.ToString():");
//     Console.WriteLine(original); // Will print: Namespace.Grid
//   }
// }

// // 🧱 Grid class: holds settings and logic for rendering a chessboard
// class Grid
// {
//   // ✅ Auto-properties store object state
//   public int Size { get; set; }
//   public char FirstChar { get; set; }
//   public char SecondChar { get; set; }

//   // ✅ Constructor sets up values at object creation
//   public Grid(int size, char firstChar, char secondChar)
//   {
//     Size = size;
//     FirstChar = firstChar;
//     SecondChar = secondChar;
//   }

//   // ✅ OVERRIDE: Customize how this object prints by redefining ToString()
//   public override string ToString()
//   {
//     string result = ""; // 🏗️ Start with an empty string

//     // 🔁 Loop through each row
//     for (int row = 0; row < Size; row++)
//     {
//       // 🔁 Loop through each column in that row
//       for (int col = 0; col < Size; col++)
//       {
//         // 🧠 Shortcut logic: (row + col) % 2 alternates the pattern
//         result += ((row + col) % 2 == 0) ? FirstChar : SecondChar;
//       }

//       result += "\n"; // 🔄 Add a line break after each row
//     }

//     return result; // ✅ Final string of the chessboard pattern
//   }

//   // 🧪 BONUS: Call base class's original ToString() method
//   public string ToBase()
//   {
//     return base.ToString(); // Returns e.g., "Namespace.Grid"
//   }
// }
