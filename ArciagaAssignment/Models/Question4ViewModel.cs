namespace ArciagaAssignment.Models
{
    public class Question4ViewModel
    {
        public int CurrentQuestionNumber { get; } = 3;
        public string Question { get; set; } = "4. Which HTTP status code should an API return after successfully creating a new resource via a POST request, along with a Location header pointing to the new URI?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) 200 OK[3]",  // Index 0
        "B) 201 Created[1][3]", // Index 1
        "C) 204 No Content[3]",  // Index 2
        "D) 404 Not Found[3]"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question3";
        public string NextController => "Question5";
    }
}
