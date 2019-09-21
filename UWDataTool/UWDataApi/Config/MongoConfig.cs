using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class MongoConfig
    {
        public string Database { get; set; }

        public string ConnectionString { get; set; }

        public string Password { get; set; }

        public string UwCollection { get; set; }

        public string User { get; set; }

        public static MongoConfig getConfigFromEnv()
        {
            return new MongoConfig()
            {
                Database = Environment.GetEnvironmentVariable("Mongo.Database") ?? "UwData",
                ConnectionString = Environment.GetEnvironmentVariable("Mongo.ConnectionString") ?? "mongodb://localhost:27017",
                Password = Environment.GetEnvironmentVariable("Mongo.Password") ?? "Password",
                UwCollection = Environment.GetEnvironmentVariable("Mongo.UwCollection") ?? "UwData",
                User = Environment.GetEnvironmentVariable("Mongo.User") ?? "Admin"
            };
        }
    }
}
