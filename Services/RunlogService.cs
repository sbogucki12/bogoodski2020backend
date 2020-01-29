using bogoodski2020backend.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace bogoodski2020backend.Services
{
    public class RunlogService
    {
        private readonly IMongoCollection<RunRecord> _runRecords;

        public RunlogService(IRunlogDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _runRecords = database.GetCollection<RunRecord>(settings.RunlogCollectionName);
        }

        public List<RunRecord> Get() =>
            _runRecords.Find(runRecord => true).ToList();

        public RunRecord Get(string id) =>
            _runRecords.Find<RunRecord>(runRecord => runRecord.Id == id).FirstOrDefault();

        public RunRecord Create(RunRecord runRecord)
        {
            _runRecords.InsertOne(runRecord);
            return runRecord;
        }

        public void Update(string id, RunRecord runRecordIn) =>
            _runRecords.ReplaceOne(runRecord => runRecord.Id == id, runRecordIn);

        public void Remove(RunRecord runRecordIn) =>
            _runRecords.DeleteOne(runRecord => runRecord.Id == runRecordIn.Id);

        public void Remove(string id) =>
            _runRecords.DeleteOne(runRecord => runRecord.Id == id);
    }
}
