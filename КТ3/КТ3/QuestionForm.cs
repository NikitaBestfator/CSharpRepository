using КТ3.Models;

namespace КТ3;

public partial class QuestionForm : Form
{
    private readonly Question _question;

    public QuestionForm(Question question)
    {
        InitializeComponent();

        _question = question;

        questionLabel.Text = _question.Text;

        switch (_question)
        {
            case SingleAnswerQuestion singleAnswersQuestion:
                var top = 0;
                foreach (var answer in singleAnswersQuestion.Answers)
                {
                    var rb = new RadioButton
                    {
                        Top = top,
                        Text = answer
                    };
                    controlsPanel.Controls.Add(rb);
                    top += rb.Height + 5;
                }

                break;
        }
    }

    private void saveButton_Click(object sender, EventArgs e)
    {
        switch (_question)
        {
            case SingleAnswerQuestion singleAnswersQuestion:
                var rbs = controlsPanel.Controls.OfType<RadioButton>().ToList();
                for (var idx = 0; idx < rbs.Count; idx++)
                {
                    var rb = rbs[idx];
                    if (rb.Checked)
                    {
                        singleAnswersQuestion.AnswerIndex = idx;
                    }
                }

                break;
        }

        Close();
    }
}