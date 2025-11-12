using КТ3.Models;

namespace КТ3;

public partial class ReportForm : Form
{
    public ReportForm(Questionary questionary)
    {
        InitializeComponent();
        resultsText.Text = questionary.GetQuestionsAndAnswers();
    }

    private void closeBtn_Click(object sender, EventArgs e)
    {
        Close();
    }
}