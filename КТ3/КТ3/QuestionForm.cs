using System.Text.RegularExpressions;
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
            {
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
            case MultiAnswerQuestion multiAnswersQuestion:
            {
                var top = 0;
                foreach (var answer in multiAnswersQuestion.Answers)
                {
                    var checkBox = new CheckBox
                    {
                        Top = top,
                        Text = answer
                    };
                    controlsPanel.Controls.Add(checkBox);
                    top += checkBox.Height + 5;
                }

                break;
            }
            case TextAnswerQuestion textAnswerQuestion:
            {
                var textBox = new TextBox
                {
                    Width = controlsPanel.Width,
                    Height = 100
                };
                controlsPanel.Controls.Add(textBox);
                break;
            }
            case IntegerAnswerQuestion integerAnswerQuestion:
            {
                var textBox = new TextBox
                {
                    Width = controlsPanel.Width,
                    Height = 100,
                    AcceptsReturn = false,
                    AcceptsTab = false,
                    MaxLength = 3
                };

                textBox.KeyPress += (sender, e) =>
                {
                    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                };
                
                controlsPanel.Controls.Add(textBox);
                
                break;
            }
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
            
            case MultiAnswerQuestion multiAnswersQuestion:
                var checkBoxes = controlsPanel.Controls.OfType<CheckBox>().ToList();
                for (var idx = 0; idx < checkBoxes.Count; idx++)
                {
                    var checkBox = checkBoxes[idx];
                    if (checkBox.Checked)
                    {
                        multiAnswersQuestion.AnswersIndexes.Add(idx);
                    }
                }
                break;


            case TextAnswerQuestion textAnswerQuestion:
                var textBox = controlsPanel.Controls.OfType<TextBox>().Single();
                textAnswerQuestion.Answer = textBox.Text;
                break;


            case IntegerAnswerQuestion integerAnswerQuestion:
                var integerBox = controlsPanel.Controls.OfType<TextBox>().Single();
                integerAnswerQuestion.Answer = int.Parse(integerBox.Text);
                break;
                
        }

        Close();
    }
}