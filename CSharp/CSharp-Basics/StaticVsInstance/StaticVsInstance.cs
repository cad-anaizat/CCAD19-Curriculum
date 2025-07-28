// This program demonstrates the difference between static and instance methods in C#,
// as well as method overloading. The Printer class defines three overloaded Print methods.
// The Program class shows usage of both static and instance methods, including built-in
// .NET methods and custom methods.
//
// Key concepts:
// - Static methods (e.g., Console.WriteLine) belong to the class itself and are called on the class.
// - Instance methods (e.g., Random.Next) belong to an object and are called on an instance.
// - Method overloading allows multiple methods with the same name but different parameter types or counts.
// - A method signature consists of the method name and the types (and order) of its parameters.

class Printer
{
  // Method overload 1 - no parameters
  // Signature: Print()
  public void Print()
  {
    Console.WriteLine("Nothing to print");
  }

  // Method overload 2 - one parameter
  // Signature: Print(string)
  public void Print(string message)
  {
    Console.WriteLine($"Printing: {message}");
  }

  // Method overload 3 - two parameters
  // Signature: Print(string, string)
  public void Print(string message1, string message2)
  {
    Console.WriteLine($"Multiple print: {message1} and {message2}");
  }
}

class Program
{
  static void Main()
  {
    // Instance method example with Random
    // Random.Next is an instance method: it must be called on a Random object (dice).
    // Its signature is Next(int minValue, int maxValue).
    Random dice = new Random();
    int number = dice.Next(1, 6); // Method overload with (min, max)
    Console.WriteLine($"Random number: {number}");

    // Static method example
    // Console.WriteLine is a static method: it is called on the Console class itself.
    // Its signature can be WriteLine(string value), among others.
    Console.WriteLine("This is a static method (Console.WriteLine)");

    // Custom instance method usage
    // Printer.Print demonstrates method overloading: same method name, different signatures.
    Printer p = new Printer();
    p.Print();                            // Overload 1: Print()
    p.Print("Hello");                     // Overload 2: Print(string)
    p.Print("Hello", "World");            // Overload 3: Print(string, string)
  }
}
