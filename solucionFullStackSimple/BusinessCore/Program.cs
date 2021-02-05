using System;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
namespace BusinessCore
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var builder = new ConfigurationBuilder()
                .AddJsonFile($"appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env}.json", true, true)
                .AddEnvironmentVariables();

            var config = builder.Build();


            var conectionString = config.GetSection("ConnectionString");
            //string conectionString = "Data Source=localhost;Integrated Security=True";
                //Configuration.GetConnectionString("DefaultConnection");
                
            SqlConnection conn = new SqlConnection(conectionString.Value);
            conn.Open();
            // Simple 
            string sql = "select @@version";
            using var cmd = new SqlCommand(sql, conn);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"SQL  version: {version}");
        }

        //public static ()
        //    {
        //       Console.WriteLine("Testing the connection to the DB:");
        //    string conectionString =
        //        Configuration.GetConnectionString("DefaultConnection");
        //}
    }
}
