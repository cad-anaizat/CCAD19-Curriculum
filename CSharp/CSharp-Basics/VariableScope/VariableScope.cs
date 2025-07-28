using System;

class VariableScope
{
  // Entry point of the program
  static void Main()
  {
    int outer = 10; // 'outer' is declared in Main's scope and accessible throughout Main

    // Start of an inner block
    {
      int inner = 20; // 'inner' is declared in this block and only accessible inside this block
      Console.WriteLine($"Outer: {outer}");  // ✅ Valid: 'outer' is accessible here
      Console.WriteLine($"Inner: {inner}");  // ✅ Valid: 'inner' is accessible here
    }
    // End of inner block

    // Console.WriteLine(inner); ❌ Error: 'inner' is out of scope here, as it was declared in the inner block

    int number = 10; // This 'number' variable is local to Main
    DoSomething(); // Calls the method below
    Console.WriteLine($"Number in Main: {number}"); // Outputs 10, because 'number' in DoSomething is a different variable
  }

  // A separate method with its own local scope
  static void DoSomething()
  {
    int number = 20; // This 'number' is local to DoSomething and does not affect 'number' in Main
    Console.WriteLine($"Number in DoSomething: {number}"); // Outputs 20
  }
}
