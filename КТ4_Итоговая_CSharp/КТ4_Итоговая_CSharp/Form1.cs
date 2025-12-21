namespace КТ4_Итоговая_CSharp;

public partial class Form1 : Form
{
    private FormControls _fc;
    private ReadDataControls _rdc;
    public Form1()
    {
        InitializeComponent();

        var connStr = "Server=localhost;Port=3306;Database=MyDataBase;User=root;Password=1234;";
        _fc = new FormControls(connStr, this);
        
        _rdc = new ReadDataControls(connStr, this);
    }
}