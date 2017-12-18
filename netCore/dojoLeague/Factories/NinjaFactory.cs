using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using dojoLeague.Models;
using Microsoft.Extensions.Options;

namespace dojoLeague.Factory
{
    public class NinjaFactory : IFactory<Ninja>
    {
        private readonly IOptions<MySqlOptions> MySqlConfig;
 
        public NinjaFactory(IOptions<MySqlOptions> config)
        {
            MySqlConfig = config;
        }
        internal IDbConnection Connection {
            get {
                return new MySqlConnection(MySqlConfig.Value.ConnectionString);
            }
        }
        public void AddNinja(Ninja T)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO ninjas (NinjaName, Level, Dojo_Id, NinjaDescription) VALUES (@NinjaName, @Level, @Dojo, @Description)";
                dbConnection.Open();
                dbConnection.Execute(query, T);
            }
        }
        public IEnumerable<Ninja> ShowAllNinjas()
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = "SELECT * FROM ninjas JOIN dojos ON ninjas.Dojo_Id = dojos.DojoId";
            dbConnection.Open();
            return dbConnection.Query<Ninja>(query);
            }
        }

        public IEnumerable<Ninja> ShowSpecificNinja(int NinjaId)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"SELECT * FROM ninjas JOIN dojos ON ninjas.Dojo_Id = dojos.DojoId WHERE NinjaId = {NinjaId}";
            dbConnection.Open();
            return dbConnection.Query<Ninja>(query);
            }
        }

        public IEnumerable<Ninja> Remove(int NinjaId)
        {
            using (IDbConnection dbConnection = Connection)
            {
            string query = $"UPDATE ninjas SET Dojo_Id = 1 WHERE NinjaId = {NinjaId}";
            dbConnection.Open();
            return dbConnection.Query<Ninja>(query);
            }
        }
    }
}
