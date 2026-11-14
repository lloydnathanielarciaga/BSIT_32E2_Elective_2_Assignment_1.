namespace ArciagaAssignment.Models
{
    public class Question2ViewModel
    {
        public int CurrentQuestionNumber { get; } = 2;
        public string Question { get; set; } = "2. Why do Web API controllers in ASP.NET Core inherit from ControllerBase instead of Controller ?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) ControllerBase supports Razor View rendering using View() and ViewData[2].",  // Index 0
        "B) ControllerBase provides essential HTTP handling and routing without carrying unnecessary HTML view rendering overhead[1][2].", // Index 1
        "C) Controller is obsolete in .NET 8 and cannot handle HTTP POST requests[1].",  // Index 2
        "D) ControllerBase automatically creates SQLite database files on application startup[2]."  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question1";
        public string NextController => "Question3";
    }
}
