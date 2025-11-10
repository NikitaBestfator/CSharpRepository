namespace КТ3;

public partial class Form1 : Form
{
    public Form1()
    {

        private TabControl _tabControl;
        private TabPage _tabPage1;  
        private TabPage _tabPage2;
        private TabPage _tabPage3;
        
        private Button _button1;
        private Button _button2;
        private Button _button3;

        private void InitializeForm()
        {
            this.Text = "Сколько будет 2+2?";
            this.Size = new Size(400, 300);
        }

        private void InitializeTabControl()
        {
            _tabControl = new TabControl();
            _tabControl.Dock = DockStyle.Fill;
        }
        private void InitializeTabPage1()
        {
            _tabPage1 = new TabPage();
            _tabPage2 = new TabPage();
            _tabPage3 = new TabPage();
            
            _tabControl.TabPages.Add(_tabPage1);
            _tabControl.TabPages.Add(_tabPage2);
            _tabControl.TabPages.Add(_tabPage3);
        }

        private void InitializeControlsOnTabPages()
        {
            _button1 = new Button();
            _button1.Text = "3";
            _button1.Location = new Point(10, 10);
            _button1.Click += (sender, EventArgs) =>
            {
                MessageBox.Show("Неправильно");
            };
            _tabPage1.Controls.Add(_button1);
            
            _button2 = new Button();
            _button2.Text = "5";
            _button2.Location = new Point(10, 20);
            _button2.Click += (sender, EventArgs) =>
            {
                MessageBox.Show("Неправильно");
            };
            _tabPage2.Controls.Add(_button2);
            
            _button3 = new Button();
            _button3.Text = "4";
            _button3.Location = new Point(10, 30);
            _button3.Click += (sender, EventArgs) =>
            {
                MessageBox.Show("Правильно");
            };
            _tabPage3.Controls.Add(_button3);
        }
    
    }
}