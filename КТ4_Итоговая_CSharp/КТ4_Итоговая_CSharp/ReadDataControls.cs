using System.Text;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace КТ4_Итоговая_CSharp;

public class ReadDataControls
{
    private string _connectionString;
    
    private TextBox _dataTB = new TextBox()
    {
        Text = "Прочитать"
    };
    
    private Button _loadDataButton = new Button()
    {
        Text = "Прочитать"
    };
    
    public Control[] ArrayControls =>  new Control[]
    {
        _dataTB,
        _loadDataButton
    };

    public ReadDataControls(string connectionString, Form form)
    {
        _connectionString = connectionString;
        _loadDataButton.Click += LoadData;

        var left = 350;
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
            
            top += 100;
        }
    }

    private void LoadData(object sender, EventArgs eventArgs)
    {
        using (var sqlConnection = new MySqlConnection(_connectionString))
        {
            sqlConnection.Open();

            string sqlRequest = @"
            USE MyDataBase;
            SELECT Id, Name, Email FROM MyTable";

            using (var sqlCommand = new MySqlCommand(sqlRequest, sqlConnection))
            {
                using (MySqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    StringBuilder sb = new StringBuilder();

                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            sb.Append(reader[i]);
                            if (i < reader.FieldCount - 1)
                                sb.Append(" | ");
                        }
                        sb.AppendLine();
                    }
                    _dataTB.Text = sb.ToString();
                }
            }
        }
    }
}