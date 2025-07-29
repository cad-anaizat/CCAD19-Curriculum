// using System;

// /*
// FizzBuzz Challenge using for statements

// This challenge builds your understanding of:
// ✔️ for loops  
// ✔️ if statements  
// ✔️ the % remainder (modulus) operator  
// ✔️ logical condition evaluation

// 📜 Task Instructions:
// • Output numbers 1 through 100 (inclusive), one per line
// • When a number is divisible by 3, print "Fizz" next to it
// • When a number is divisible by 5, print "Buzz" next to it
// • When a number is divisible by BOTH 3 and 5, print "FizzBuzz" next to it

// 🎯 Example Output:
// 1  
// 2  
// 3 Fizz  
// 4  
// 5 Buzz  
// 6 Fizz  
// ...  
// 15 FizzBuzz  
// ...
// */

// class FizzBuzz_ForLoopChallenge
// {
//   static void Main(string[] args)
//   {

//     // ✅ Step 1: Loop through numbers 1 to 100 using a for loop
//     for (int i = 1; i <= 100; i++)
//     {
//       // ✅ Step 2: Initialize a result string for this number
//       string result = "";

//       // ✅ Step 3: Check divisibility by 3 and append "Fizz" if true
//       if (i % 3 == 0)
//       {
//         result += "Fizz";
//       }

//       // ✅ Step 4: Check divisibility by 5 and append "Buzz" if true
//       if (i % 5 == 0)
//       {
//         result += "Buzz";
//       }

//       // ✅ Step 5: Display the number and result
//       // If result is empty, print the number alone

//       // If 'result' is still empty, that means 'i' is not divisible by 3 or 5.
//       if (result == "")
//       {
//         Console.WriteLine(i); // Just print the number itself.
//       }
//       else
//       {
//         // If 'result' has "Fizz", "Buzz", or "FizzBuzz", print it next to the number.
//         Console.WriteLine($"{i} {result}");
//       }
//     }
//   }
// }

