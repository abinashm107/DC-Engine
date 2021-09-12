using DC_Engine.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Feature
{
    public interface IMovieServices
    {
        List<Movie> GetMovies();
        Movie GetMovie(string id);
        List<Movie> UpcomingMovies();
        List<Movie> RunningMovies();
        List<Movie> SearchTitles(string query);
    }
}
