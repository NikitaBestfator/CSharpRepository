using System.Text;

namespace КТ3.Models;

/// <summary>
/// Вопрос с единственным правильным выбором
/// </summary>
public class SingleAnswerQuestion : Question
{
    /// <summary>
    /// Список ответов
    /// </summary>
    public IReadOnlyList<string> Answers { get; }

    /// <summary>
    /// Индекс правильного ответа
    /// </summary>
    public int AnswerIndex { get; set; } = -1;

    public SingleAnswerQuestion(string text, List<string> answers)
        : base(text)
    {
        Answers = answers;
    }

    override public string GetQuestionAndAnswer()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.GetQuestionAndAnswer());
        sb.AppendLine($"A: {Answers[AnswerIndex]}");
        return sb.ToString();
    }
}