int studentGradeLevel = 2; // Set the student's grade level (1-4)
string studentName = "Alex"; // Student's name
string gradeDescription = ""; // Will hold the description based on grade level

// Use a switch statement to map grade level to a description
switch (studentGradeLevel)
{
  case 1: // If grade level is 1
  case 2: // Or if grade level is 2
    gradeDescription = "Lower Division"; // Assign "Lower Division"
    break; // Exit the switch after assigning
  case 3: // If grade level is 3
    gradeDescription = "Junior"; // Assign "Junior"
    break;
  case 4: // If grade level is 4
    gradeDescription = "Senior"; // Assign "Senior"
    break;
  default: // For any other value
    gradeDescription = "Unknown Grade Level"; // Assign default message
    break;
}

// Output the result using string interpolation
Console.WriteLine($"{studentName} is a {gradeDescription}");
