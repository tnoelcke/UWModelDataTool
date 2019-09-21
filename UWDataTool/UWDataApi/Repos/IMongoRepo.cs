using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UWDataApi.Repos
{
    interface IMongoRepo
    {
        void Create(UwModelRun ModelRun);

        UwModelRun GetRunById(string id);

        IEnumerable<UwModelRun> GetAllRuns();

        IEnumerable<UwModelRun> GetByDateInterval(DateTime start, DateTime end);

        IEnumerable<Tuple<string, DateTime>> GetRunIds();

        void Delete(string id);
    }
}
