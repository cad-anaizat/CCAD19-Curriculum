using System;

class Panda
{
  public string Name;
  public int Age;

  public static int TotalPandas = 0;

  // Constructor: Initializes name and age, and increments static counter
  public Panda(string name, int age)
  {
    this.Name = name;
    this.Age = age;
    TotalPandas++;
  }

  // Instance method
  public void CelebrateBirthday()
  {
    Age++;
    Console.WriteLine($"{Name} is now {Age} years old.");
  }

  // Static method
  public static int GetTotalPandas()
  {
    return TotalPandas;
  }
}

class Program
{
  static void Main(string[] args)
  {
    // Create two Panda objects with names and ages
    Panda frank = new Panda("Frank", 4);
    Panda wendy = new Panda("Wendy", 7);

    // Celebrate Frank's birthday
    frank.CelebrateBirthday();

    // Output the total number of Panda objects created
    Console.WriteLine($"Total Pandas: {Panda.GetTotalPandas()}");
  }
}
