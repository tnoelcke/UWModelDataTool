using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using MongoDB.Driver;

namespace UWDataApi.Repos
{
    public class UwModelRunRepo : IUwModelRunRepo
    {

        private static IMongoClient _client;
        private readonly MongoConfig _config;

        public UwModelRunRepo(MongoConfig config)
        {
            _config = config;
            _client = new MongoClient(_config.ConnectionString);
            MongoCredential _ = MongoCredential.CreateCredential(_config.Database, _config.User, _config.Password);
        }

        public UwModelRunRepo(IMongoClient client, MongoConfig config)
        {
            _client = client;
            _config = config;
        }

        private IMongoCollection<UwModelRun> GetCollection()
        {
            IMongoDatabase db = _client.GetDatabase(_config.Database);
            return db.GetCollection<UwModelRun>(_config.UwCollection);
        }
        public IEnumerable<UwModelRun> List {
            get
            {
                return GetCollection().Find(_ => true).ToEnumerable();
            }
        }

        public void Add(UwModelRun entity)
        {
            GetCollection().InsertOneAsync(entity);
        }

        public void Delete(UwModelRun entity)
        {
            GetCollection().DeleteOne(d => d.Id == entity.Id);
        }

        public UwModelRun FindById(int Id)
        {
            return GetCollection().Find(d => d.Id == Id).First();
        }

        public void Update(UwModelRun entity)
        {
            GetCollection().FindOneAndReplace(d => d.Id == entity.Id, entity); 
        }
    }
}
