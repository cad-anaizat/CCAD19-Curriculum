public class Menu
{
  // This method displays the menu item based on the provided itemCode.
  public void ShowMenuItem(int itemCode)
  {
    // Use a switch statement to handle different item codes.
    switch (itemCode)
    {
      case 0:
      case 2:
        // If itemCode is 0 or 2, print "Pizza".
        Console.WriteLine("Pizza");
        break;
      case 1:
        // If itemCode is 1, print "Burger".
        Console.WriteLine("Burger");
        break;
      case 3:
        // If itemCode is 3, print "Soda".
        Console.WriteLine("Soda");
        break;
      default:
        // For any other itemCode, print "Unknown item".
        Console.WriteLine("Unknown item");
        break;
    }
  }
}

class Program
{
  static void Main()
  {
    Menu menu = new Menu(); // Create a new Menu object.
    menu.ShowMenuItem(0); // Calls ShowMenuItem with 0, should print "Pizza".
    menu.ShowMenuItem(1); // Calls ShowMenuItem with 1, should print "Burger".
    menu.ShowMenuItem(4); // Calls ShowMenuItem with 4, should print "Unknown item".
  }
}
