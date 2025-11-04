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
