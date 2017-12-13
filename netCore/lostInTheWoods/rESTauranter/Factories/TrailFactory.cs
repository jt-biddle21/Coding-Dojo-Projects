using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using rESTauranter.Models;
using Microsoft.Extensions.Options;
 
namespace rESTauranter.Factory
{
    public class TrailFactory : IFactory<Trail>
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
 
        public TrailFactory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(MySqlConfig.Value.ConnectionString);
            }
        }
        public void AddTrail(Trail T)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO trails (Name, Description, Length, Elevation, Latitude, Longitude) VALUES (@Name, @Description, @Length, @Elevation, @Latitude, @Longitude)";
                dbConnection.Open();
                dbConnection.Execute(query, T);
            }
        }
        public IEnumerable<Trail> ShowAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = "Select * from trails";
            dbConnection.Open();
            return dbConnection.Query<Trail>(query);
            }
        }

        public IEnumerable<Trail> ShowSpecific(int TrailId)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"SELECT * FROM trails WHERE TrailId = {TrailId}";
            dbConnection.Open();
            return dbConnection.Query<Trail>(query);
            }
        }
    }
}
