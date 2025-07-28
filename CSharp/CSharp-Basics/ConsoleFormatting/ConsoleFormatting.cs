class Program
{
  static void Main(string[] args)
  {
    string studentName = "Sophia Johnson";

    // Sample course data
    string[] courses = { "English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101" };
    int[] grades = { 4, 3, 3, 3, 4 };
    int[] credits = { 3, 3, 4, 4, 3 };

    // Calculate GPA
    int totalPoints = 0;
    int totalCredits = 0;

    for (int i = 0; i < courses.Length; i++)
    {
      totalPoints += grades[i] * credits[i];
      totalCredits += credits[i];
    }

    float gpa = (float)totalPoints / totalCredits;

    // Output formatting
    Console.WriteLine($"Student: {studentName}\n");
    Console.WriteLine("{0,-25} {1,8} {2,13}", "Course", "Grade", "Credit Hours");
    for (int i = 0; i < courses.Length; i++)
    {
      Console.WriteLine("{0,-25} {1,8} {2,13}", courses[i], grades[i], credits[i]);
    }

    Console.WriteLine($"\nFinal GPA: {gpa:F2}");
  }
}
