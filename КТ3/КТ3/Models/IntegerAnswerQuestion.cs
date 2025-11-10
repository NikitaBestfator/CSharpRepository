using System.Text;

namespace КТ3.Models;
/// <summary>
/// Вопрос на дату рождения
/// </summary>
public class IntegerAnswerQuestion : Question
{
    /// <summary>
    /// Дата рождения в ответе
    /// </summary>
    public int Answer {get; set;}
    
    public IntegerAnswerQuestion(string text) 
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