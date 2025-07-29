// using System;
// /*
// Perform the following tasks to examine implementation of the for statement:

// 1. Declare a string[] array containing several animal names
//    (e.g., "Fox", "Deer", "Wolf", "Bear").

// 2. Use a for loop to print the names in reverse order.

// 3. Modify a value in the array:
//    - Inside a for loop, check if any name equals "Wolf".
//    - If so, change it to "Pack Leader".

// 4. After the update, use a foreach loop to print all names in the array.
// */

// // 🎯 This program reinforces foundational array operations using a realistic scenario:
// // - Declaring arrays
// // - Iterating in reverse with a for loop
// // - Searching and modifying elements
// // - Printing with foreach

// class AnimalArrayReverseAndReplace
// {
//   static void Main()
//   {
//     // ✅ STEP 1: Declare and initialize a string array
//     // An array is a fixed-size collection. Each value is accessed by index.
//     // In this example, we store names of animals.
//     string[] animals = { "Fox", "Deer", "Wolf", "Bear" };

//     // ✅ STEP 2: Print the array in reverse order using a for loop
//     Console.WriteLine("🔁 Animal names in reverse order:");

//     // Looping from the last index to the first (i--)
//     // animals.Length gives total number of items (4)
//     // Last valid index is Length - 1 (i.e., 3)
//     for (int i = animals.Length - 1; i >= 0; i--)
//     {
//       // We use bracket notation to access each element by its index
//       Console.WriteLine(animals[i]);
//     }

//     // ✅ STEP 3: Search for the name "Wolf" and replace it
//     // We use a traditional for loop because:
//     // 1. We need access to the element's index
//     // 2. We'll be modifying the array in place (not just reading it)
//     for (int i = 0; i < animals.Length; i++)
//     {
//       // String comparison is case-sensitive.
//       // .Equals() is preferred over == for clarity and reliability.
//       if (animals[i].Equals("Wolf"))
//       {
//         // Reassign the current index to the new value.
//         animals[i] = "Pack Leader";
//       }
//     }

//     // ✅ STEP 4: Display the updated array using a foreach loop
//     Console.WriteLine("\n🦊 Updated animal list:");

//     // foreach is ideal when:
//     // - You want to read every value
//     // - You don’t need to modify the original data
//     foreach (string animal in animals)
//     {
//       // animal is a *read-only copy* of each element during iteration
//       Console.WriteLine(animal);
//     }
//   }
// }
