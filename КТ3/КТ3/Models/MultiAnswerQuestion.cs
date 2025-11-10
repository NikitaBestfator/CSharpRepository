using System.Text;

namespace КТ3.Models;
/// <summary>
/// Вопрос с несколькими правильными ответами
/// </summary>
public class MultiAnswerQuestion : Question
{
    
    /// <summary>
    /// Список ответов
    /// </summary>
    public IReadOnlyList<string> Answers { get; }
    
    
    /// <summary>
    /// Список индексов ответов
    /// </summary>
    public List<int> AnswersIndexes { get; set; }

    public MultiAnswerQuestion(string text, List<string> answers) : base(text)
    {
        Answers = answers;
    }

    override public string GetQuestionAndAnswer()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.GetQuestionAndAnswer());
        sb.AppendLine("Answers:");
        var counter = 1;
        foreach (var answerIndex in AnswersIndexes)
        {
            sb.AppendLine($"{counter++, 4}. {Answers[answerIndex]}");
        }
        return sb.ToString();
    }
}