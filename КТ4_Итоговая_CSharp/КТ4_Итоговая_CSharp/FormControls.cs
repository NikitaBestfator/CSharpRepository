using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace КТ4_Итоговая_CSharp;

public class FormControls
{
    private string _connectionString;

    private Label _idLabel = new Label()
    {
        Text = "ID"
    };
    
    private TextBox _idTB = new TextBox()
    {
        
    };
    
    private Label _nameOfPersonLabel = new Label()
    {
        Text = "Name"
    };
    
    private TextBox _nameOfPersonTB = new TextBox();
    
    private Label _emailOfPersonLabel = new Label()
    {
        Text = "Email"
    };
    
    private TextBox _emailOfPersonTB = new TextBox();
    
    private Button _insertDataButton = new Button()
    {
        Text = "Записать данные"
    };

    public Control[] ArrayControls => new Control[]
    {
        _idLabel,
        _idTB,
        _nameOfPersonLabel,
        _nameOfPersonTB,
        _emailOfPersonLabel,
        _emailOfPersonTB,
        _insertDataButton
    };

    public FormControls(string connectionString, Form form)
    {
        _connectionString = connectionString;
        _insertDataButton.Click += InsertData;

        var left = 10;
        var top = 10;
        var width = 300; 
        var height = 26;
        foreach (var c in ArrayControls)
        {
            c.Left = left;
            c.Top = top;
            c.Width = width;
            c.Height = height;
            form.Controls.Add(c);

            top += 25;
        }
    }

    private void InsertData(object sender, EventArgs eventArgs)
    {
        using var sqlConnection = new MySqlConnection(_connectionString);
        sqlConnection.Open();

        string sqlRequest = @"
            USE MyDataBase;
            INSERT INTO MyTable (Id, Name, Email)
            VALUES (@Id, @Name, @Email);";

        using var sqlCommand = new MySqlCommand(sqlRequest, sqlConnection);
        sqlCommand.Parameters.AddWithValue("@Id", Convert.ToInt32(_idTB.Text));
        sqlCommand.Parameters.AddWithValue("@Name", _nameOfPersonTB.Text);
        sqlCommand.Parameters.AddWithValue("@Email", _emailOfPersonTB.Text);

        int rowsAffected = sqlCommand.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            MessageBox.Show("Данные успешно сохранены в БД",
                "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            _nameOfPersonTB.Clear();
            _emailOfPersonTB.Clear();
        }
    }
}