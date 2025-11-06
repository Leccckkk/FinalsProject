using FinalsProject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalsProject
{
    internal class Methods
    {
    }
}

public class Login
{
    public static string CheckLogin(string Username, string password)
    {
        
        string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
        MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
        MySqlCommand sqlcmd = new MySqlCommand();
        MySqlDataReader sqlreader;

        sqlconnection.Open();

        sqlcmd.CommandText = $"SELECT * FROM tbl_users WHERE Username = '{Username}'";
        sqlcmd.CommandType = CommandType.Text;
        sqlcmd.Connection = sqlconnection;

        sqlreader = sqlcmd.ExecuteReader();

        if (sqlreader.HasRows)
        {
            while (sqlreader.Read())
            {
                if (sqlreader[1].ToString() == password)
                {
                    return sqlreader[2].ToString();
                }
            }
        }
        

            sqlconnection.Close();
        return "Invalid";
    }  
}
public class register
{
    public static void RegisterUser(string Username, string Password)
    {
        string dbconnect = "SERVER=localhost; database=dbfinals; uid=root";
        MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
        MySqlCommand sqlcmd = new MySqlCommand();

        sqlconnection.Open();

        sqlcmd.CommandText = $"INSERT INTO tbl_users (Username, Password)" +
                             $"VALUES ('{Username}', '{Password}')";
        sqlcmd.CommandText = $"INSERT INTO tbl_studentscores (Username)" +
                             $"VALUES ('{Username}')";

        sqlcmd.CommandType = CommandType.Text;
        sqlcmd.Connection = sqlconnection;

        sqlcmd.ExecuteNonQuery();

        sqlconnection.Close();
    }
}

public class ShowQuestions
{
    public static void Questions(int Number,  string Subject)
    {
        if (Number <= 10)
        {
            string dbconnect = "SERVER=localhost; database=dbactivity; uid=root";
            MySqlConnection sqlconnection = new MySqlConnection(dbconnect);
            MySqlCommand sqlcmd = new MySqlCommand();
            MySqlDataReader sqlreader;




            sqlconnection.Open();

            sqlcmd.CommandText = $"SELECT * FROM Tbl_question WHERE number = '{Number}' AND subject = '{Subject}'";
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Connection = sqlconnection;

            sqlreader = sqlcmd.ExecuteReader();

            

            sqlconnection.Close();
        }
    }
}

public static class QuestionManager
{
    private static string connStr = "server=localhost;database=dbfinals;uid=root;pwd=;";

    public static DataTable LoadQuestions()
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_questions ORDER BY subject, CAST(number AS UNSIGNED)";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.Fill(dt);
            }
        }

        return dt;
    }
    public static void SaveChanges(DataTable dt)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_questions";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();

                adapter.Update(dt);
            }
        }
    }
    public static int CountQuestionsBySubject(string subject)
    {
        int total = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tbl_questions WHERE subject = @subject";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@subject", subject);
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        return total;
    }

    public static void DeleteQuestion(int id)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "DELETE FROM tbl_questions WHERE id = @id";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }

}

public static class UserManager
{
    private static string connStr = "server=localhost;database=dbfinals;uid=root;pwd=;";

    public static DataTable LoadUsers()
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_users ORDER BY userType";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.Fill(dt);
            }
        }

        return dt;
    }
    public static DataTable LoadStudents()
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_users WHERE userType = @type";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@type", "student");
                adapter.Fill(dt);
            }
        }

        return dt;
    }
    public static int CountStudents(string subject)
    {
        int total = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tbl_users WHERE userType = @type";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@type", "student");
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        return total;
    }
    public static void SaveChanges(DataTable dt)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_users";
            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();

                adapter.Update(dt);
            }
        }
    }

    public static void DeleteUser(int Username)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "DELETE FROM tbl_users WHERE Username = @Username";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.ExecuteNonQuery();
            }
        }
    }
}