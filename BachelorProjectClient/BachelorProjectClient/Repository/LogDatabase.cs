using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BachelorProjectClient.Repository
{
    public class LogDatabase
    {
        public static void InsertToLogDb(int clientId, long totalTime, long? requestContentSize, long? responseContentSize, int executionNO, int iteration, string dbName, string testCase, string api)
        {

            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["logDb"].ConnectionString);
            try
            {
                string cmdQuery = "INSERT INTO resultdatalog(clientId, totalTime, requestContentSize, responseContentSize, executionNO, iteration, dbName, testCase, api) " +
                    "VALUES (@clientId, @totalTime, @requestContentSize, @responseContentSize, @executionNO, @iteration, @dbName, @testCase, @api)";
                MySqlCommand cmd = new MySqlCommand(cmdQuery, conn);
                cmd.Parameters.AddWithValue("@clientId", clientId);
                cmd.Parameters.AddWithValue("@totalTime", totalTime);
                cmd.Parameters.AddWithValue("@requestContentSize", requestContentSize);
                cmd.Parameters.AddWithValue("@responseContentSize", responseContentSize);
                cmd.Parameters.AddWithValue("@executionNO", executionNO);
                cmd.Parameters.AddWithValue("@iteration", iteration);
                cmd.Parameters.AddWithValue("@dbName", dbName);
                cmd.Parameters.AddWithValue("@testCase", testCase);
                cmd.Parameters.AddWithValue("@api", api);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            //TODO: Läggtill insert logik
        }
    }
}
