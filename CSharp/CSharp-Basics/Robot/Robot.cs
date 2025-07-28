public class Robot
{
  private string model;
  private int batteryLevel;
  private static int totalActivated = 0;

  // Property (read-only access to model name)
  public string Model => model;

  // Constructor
  public Robot(string model, int batteryLevel)
  {
    this.model = model;
    this.batteryLevel = batteryLevel;
    totalActivated++;
  }

  // Recharge instance method
  public void Recharge(int amount)
  {
    batteryLevel = Math.Min(batteryLevel + amount, 100);
    Console.WriteLine($"{model}'s battery level is now {batteryLevel}");
  }

  // Returns true if battery is low
  public bool NeedsRecharge()
  {
    return batteryLevel < 20;
  }

  // Static method: total number of robots created
  public static int GetTotalActivated()
  {
    return totalActivated;
  }

  // Static validation method
  public static bool IsModelAllowed(string model)
  {
    string upperModel = model.ToUpper();
    return upperModel.StartsWith("RX") && upperModel.Length >= 5;
  }
}

class Program
{
  static void Main(string[] args)
  {
    string modelName = "RX9000";

    if (Robot.IsModelAllowed(modelName))
    {
      Robot robot = new Robot(modelName, 19);

      if (robot.NeedsRecharge())
      {
        robot.Recharge(50);
      }

      Console.WriteLine($"Total robots activated: {Robot.GetTotalActivated()}");
    }
    else
    {
      Console.WriteLine($"Model {modelName} not allowed.");
    }
  }
}
