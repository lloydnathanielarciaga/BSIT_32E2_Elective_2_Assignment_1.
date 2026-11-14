namespace ArciagaAssignment.Models
{
    public class Question1ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "1. What is the fundamental difference between Server-Side Rendering (SSR/MVC) and a Decoupled Web API architecture?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A) SSR returns JSON payloads, whereas a Web API compiles .cshtml Razor views on the server[1].",  // Index 0
        "B) SSR compiles HTML views on the server and sends fully rendered markup to the browser, whereas a Web API acts as a stateless data provider returning raw JSON[1].", // Index 1
        "C) SSR only works with mobile applications, whereas Web APIs are restricted to desktop web browsers[1].",  // Index 2
        "D) SSR requires client-side routing in React, whereas Web APIs manage HTML layouts directly on the server[1]."  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question8";
        public string NextController => "Question2";
    }
}
