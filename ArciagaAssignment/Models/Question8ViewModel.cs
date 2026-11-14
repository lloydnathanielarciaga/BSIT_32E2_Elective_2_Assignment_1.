namespace ArciagaAssignment.Models
{
    public class Question8ViewModel
    {
        public int CurrentQuestionNumber { get; } = 8;
        public string Question { get; set; } = "8. Which HTTP verb is safe and idempotent, intended exclusively for retrieving resource data without altering server state?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) POST[3]",  // Index 0
        "B) PUT[3]", // Index 1
        "C) GET[1][3]",  // Index 2
        "D) DELETE[3]"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question7";
        public string NextController => "Question1";
    }
}
