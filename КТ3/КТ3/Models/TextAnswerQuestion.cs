using System.Text;

namespace КТ3.Models;

/// <summary>
/// Вопрос с текстовым ответом
/// </summary>
public class TextAnswerQuestion : Question
{
    /// <summary>
    /// Текстовый ответ на вопрос
    /// </summary>
    public string Answer { get; set; } = "";
    
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="text">Текст вопроса</param>
    public TextAnswerQuestion(string text)
        : base(text)
    {
    }

    override public string GetQuestionAndAnswer()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.GetQuestionAndAnswer());
        sb.AppendLine($"A: {Answer}");
        return sb.ToString();
    }
}