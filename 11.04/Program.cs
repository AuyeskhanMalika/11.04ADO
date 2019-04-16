using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._04
{
    class Program
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["appConnection"].ConnectionString;
        static SqlConnection sqlConnection = null;
        static SqlCommand sqlCommand = null;
        static SqlDataReader reader = null;

        static void Main(string[] args)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand = new SqlCommand ("create table gruppa (Id int primary key identity, Name varchar(50) not null)", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            Console.ReadKey();
            reader.Close();
        }
    }
}
