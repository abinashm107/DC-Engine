using DC_Engine.Domains;
using DC_Engine.Infrastructure;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Feature
{
    public class MovieServices : IMovieServices
    {
        private readonly IMongoCollection<Movie> _movies;

        public MovieServices(IDBClient dbClient)
        {
            _movies = dbClient.GetMovieCollection();
        }

        public List<Movie> GetMovies()
        {
            return _movies.Find(movie => true).ToList();
        }

        public Movie GetMovie(string id) => _movies.Find(movie => movie.Id == id).First();

        public List<Movie> UpcomingMovies() => _movies.Find(movie => movie.listingType == "UP_COMING").ToList();

        public List<Movie> RunningMovies() => _movies.Find(movie => movie.listingType == "NOW_SHOWING").ToList();

        public List<Movie> SearchTitles(string query) => _movies.Find(movie => movie.Title.ToUpper().Contains(query.ToUpper())).ToList();

    }
}
