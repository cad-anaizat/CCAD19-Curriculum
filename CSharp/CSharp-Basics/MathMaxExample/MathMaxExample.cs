using System;

/// <summary>
/// The <c>CSharpBasics</c> namespace contains basic C# programming examples.
/// </summary>
/// <remarks>
/// In this example, the <see cref="Math.Max"/> method is used to determine the larger of two integers.
/// <para>
/// <see cref="Math.Max"/> is an overloaded method, meaning it has multiple versions that accept different types of arguments,
/// such as <c>int</c>, <c>double</c>, <c>decimal</c>, etc. The appropriate overload is selected by the compiler based on the argument types provided.
/// </para>
/// </remarks>
namespace CSharpBasics
{
  /// <summary>
  /// Demonstrates how to use <see cref="Math.Max"/> to find the larger of two numbers.
  /// </summary>
  class MathMaxExample
  {
    /// <summary>
    /// The entry point of the program.
    /// </summary>
    static void Main()
    {
      int firstNumber = 10;
      int secondNumber = 20;

      // Using static method Math.Max to compare
      int larger = Math.Max(firstNumber, secondNumber);

      Console.WriteLine($"The larger number is {larger}");
    }
  }
}

