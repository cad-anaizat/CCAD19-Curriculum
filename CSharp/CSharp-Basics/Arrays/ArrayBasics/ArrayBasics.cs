using System;

// This program demonstrates basic array operations in C#
class ArrayBasics
{
  static void Main()
  {
    // Arrays are fixed-size collections of elements of the same type.
    // Here, we create an array of strings with 3 elements.
    string[] animals = new string[3];

    // Array indexing starts at 0. So, valid indices for this array are 0, 1, and 2.
    animals[0] = "cat";   // Assign "cat" to the first element (index 0)
    animals[1] = "dog";   // Assign "dog" to the second element (index 1)
    animals[2] = "wolf";  // Assign "wolf" to the third element (index 2)

    // The Length property returns the number of elements in the array.
    Console.WriteLine($"Array length: {animals.Length}");

    // You can access and update array elements using their index.
    // Here, we display the original value at index 1, then update it.
    Console.WriteLine($"Original second animal: {animals[1]}");
    animals[1] = "fox"; // Reassign value at index 1 from "dog" to "fox"
    Console.WriteLine($"Updated second animal: {animals[1]}");

    // Attempting to access or assign a value to an invalid index (outside 0-2) causes an IndexOutOfRangeException.
    // Here, we try to assign a value at index 3, which does not exist in this array.
    try
    {
      animals[3] = "tiger"; // This will throw IndexOutOfRangeException
    }
    catch (IndexOutOfRangeException ex)
    {
      Console.WriteLine("Error: Tried to access an index outside the array bounds.");
      Console.WriteLine($"Exception Message: {ex.Message}");
    }
  }
}
