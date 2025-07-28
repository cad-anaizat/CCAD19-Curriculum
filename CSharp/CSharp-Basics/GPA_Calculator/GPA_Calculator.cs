// GPA_Calculator.cs
// This program calculates the GPA for a student based on their grades and credit hours for five courses.
// It displays the student's name, course details, and the final GPA.

class GPA_Calculator
{
  static void Main()
  {
    // Display program context
    Console.WriteLine("GPA Calculator");
    Console.WriteLine("This program calculates the GPA for a student based on their course grades and credit hours.");
    Console.WriteLine("-------------------------------------------------------------");
    Console.WriteLine();

    //  Step 1: Student and Course Setup
    string studentName = "Sophia Johnson";
    string course1 = "English 101";
    string course2 = "Algebra 101";
    string course3 = "Biology 101";
    string course4 = "Computer Science I";
    string course5 = "Psychology 101";

    //  Step 2: Grades and Credit Hours
    int grade1 = 4, credit1 = 3;
    int grade2 = 3, credit2 = 3;
    int grade3 = 3, credit3 = 4;
    int grade4 = 3, credit4 = 4;
    int grade5 = 4, credit5 = 3;

    //  Step 3: Total Points and Credits
    int totalPoints = (grade1 * credit1) + (grade2 * credit2) + (grade3 * credit3)
                    + (grade4 * credit4) + (grade5 * credit5);
    int totalCredits = credit1 + credit2 + credit3 + credit4 + credit5;

    //  Step 4: GPA Calculation
    float finalGPA = (float)totalPoints / totalCredits;

    //  Step 5: Formatted Console Output
    Console.WriteLine($"Student: {studentName}");
    Console.WriteLine();
    Console.WriteLine($"{"Course",-25} {"Grade",8} {"Credit Hours",15}");
    Console.WriteLine($"{course1,-25} {grade1,8} {credit1,15}");
    Console.WriteLine($"{course2,-25} {grade2,8} {credit2,15}");
    Console.WriteLine($"{course3,-25} {grade3,8} {credit3,15}");
    Console.WriteLine($"{course4,-25} {grade4,8} {credit4,15}");
    Console.WriteLine($"{course5,-25} {grade5,8} {credit5,15}");
    Console.WriteLine();
    Console.WriteLine($"Final GPA: {finalGPA:F2}");
  }
}




