using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Movie_Store_MVC_5.Models;
using Movie_Store_MVC_5.Dtos;
using AutoMapper;

namespace Movie_Store_MVC_5.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //Get /api/customers
        public IEnumerable<MoviesDto> GetMovies()
        {
            return _context.Movies
                .Include(m => m.Genre)
                .ToList()
                .Select(Mapper.Map<Movie, MoviesDto>);
        }

        //Get /api/customers/1
        public IHttpActionResult GetMovies(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return NotFound();

            return Ok(Mapper.Map<Movie, MoviesDto>(movie));
        }

        //Post /api/customers
        [HttpPost]
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult CreateMovie(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movie>(moviesDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            moviesDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), moviesDto);
        }

        //Put /api/customers/1
        [HttpPut]
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult UpdateMovie(int id, MoviesDto moviesDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var moviesInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (moviesInDb == null)
                return NotFound();

            Mapper.Map(moviesDto, moviesInDb);

            _context.SaveChanges();

            return Ok();
        }

        //Delete /api/customers/1
        [Authorize(Roles = RoleName.canManageMovies)]
        public IHttpActionResult DeleteMovie(int id)
        {
            var moviesInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (moviesInDb == null)
                return NotFound();

            _context.Movies.Remove(moviesInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}