using DC_Engine.Domains;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Infrastructure
{
    public interface IDBClient
    {
        IMongoCollection<Movie> GetMovieCollection();
    }
}
