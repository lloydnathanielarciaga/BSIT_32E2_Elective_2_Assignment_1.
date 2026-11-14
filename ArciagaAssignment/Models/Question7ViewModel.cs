namespace ArciagaAssignment.Models
{
    public class Question7ViewModel
    {
        public int CurrentQuestionNumber { get; } = 7;
        public string Question { get; set; } = "7. What is the primary function of the [Route(\"api/[controller]\")] attribute in ASP.NET Core?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) It connects the controller directly to an Entity Framework database context[2].",  // Index 0
        "B) It maps incoming URI request paths to the controller class using the class name token[1][2].", // Index 1
        "C) It encrypts all incoming JSON payloads[2].",  // Index 2
        "D) It enables Cross-Origin Resource Sharing (CORS) for external React apps[2]."  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question6";
        public string NextController => "Question8";
    }
}
