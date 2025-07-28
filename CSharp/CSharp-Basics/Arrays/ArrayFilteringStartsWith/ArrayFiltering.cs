using System;

class ArrayFiltering
{
  static void Main()
  {
    // Array of sample order IDs
    string[] orderIDs = { "A123", "B456", "B789", "C101" };

    Console.WriteLine("Filtered Order IDs (starting with 'B'):");

    // The foreach loop is used to traverse each element in the array.
    // For each orderID, we check if it starts with 'B' using String.StartsWith.
    // If the condition is true, we print the orderID.
    // Loop through each orderID in the orderIDs array
    foreach (string orderID in orderIDs)
    {
      // Check if the orderID starts with 'B'
      if (orderID.StartsWith("B"))
      {
        // Print the orderID if it matches the condition
        Console.WriteLine(orderID);
      }
    }
  }
}
