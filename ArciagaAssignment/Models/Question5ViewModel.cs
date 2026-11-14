namespace ArciagaAssignment.Models
{
    public class Question5ViewModel
    {
        public int CurrentQuestionNumber { get; } = 3;
        public string Question { get; set; } = "5. When a DELETE request successfully removes a resource from the server and returns no content in the response body, which HTTP status code is standard?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) 200 OK[3]",  // Index 0
        "B) 201 Created[3]", // Index 1
        "C) 204 No Content[3]",  // Index 2
        "D) 400 Bad Request[3]"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question4";
        public string NextController => "Question6";
    }
}
