namespace КТ4;

public partial class Form1 : Form
{
    public Form1()
    {
        string filePath = "tickets.txt";

        Button button = new Button()
        {
            Text = "Прочитать содержимое файла",
            Location = new Point(10, 10),
            AutoSize = true
        };
        
        
        Label label = new Label()
        {
            Text = "Авиабилеты",
            Location = new Point(10, 10),
            AutoSize = true
        };
        button.Click += (s, e) =>
        {
            label.Text = File.ReadAllText(filePath);
        };
        InitializeComponent();
    }
}