using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Library.API.Entities;
using Library.API.Helpers;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/authorcollections")]
    public class AuthorCollectionController : Controller
    {
        public AuthorCollectionController(ILibraryRepository repository)
        {
            this.repository = repository;
        }

        [HttpPost]
        public IActionResult CreateAuthorCollection([FromBody] IEnumerable<AuthorForCreationDto> authorCollection)
        {
            if (authorCollection == null)
                return BadRequest();

            var authorsEntity = Mapper.Map<IEnumerable<AuthorEntity>>(authorCollection).ToList();
            authorsEntity.ForEach(repository.AddAuthor);

            var isSaved = repository.Save();
            if (!isSaved)
                throw new Exception("Creating an author collection failed on save.");


            var authorCollectionToReturn = Mapper.Map<IEnumerable<AuthorDto>>(authorsEntity);
            var idsAsString = string.Join(",", authorCollectionToReturn.Select(it => it.Id));

            return CreatedAtRoute("GetAuthorCollection", new { ids = idsAsString }, authorCollectionToReturn);
        }

        [HttpGet("({ids})", Name = "GetAuthorCollection")]
        public IActionResult GetAuthorCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))]IEnumerable<Guid> ids)
        {
            if (ids == null)
                return BadRequest();

            var authorsEntity = repository.GetAuthors(ids);
            if (ids.Count() != authorsEntity.Count())
                return NotFound();

            var authorsToReturn = Mapper.Map<IEnumerable<AuthorDto>>(authorsEntity);
            return Ok(authorsToReturn);
        }

        //

        private readonly ILibraryRepository repository;
    }
}
