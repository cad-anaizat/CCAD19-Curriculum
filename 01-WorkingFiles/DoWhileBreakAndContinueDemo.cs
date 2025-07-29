// using System; // 📦 Imports the System namespace, giving access to Console and other basic utilities

// /*
// 🔍 Exercise: Understanding `break` and `continue` inside do-while loops

// 🧠 Learning Goals:
// - Understand how `break` stops a loop early
// - Understand how `continue` skips the **current iteration** and jumps to the next one
// - Practice modifying control flow in loops

// 🎯 What You’ll See:
// - First loop ends early using `break` when `i == 3`
// - Second loop skips over `i == 3` using `continue`
// */

// class DoWhileBreakAndContinueDemo
// {
//   static void Main(string[] args)
//   {
//     // ✅ First Example: Using `break` to EXIT the loop early
//     int i = 0;

//     do
//     {
//       i++; // 🔢 Increment i before doing anything else

//       if (i == 3)
//         break; // 🛑 Stop the loop entirely once i reaches 3

//       // ✅ This line only runs when i != 3
//       Console.WriteLine($"Break loop: {i}");

//     } while (i < 5); // 🔁 Loop condition: Keep looping while i < 5

//     /*
//     🧪 Output for First Loop:
//     Break loop: 1  
//     Break loop: 2  
//     // Loop ends when i == 3 due to break
//     */


//     // ✅ Second Example: Using `continue` to SKIP one iteration
//     i = 0;

//     do
//     {
//       i++; // 🔢 Increment i before doing anything

//       if (i == 3)
//         continue; // ⏭️ Skip the rest of this loop when i == 3

//       // ✅ This line runs for every i EXCEPT 3
//       Console.WriteLine($"Continue loop: {i}");

//     } while (i < 5); // 🔁 Continue looping while i < 5

//     /*
//     🧪 Output for Second Loop:
//     Continue loop: 1  
//     Continue loop: 2  
//     // Skips 3 entirely
//     Continue loop: 4  
//     Continue loop: 5
//     */

//   }
// }
