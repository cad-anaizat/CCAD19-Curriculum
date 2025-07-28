class CoinToss
{
  static void Main()
  {
    // Create a new instance of the Random class to generate random numbers
    Random coin = new Random();

    // Loop 10 times to simulate 10 coin tosses
    for (int i = 0; i < 10; i++)
    {
      // Generate a random number: 0 or 1
      int flip = coin.Next(0, 2); // 0 means Heads, 1 means Tails

      // Use a ternary operator to decide the result based on the random number
      string result = (flip == 0) ? "Heads" : "Tails";

      // Output the result of the current toss
      Console.WriteLine($"Toss {i + 1}: {result}");
    }
  }
}
