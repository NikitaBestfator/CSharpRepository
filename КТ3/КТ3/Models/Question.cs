namespace КТ3.Models;

public abstract class Question
{
    public string Text{ get; }
    protected Question(string text)
    {
        Text = text;
    }

    public virtual string GetQuestionAndAnswer()
    {
        return $"Q: {Text}";
    }
}