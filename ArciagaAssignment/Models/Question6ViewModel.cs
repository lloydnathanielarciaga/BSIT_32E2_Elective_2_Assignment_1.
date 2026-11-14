namespace ArciagaAssignment.Models
{
    public class Question6ViewModel
    {
        public int CurrentQuestionNumber { get; } = 6;
        public string Question { get; set; } = "6. Which of the following endpoint URIs follows RESTful resource-oriented naming best practices?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) GET /api/getAllCourses[3]",  // Index 0
        "B) GET /api/courses[3]", // Index 1
        "C) POST /api/createNewCourseRecord[3]",  // Index 2
        "D) POST /api/deleteCourseById?id=5[3]"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question5";
        public string NextController => "Question7";
    }
}
