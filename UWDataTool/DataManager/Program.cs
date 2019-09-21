using DataAccess;
using MongoDB.Driver;
using System;

namespace DataManager
{
    class Program
    {
        private static string ApiUrl { get; set; }
        static void Main(string[] args)
        {
            // read in the API Configuration
            ApiUrl = Environment.GetEnvironmentVariable("API_URL");

            Console.WriteLine("Hello World");
           
        }
    }
}
