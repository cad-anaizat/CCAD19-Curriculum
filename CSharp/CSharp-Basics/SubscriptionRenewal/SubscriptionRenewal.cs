using System;

class SubscriptionRenewal
{
  static void Main()
  {
    // Create a Random object to generate random numbers
    Random random = new Random();

    // Generate a random number between 0 and 11 to simulate days until subscription expiration
    int daysUntilExpiration = random.Next(0, 12);

    // Initialize discountPercentage to 0; will be updated based on conditions
    int discountPercentage = 0;

    // Display the randomly generated days until expiration
    Console.WriteLine($"Days until expiration: {daysUntilExpiration}");

    // The following if-else chain checks the value of daysUntilExpiration
    // and prioritizes conditions from most urgent (expired) to least urgent (expiring soon)
    if (daysUntilExpiration == 0)
    {
      // Subscription has already expired
      Console.WriteLine("Your subscription has expired.");
    }
    else if (daysUntilExpiration == 1)
    {
      // Subscription expires today; highest discount offered
      discountPercentage = 20; // Assign 20% discount
      Console.WriteLine("Your subscription expires today; renew now and save 20%.");
    }
    else if (daysUntilExpiration <= 5)
    {
      // Subscription will expire within 2-5 days; smaller discount offered
      discountPercentage = 10; // Assign 10% discount
      Console.WriteLine($"Your subscription will expire in {daysUntilExpiration} days.");
      Console.WriteLine($"Renew now and save {discountPercentage}%.");
    }
    else if (daysUntilExpiration <= 10)
    {
      // Subscription will expire soon (6-10 days); no discount
      Console.WriteLine("Your subscription will expire soon. Renew now!");
    }
    else
    {
      // No message for more than 10 days until expiration
    }
  }
}
