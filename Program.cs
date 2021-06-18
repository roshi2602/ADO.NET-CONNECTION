using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

//SqlConnection()-	It is used to initializes a new instance of the SqlConnection class.
//BeginTransaction()	-It is used to start a database transaction.
//ChangeDatabase(String)-  It is used to change the current database for an open SqlConnection.
//ChangePassword(String, String)	-It changes the SQL Server password for the user indicated in the connection string.
//Close()	-It is used to close the connection to the database.
//CreateCommand()	-It enlists in the specified transaction as a distributed transaction.
//GetSchema()	-It returns schema information for the data source of this SqlConnection.
//Open()	-It is used to open a database connection.

// "using"- statement allows you to specify multiple resources in a single statement.
   // The object could also be created outside the "using" statement

namespace ADO.Net_connection
{
    class Program
    {
        static void Main()
        {
            new Program().Connecting();
        }

        //make 1 method
        public void Connecting()
        {
            using(
                 //create connection
          SqlConnection con = new SqlConnection("data source=.; database=Employee; integrated security=SSPI")
                )
            { 
                //open connection
                con.Open();
                Console.WriteLine("connection established");
            }
        }
    }
}
