using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectingToSqlServer
{
    internal class delete
    {
        public static void Main()
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source=rajeswari;Initial Catalog=Rajeswari;Integrated Security=True";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Console.WriteLine("Enter Employee id tat you want to delete:");
            int EmployeeID = int.Parse(Console.ReadLine());
            string deleteQuery = "delete from person where EmployeeID='" + EmployeeID + "'";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            deleteCommand.ExecuteNonQuery();
            Console.WriteLine("Data is deleted");
            Console.ReadKey();

            sqlConnection.Close();

        }
    }
}