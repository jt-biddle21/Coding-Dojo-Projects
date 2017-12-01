using System;
using System.Collections.Generic;
using DbConnection;

namespace simpleCRUDmySql
{
    class Program
    {
        public void Read(string table)
        {
            List<Dictionary<string, object>> queryInfo = DbConnector.Query($"Select * from {table}");
            foreach (Dictionary<string, object> tablesUsers in queryInfo)
            {
                foreach (KeyValuePair<string, object> usersContent in tablesUsers)
                {
                    Console.WriteLine($"{usersContent.Key}, {usersContent.Value}");
                }
            }
        }
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop == true)
            {
                Console.WriteLine("Enter in a query:");
                string que = Console.ReadLine();
                List<Dictionary<string, object>> queryInfo = DbConnector.Query(que);
                foreach (Dictionary<string, object> tablesUsers in queryInfo)
                {
                    foreach (KeyValuePair<string, object> usersContent in tablesUsers)
                    {
                        Console.WriteLine($"{usersContent.Key}, {usersContent.Value}");
                    }
                }
                loop = false;
            }
            
        }
    }
}
