using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class moviesController : ControllerBase
    {

        List<MovieModel> movies=null;
        public moviesController()
        {
            movies = new List<MovieModel>() { 
            
            new MovieModel(){ id=1, name="Movie1" ,Hall="H1"},
            new MovieModel(){ id=2, name="Movie2" ,Hall="H2"},
            new MovieModel(){ id=3, name="Movie3" ,Hall="H3"},
            new MovieModel(){ id=4, name="Movie4" ,Hall="H4"},
            new MovieModel(){ id=5, name="Movie5" ,Hall="H5"},
            new MovieModel(){ id=6, name="Movie6" ,Hall="H6"},


            };
        }

        [HttpGet]
        public IActionResult getMovies()
        {
            return Ok(movies);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult getMovie(int id)
        {
            return Ok(movies.Where(m => m.id == id).FirstOrDefault());

        }

    }


    public class MovieModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Hall { get; set; }
    }
}
