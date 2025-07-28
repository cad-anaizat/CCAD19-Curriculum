class ArrayIterationSum
{
  static void Main()
  {
    // Declare and initialize an array of integers
    int[] items = { 10, 20, 30, 40 };
    int sum = 0;         // Variable to hold the running total
    int binNumber = 1;   // Used to label each bin/item

    // foreach loop: Used to iterate over each element in a collection (like an array)
    // It automatically goes through all elements, assigning each one to 'item' in turn.
    Console.WriteLine("📦 Using foreach loop to calculate running total:");
    foreach (int item in items)
    {
      sum += item; // Add current item to running total
      Console.WriteLine($"Bin {binNumber}: Running total is {sum}");
      binNumber++;
    }

    Console.WriteLine($"Final sum: {sum}");
    Console.WriteLine();

    // for loop: Used when you need to use the index of each element.
    // It has three parts: initialization (int i = 0), condition (i < items.Length), and increment (i++)
    // items.Length gives the number of elements in the array.
    Console.WriteLine("🔢 Using for loop to print each item:");
    for (int i = 0; i < items.Length; i++)
    {
      // Access array elements by index
      Console.WriteLine($"Item {i}: {items[i]}");
    }
  }
}
