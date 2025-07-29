// using System;

// /*
// 🔍 Exercise Prompt: ForLoopPart1 – Countdown with Early Exit

// 1. Use a `for` loop to iterate from 0 up to a defined end value.
// 2. Increment by 4 each time (i += 4).
// 3. Inside the loop, check if the value of the loop counter reaches 8.
// 4. If it does, use the `break` statement to exit the loop immediately.
// 5. Print each value of `i` before exiting (as long as it's not 8).

// 🎯 Expected Output:
// 0  
// 4
// */

// class ForLoopEarlyExitCondition
// {
//   static void Main(string[] args)
//   {
//     // ✅ Step 1: Define the maximum value the loop could reach
//     int endValue = 12;

//     // ✅ Step 2: Start a for loop from 0 to endValue (inclusive), incrementing by 4
//     for (int i = 0; i <= endValue; i += 4)
//     {
//       // 🔁 Values of i during loop: 0, 4, 8, 12

//       // ✅ Step 3: Add a condition to exit the loop early
//       // If i equals 8, stop the loop using 'break'
//       if (i == 8)
//       {
//         break; // 🛑 Exit loop when condition is met
//       }

//       // 🖨️ Step 4: Display the current value of i
//       Console.WriteLine(i);
//     }

//     // ✅ After loop exits, program continues here
//   }
// }
