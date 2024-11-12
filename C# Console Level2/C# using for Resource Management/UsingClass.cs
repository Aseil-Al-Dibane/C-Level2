using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.C__using_for_Resource_Management
{
    public class UsingClass
    {
        public const string ConnectionString = "Server=.;Database=DVLDDB;User Id=sa;Password=sa123456;";

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM People";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dt.Load(reader);
                        }
                    }
                }

                if (dt.Rows.Count > 0)
                    return dt;
            }
            catch (SqlException e)
            {
                Console.WriteLine($"Database Connection error: {e.Message}");
            }

            return null;
        }
    }
}
