using System.Text;

namespace КТ3.Models;

public class Questionary
{
    public List<Question> Questions { get; }

    public Questionary(List<Question> questions)
    {
        Questions = questions;
    }

    public String GetQuestionsAndAnswers()
    {
        var sb = new StringBuilder();
        foreach (var question in Questions)
        {
            sb.AppendLine(question.GetQuestionAndAnswer());
        }
        return sb.ToString();
    }
}