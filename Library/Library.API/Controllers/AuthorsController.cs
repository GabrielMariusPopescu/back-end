using System;
using System.Collections.Generic;
using AutoMapper;
using Library.API.Entities;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : Controller
    {
        public AuthorsController(ILibraryRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authorsEntity = repository.GetAuthors();
            var authorToReturn = Mapper.Map<IEnumerable<AuthorDto>>(authorsEntity);
            return Ok(authorToReturn);
        }

        [HttpGet("{id}", Name = "GetAuthor")]
        public IActionResult GetAuthor(Guid id)
        {
            var authorEntity = repository.GetAuthor(id);
            if (authorEntity == null)
                return NotFound();

            var authorToReturn = Mapper.Map<AuthorDto>(authorEntity);
            return Ok(authorToReturn);
        }

        [HttpPost]
        public IActionResult CreateAuthor([FromBody] AuthorForCreationDto authorForCreationDto)
        {
            if (authorForCreationDto == null)
                return BadRequest();

            var authorEntity = Mapper.Map<AuthorEntity>(authorForCreationDto);
            repository.AddAuthor(authorEntity);
            var isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Creating an author with {authorEntity.Id} failed on save.");

            var authorToReturn = Mapper.Map<AuthorDto>(authorEntity);

            return CreatedAtRoute("GetAuthor", new { id = authorToReturn.Id }, authorToReturn);
        }

        [HttpPost("{id}")]
        public IActionResult BlockAuthorCreation(Guid id)
        {
            return repository.AuthorExists(id)
                ? new StatusCodeResult(StatusCodes.Status409Conflict)
                : BadRequest();

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(Guid id)
        {
            var authorEntity = repository.GetAuthor(id);
            if (authorEntity == null)
                return NotFound();

            repository.DeleteAuthor(authorEntity);

            var isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Deleting author {id} failed on save.");

            return NoContent();
        }

        //

        private readonly ILibraryRepository repository;
    }
}
