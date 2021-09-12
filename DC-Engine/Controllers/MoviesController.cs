using DC_Engine.Feature;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DC_Engine.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieServices _movieServices;
        public MoviesController(IMovieServices movieServices)
        {
            _movieServices = movieServices;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_movieServices.GetMovies());
        }

        [HttpGet("{id}", Name = "GetMovie")]
        public IActionResult GetMovie(string id)
        {
            return Ok(_movieServices.GetMovie(id));
        }

        [HttpGet]
        [Route("/upcoming")]
        public IActionResult UCMovies()
        {
            return Ok(_movieServices.UpcomingMovies());
        }

        [HttpGet]
        [Route("/running")]
        public IActionResult RunningMovies()
        {
            return Ok(_movieServices.RunningMovies());
        }

        [HttpGet]
        [Route("/searchtitle")]
        public IActionResult SearchMovies(string query)
        {
            return Ok(_movieServices.SearchTitles(query));
        }
    }
}
