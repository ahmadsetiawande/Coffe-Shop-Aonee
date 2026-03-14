using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Coffe_Shop.Repos
{
    public static class Datbase
    {
        public static string ConnectionStringOldStyle { get; set; }
            = "Server=localhost;Port=3306;Database=db_coffe_aone;Uid=root;Pwd=;";

        public static MySqlConnection GetConnectionOldStyle()
        {
            return new MySqlConnection(ConnectionStringOldStyle);
        }
        //connection pool
        private static MySqlConnectionStringBuilder DefaultBuilder => new()
        {
            Server = "localhost",
            Port = 3306,
            Database = "db_coffe_aone",
            Password = "",
            Pooling = true,
            MinimumPoolSize = 0,
            MaximumPoolSize = 100,
            ConnectionLifeTime = 0,
            ConnectionTimeout = 15
        };

        public static string? ConnectionString {  get; set; }

        public static MySqlConnection GetConnection()
        {
            var cs = ConnectionString ?? DefaultBuilder.ConnectionString;
            return new MySqlConnection(cs);
        }

        public static async Task<MySqlConnection> GetOpenConnectionAsync()
        {
            var conn = GetConnection();
            await conn.OpenAsync();
            return conn;

        }
    }
}
