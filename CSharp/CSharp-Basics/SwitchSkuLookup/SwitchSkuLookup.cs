using System;

class Program
{
  static void Main()
  {
    // Declare and initialize the SKU variable. Try changing this value to test different cases.
    string sku = "SW"; // Try changing this value
    string description;

    // Use a switch statement to determine the product description based on the SKU.
    switch (sku)
    {
      case "TS":
        // If sku is "TS", set description to "T-Shirt"
        description = "T-Shirt";
        break;
      case "SW":
        // If sku is "SW", set description to "Sweatshirt"
        description = "Sweatshirt";
        break;
      case "MG":
        // If sku is "MG", set description to "Mug"
        description = "Mug";
        break;
      default:
        // If sku doesn't match any case, set description to "Unknown Product"
        description = "Unknown Product";
        break;
    }

    // Output the SKU and its corresponding description
    Console.WriteLine($"SKU: {sku} => {description}");
  }
}
