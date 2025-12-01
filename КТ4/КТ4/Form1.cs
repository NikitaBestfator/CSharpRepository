namespace КТ4;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn_Click(object sender, EventArgs e)
    {
        using var ofd = new OpenFileDialog();
        var r = ofd.ShowDialog();
        if (r == DialogResult.OK)
        {
            var path = ofd.FileName;
            lbl.Text = File.ReadAllText(path);
        }
    }
}