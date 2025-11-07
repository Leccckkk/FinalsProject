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
using System.Windows.Forms.DataVisualization.Charting;


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

            string query = @"
            SELECT 
                u.name,
                s.MathScore,
                s.EngScore,
                s.SciScore,
                s.HisScore,
                s.SumScore,
                COALESCE(s.Status, 'Not Taken') AS Status,
                s.Average
            FROM tbl_users u
            LEFT JOIN tbl_studentscores s 
                ON u.Username = s.Username
            WHERE u.userType = 'student'
            ORDER BY u.name;
        ";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
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
    public static void SaveStudentScores(DataTable dt)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT * FROM tbl_studentscores";
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

    public static void DeleteUser(string Username)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string deleteScores = "DELETE FROM tbl_studentscores WHERE Username = @Username";
            using (MySqlCommand cmdScores = new MySqlCommand(deleteScores, conn))
            {
                cmdScores.Parameters.AddWithValue("@Username", Username);
                cmdScores.ExecuteNonQuery();
            }

            string deleteUser = "DELETE FROM tbl_users WHERE Username = @Username";
            using (MySqlCommand cmdUser = new MySqlCommand(deleteUser, conn))
            {
                cmdUser.Parameters.AddWithValue("@Username", Username);
                cmdUser.ExecuteNonQuery();
            }
        }
    }
    public static void DeleteRecord(string Username)
    {
        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string deleteScores = "DELETE FROM tbl_studentscores WHERE Username = @Username";
            using (MySqlCommand cmdScores = new MySqlCommand(deleteScores, conn))
            {
                cmdScores.Parameters.AddWithValue("@Username", Username);
                cmdScores.ExecuteNonQuery();
            }
        }
    }

    public static int CountStudentsTakenExam()
    {
        int total = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM tbl_studentscores";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        return total;
    }
    public static double Passing()
    {
        double passingRate = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string queryPassed = "SELECT COUNT(*) FROM tbl_studentscores WHERE Status = 'PASSED'";
            MySqlCommand cmdPassed = new MySqlCommand(queryPassed, conn);
            int passedCount = Convert.ToInt32(cmdPassed.ExecuteScalar());

            string queryTotal = "SELECT COUNT(*) FROM tbl_studentscores";
            MySqlCommand cmdTotal = new MySqlCommand(queryTotal, conn);
            int totalCount = Convert.ToInt32(cmdTotal.ExecuteScalar());

            if (totalCount > 0)
            {
                passingRate = (double)passedCount / totalCount * 100;
            }
        }

        return passingRate;
    }
    public static double Passed()
    {
        double passing = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string queryPassed = "SELECT COUNT(*) FROM tbl_studentscores WHERE Status = 'PASSED'";
            MySqlCommand cmdPassed = new MySqlCommand(queryPassed, conn);
            int passedCount = Convert.ToInt32(cmdPassed.ExecuteScalar());
            passing = passedCount;
        }

        return passing;
    }
    public static double Failed()
    {
        double failing = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string queryPassed = "SELECT COUNT(*) FROM tbl_studentscores WHERE Status = 'FAILED'";
            MySqlCommand cmdPassed = new MySqlCommand(queryPassed, conn);
            int failedCount = Convert.ToInt32(cmdPassed.ExecuteScalar());
            failing = failedCount;
        }

        return failing;
    }
    public static int NotTakenExam()
    {
        int total = 0;

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = @"
            SELECT COUNT(*)
            FROM tbl_users
            WHERE userType = 'student'
              AND Username NOT IN (SELECT Username FROM tbl_studentscores)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                total = Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        return total;
    }
}