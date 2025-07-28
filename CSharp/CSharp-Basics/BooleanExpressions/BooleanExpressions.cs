// This program demonstrates basic boolean expressions and logic in C#.
// It covers equality, inequality, string comparison (case-insensitive), logical negation, and if-else branching.
//
// Boolean expressions are statements that evaluate to either true or false.
// They are commonly used in decision-making structures like if-else statements.
//
// String comparisons can be made case-insensitive by converting both strings to the same case (e.g., using ToUpper()).
//
// The if-else statement allows you to execute different code blocks based on the result of a boolean expression.

class BooleanExpressions
{
  static void Main()
  {
    int x = 10;

    // Check if x equals 10 (equality)
    bool is10 = (x == 10);
    Console.WriteLine($"x == 10? {is10}"); // True

    // String comparison with case normalization (case-insensitive)
    string input = "Yes";
    bool saidYes = (input.ToUpper() == "YES");
    Console.WriteLine($"User said yes? {saidYes}"); // True

    // Boolean logic with negation and if-else branching
    bool isLoggedIn = false;

    if (!isLoggedIn)
    {
      Console.WriteLine("User is not logged in.");
    }
    else
    {
      Console.WriteLine("User is logged in.");
    }

    // Inequality example
    bool isNot5 = (x != 5);
    Console.WriteLine($"x != 5? {isNot5}"); // True
  }
}
