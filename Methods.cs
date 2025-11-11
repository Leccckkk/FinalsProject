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

    public static DataTable LoadQuestionsManagement(string subject)
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();
            string query = @"
            SELECT *
            FROM tbl_questions
            WHERE subject = @subject
            ORDER BY subject, CAST(number AS UNSIGNED);
        ";

            using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@subject", subject);
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
    public static DataTable LoadUsers2(string user)
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string query = @"
            SELECT *
            FROM tbl_users
            WHERE Username LIKE @user
               OR student_number LIKE @user
               OR name LIKE @user;
        ";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user", "%" + user + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }

        return dt;
    }


    public static DataTable LoadStudents(string username)
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string query = @"
        SELECT 
            u.name,
            u.EnrollmentStatus,
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
          AND u.Username LIKE @Username
        ORDER BY s.Average DESC, u.name;
        ";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Username", "%" + username + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
        }

        return dt;
    }


    public static DataTable LoadStudents2()
    {
        DataTable dt = new DataTable();

        using (MySqlConnection conn = new MySqlConnection(connStr))
        {
            conn.Open();

            string query = @"
            SELECT 
                u.name,
                s.SumScore,
                COALESCE(s.Status, 'Not Taken') AS Status,
                s.Average,
                s.Strengths,
                s.Weaknesses
            FROM tbl_users u
            LEFT JOIN tbl_studentscores s 
                ON u.Username = s.Username
            WHERE u.userType = 'student'
            ORDER BY s.Average DESC, u.name;
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
        try
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
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row.RowState == DataRowState.Deleted)
                            continue;
                        string studentNumber = row["student_number"]?.ToString().Trim() ?? "";
                        string userType = row["userType"]?.ToString().Trim() ?? "";
                        string username = row["Username"]?.ToString().Trim() ?? "";
                        string name = row["name"]?.ToString().Trim() ?? "";
                        string email = row["email"]?.ToString().Trim() ?? "";
                        if (studentNumber.Length != 11 || !studentNumber.All(char.IsDigit))
                        {
                            MessageBox.Show($"Invalid student number '{studentNumber}'. Must contain exactly 11 digits.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        string[] validUserTypes = { "Student", "Teacher", "Admin" };
                        if (!validUserTypes.Contains(userType))
                        {
                            MessageBox.Show($"Invalid user type '{userType}'. Must be one of: {string.Join(", ", validUserTypes)}.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!username.All(char.IsLetter))
                        {
                            MessageBox.Show($"Invalid username '{username}'. Only letters are allowed.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!name.All(c => char.IsLetter(c) || c == ' '))
                        {
                            MessageBox.Show($"Invalid name '{name}'. Only letters and spaces are allowed.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (!email.Contains("@") || !email.EndsWith(".com"))
                        {
                            MessageBox.Show($"Invalid email '{email}'. Must contain '@' and end with '.com'.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    adapter.Update(dt);
                    MessageBox.Show("Changes saved successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        catch (MySqlException ex)
        {
            MessageBox.Show($"Database Error: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Unexpected Error: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
public static class Evaluate
{
    public static string EvaluateSubject(int score)
    {
        if (score >= 20)
            return ("Excellent performance! Keep it up!");
        else if (score >= 15)
            return ("Good, but there is room for improvement.");
        else
            return ("Needs improvement. Study more on this subject.");
    }
}

public class ScoreSummary
{
    public static void LoadChart(Chart chart)
    {
        string dbconnect = "SERVER=localhost; database=dbfinals; uid=root;";
        using (MySqlConnection sqlconnection = new MySqlConnection(dbconnect))
        {
            try
            {
                sqlconnection.Open();
                string query = @"
                SELECT 'Mathematics' AS Subject, AVG(MathScore) AS AvgScore FROM tbl_studentscores
                UNION ALL
                SELECT 'English' AS Subject, AVG(EngScore) AS AvgScore FROM tbl_studentscores
                UNION ALL
                SELECT 'Science' AS Subject, AVG(SciScore) AS AvgScore FROM tbl_studentscores
                UNION ALL
                SELECT 'History' AS Subject, AVG(HisScore) AS AvgScore FROM tbl_studentscores;
            ";

                MySqlCommand sqlcmd = new MySqlCommand(query, sqlconnection);
                MySqlDataReader sqlreader = sqlcmd.ExecuteReader();
                chart.Series.Clear();
                Series series = new Series("Average Score per Subject");
                series.ChartType = SeriesChartType.Column;
                series.IsValueShownAsLabel = true;
                chart.Series.Add(series);
                while (sqlreader.Read())
                {
                    string subject = sqlreader["Subject"].ToString();
                    double avgScore = Convert.ToDouble(sqlreader["AvgScore"]);
                    if (avgScore > 25)
                        avgScore = 25;
                    series.Points.AddXY(subject, avgScore);
                    chart.ChartAreas[0].AxisY.Maximum = 25;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart data: " + ex.Message);
            }
        }
    }

}
