// /*
// 🔍 Exercise: Create do and while iteration loops (2/3)

// 🧠 Challenge Summary:
// Write a program that uses a `do-while` loop to randomly generate numbers between 1 and 20, and keep looping **until the number 13 is generated**.

// ✅ Why do-while?
// - You don’t know how many iterations it will take.
// - You want the loop to run at least once, no matter what.
// - The stop condition depends on logic **inside the loop body**.

// 📝 Steps:
// 1. Declare a `Random` object.
// 2. Create an `int` variable to store the current number.
// 3. Use a `do-while` loop to:
//    - Generate a number between 1 and 20 (inclusive).
//    - Print the number to the console.
// 4. Continue looping **until** the number 13 is produced.
// */
// using System;

// class DoWhile_RandomUntil13
// {
//   static void Main(string[] args)
//   {
//     // ✅ Step 1: Create a Random object to generate random numbers
//     Random rng = new Random();

//     // ✅ Step 2: Declare a variable to hold the random number
//     int currentNumber;

//     // ✅ Step 3: Begin the do-while loop
//     do
//     {
//       // 🎲 Generate a random number between 1 and 20 (inclusive)
//       currentNumber = rng.Next(1, 21); // Upper bound is exclusive, so we use 21

//       // 🖨️ Print the result to console
//       Console.WriteLine($"Generated number: {currentNumber}");

//     } while (currentNumber != 13); // ✅ Step 4: Loop stops when we hit 13
//   }
// }

