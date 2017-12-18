using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using dojoLeague.Models;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;

namespace dojoLeague.Factory
{
    public class DojoFactory : IFactory<Dojo>
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
 
        public DojoFactory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(MySqlConfig.Value.ConnectionString);
            }
        }
        public void AddDojo(Dojo T)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO dojos (DojoName, Location, Description) VALUES (@DojoName, @Location, @Description)";
                dbConnection.Open();
                dbConnection.Execute(query, T);
            }
        }
        public IEnumerable<Dojo> ShowAllDojos()
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = "SELECT * FROM dojos";
            dbConnection.Open();
            return dbConnection.Query<Dojo>(query);
            }
        }

        public IEnumerable<Dojo> ShowSpecificDojo(int DojoId)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"SELECT * FROM dojos JOIN ninjas ON dojos.DojoId = ninjas.Dojo_Id";
            dbConnection.Open();
            return dbConnection.Query<Dojo>(query);
            }
        }

        public IEnumerable<Dojo> DojoTitle(int DojoId)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"SELECT DojoName, Description FROM dojos WHERE DojoId = {DojoId}";
            dbConnection.Open();
            return dbConnection.Query<Dojo>(query);
            }
        }

        public IEnumerable<Dojo> Recruit(int NinjaId, int x)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"UPDATE ninjas SET Dojo_Id = {x} WHERE NinjaId = {NinjaId};";
            dbConnection.Open();
            return dbConnection.Query<Dojo>(query);
            }
        }
    }
}
