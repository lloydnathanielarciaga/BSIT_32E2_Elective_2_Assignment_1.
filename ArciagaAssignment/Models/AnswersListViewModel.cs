namespace ArciagaAssignment.Models
{
    public class AnswersListViewModel
    {
        public Dictionary<int, string> CorrectAnswers { get; set; } = new Dictionary<int, string>
        {
            { 1, "B" }, { 2, "B" }, { 3, "C" }, { 4, "B" }, { 5, "C" },
            { 6, "B" }, { 7, "B" }, { 8, "C" }
        };
    }
}
