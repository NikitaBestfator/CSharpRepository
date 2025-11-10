using КТ3.Models;

namespace КТ3;

public partial class ReportForm : Form
{
    public ReportForm(Questionary questionary)
    {
        CheckBox checkbox1 = new CheckBox();
        checkbox1.Text = "Тигр";
        checkbox1.Name = "checkbox1";
        checkbox1.Checked = true;
        
        
    }
}