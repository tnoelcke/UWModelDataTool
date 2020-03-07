using DataAccess;
using DataManager.Config;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DataManager
{
    class Program
    {
        private static string ApiUrl { get; set; }
        private static List<Tuple<string, string>> DataSources { get; set; }

        private static ApiConfig apiConfig { get; set; }

        private static ECMWFConfig ECMWFConfig { get; set; }

        private static GFSConfig GFSConfig { get; set; }

        private static NAMConfig NAMConfig { get; set; }

        private static UWConfig UWConifg { get; set; }

        static void Main(string[] args)
        {
            readInConfig();

            Console.WriteLine("Hello World");
           
        }

        /// <summary>
        /// reads in the config from the appsettings file
        /// </summary>
        public static void readInConfig()
        {

        }
    }
}
