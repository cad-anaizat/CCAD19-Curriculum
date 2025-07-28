class TernaryOperatorDemo
{
  static void Main()
  {
    int score = 85;

    // Basic pass/fail check
    // The ternary operator checks if score is at least 60.
    // If true, passFail is "Passed"; otherwise, it's "Failed".
    string passFail = (score >= 60) ? "Passed" : "Failed";
    Console.WriteLine($"Score of {score} is {passFail}");

    // Nested ternary for letter grade
    // First, checks if score > 90: if so, grade is "A".
    // If not, checks if score > 80: if so, grade is "B".
    // Otherwise, grade is "C".
    string grade = (score > 90) ? "A" : (score > 80) ? "B" : "C";
    Console.WriteLine($"Grade: {grade}");

    // Method example: return max of two numbers
    // Calls the Max method, which uses a ternary operator to return the larger value.
    Console.WriteLine($"Max of 8 and 10 is: {Max(8, 10)}");
  }

  // Returns the greater of two integers using the ternary operator.
  static int Max(int a, int b) => (a > b) ? a : b;
}
