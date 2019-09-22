using System;
using System.Collections.Generic;
using System.Text;

namespace UWDataApi
{
    public class MongoConfig
    {
        public string Database { get; set; }

        public string ConnectionString { get; set; }

        public string Password { get; set; }

        public string UwCollection { get; set; }

        public string User { get; set; }
    }
}
