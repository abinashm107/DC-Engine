using DC_Engine.Domains;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Infrastructure
{
    public class DBClient : IDBClient
    {
        readonly IMongoCollection<Movie> _movies;

        public DBClient(IOptions<DCDBConfig> directorsCutDbConfig)
        {
            var client = new MongoClient(directorsCutDbConfig.Value.Connection_String);
            var database = client.GetDatabase(directorsCutDbConfig.Value.Database_Name);
            _movies = database.GetCollection<Movie>(directorsCutDbConfig.Value.Movie_Collection_Name);
        }
        public IMongoCollection<Movie> GetMovieCollection() => _movies;
    }
}
