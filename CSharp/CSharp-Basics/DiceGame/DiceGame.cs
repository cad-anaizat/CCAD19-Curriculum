using System;

// This program simulates a simple dice game.
// It demonstrates the use of random number generation, conditional branching, logical comparison operators, and bonus score logic.

class DiceGame
{
  static void Main()
  {
    // Create a new Random object to simulate dice rolls.
    // The Random.Next(minValue, maxValue) method returns a random integer greater than or equal to minValue and less than maxValue.
    // Here, dice.Next(1, 7) simulates rolling a six-sided die, producing values from 1 to 6.
    Random dice = new Random();

    int roll1 = dice.Next(1, 7);
    int roll2 = dice.Next(1, 7);
    int roll3 = dice.Next(1, 7);

    int total = roll1 + roll2 + roll3;

    Console.WriteLine($"Dice rolls: {roll1}, {roll2}, {roll3}");
    Console.WriteLine($"Total score: {total}");

    // Conditional branching is used to provide feedback based on the total score.
    // The 'if', 'else if', and 'else' statements allow the program to execute different code blocks depending on the value of 'total'.
    // Logical comparison operators (like >= and <) are used to compare values.
    if (total >= 15)
      Console.WriteLine("High score!");
    else if (total < 6)
      Console.WriteLine("Low score.");

    // Bonus logic: Logical comparison and operators are used to check for doubles or triples.
    // If all three dice have the same value (triple), a larger bonus is awarded.
    // If any two dice have the same value (double), a smaller bonus is awarded.
    // The '==' operator checks for equality, and the '||' operator means "or".
    if (roll1 == roll2 && roll2 == roll3)
    {
      total += 6; // Triple bonus
      Console.WriteLine("Triple bonus!");
    }
    else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
    {
      total += 2; // Double bonus
      Console.WriteLine("Double bonus!");
    }

    // Output the final score after any bonuses have been applied.
    Console.WriteLine($"Final score: {total}");
  }
}