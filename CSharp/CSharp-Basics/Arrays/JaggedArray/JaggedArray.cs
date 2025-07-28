// Define a class to process student scores
class StudentScores
{
  // Entry point of the program
  static void Main()
  {
    // Array of student names
    string[] studentNames = { "Sophia", "Emma", "Logan" };

    // Jagged array: each student's scores (first 5 are exams, rest are extra credit)
    // In int[][], the first index represents the row (student), the second index represents the column (score).
    // A jagged array differs from a 2D array because each row can have a different number of columns (lengths can vary).
    int[][] studentScores = {
        new int[] { 85, 86, 87, 88, 89, 3, 2 },   // Sophia: 5 exams, 2 extra
        new int[] { 78, 79, 80, 81, 82, 5, 5 },   // Emma: 5 exams, 2 extra
        new int[] { 91, 92, 93, 94, 95, 4, 4 }    // Logan: 5 exams, 2 extra
      };

    // Print table header with column formatting
    Console.WriteLine("{0,-10} {1,8} {2,10} {3,12} {4,8}", "Name", "Exam", "Extra", "Combined", "Grade");

    // Loop through each student
    for (int s = 0; s < studentNames.Length; s++)
    {
      string name = studentNames[s];      // Current student's name
      int[] scores = studentScores[s];    // Current student's scores

      int examSum = 0;                    // Sum of exam scores
      int extraSum = 0;                   // Sum of extra credit scores
      int examCount = 5;                  // Number of exams
      int extraCount = scores.Length - examCount; // Number of extra credit scores

      // Loop through scores to separate exam and extra credit
      for (int i = 0; i < scores.Length; i++)
      {
        if (i < examCount)
          examSum += scores[i];           // Add to exam sum
        else
          extraSum += scores[i];          // Add to extra credit sum
      }

      // Calculate averages
      decimal examAvg = (decimal)examSum / examCount; // Average exam score
      decimal extraAvg = (extraCount > 0) ? (decimal)extraSum / extraCount : 0; // Average extra credit

      // Combine exam and extra credit (extra credit is scaled down)
      decimal combinedScore = examAvg + (extraAvg / 10);

      // Get letter grade based on combined score
      string letterGrade = GetLetterGrade(combinedScore);

      // Print student results with formatting
      Console.WriteLine("{0,-10} {1,8:F2} {2,10:F2} {3,12:F2} {4,8}", name, examAvg, extraAvg, combinedScore, letterGrade);
    }
  }

  // Returns letter grade based on score
  static string GetLetterGrade(decimal score)
  {
    if (score >= 90) return "A";
    else if (score >= 80) return "B";
    else if (score >= 70) return "C";
    else if (score >= 60) return "D";
    else return "F";
  }
}
