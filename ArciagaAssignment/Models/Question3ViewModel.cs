namespace ArciagaAssignment.Models
{
    public class Question3ViewModel
    {
        public int CurrentQuestionNumber { get; } = 3;
        public string Question { get; set; } = "3. Which framework attribute automatically triggers an HTTP 400 Bad Request response when incoming request payloads fail structural model validation?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) [Route][2]",  // Index 0
        "B) [HttpGet][3]", // Index 1
        "C) [ApiController][1][2]",  // Index 2
        "D) [FromQuery][2]"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question2";
        public string NextController => "Question4";
    }
}
