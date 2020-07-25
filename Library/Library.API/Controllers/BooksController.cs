using System;
using System.Collections.Generic;
using AutoMapper;
using Library.API.Entities;
using Library.API.Models;
using Library.API.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace Library.API.Controllers
{
    [Route("api/authors/{authorId}/books")]
    public class BooksController : Controller
    {
        public BooksController(ILibraryRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetBooksForAuthor(Guid authorId)
        {
            if (!repository.AuthorExists(authorId))
                return NotFound();

            var booksFromRepository = repository.GetBooksForAuthor(authorId);
            var books = Mapper.Map<IEnumerable<BookDto>>(booksFromRepository);
            return Ok(books);
        }

        [HttpGet("{id}", Name = "GetBookForAuthor")]
        public IActionResult GetBookForAuthor(Guid authorId, Guid id)
        {
            if (!repository.AuthorExists(authorId))
                return NotFound();

            if (!repository.BookExists(id))
                return NotFound();

            var bookFromRepository = repository.GetBookForAuthor(authorId, id);
            var book = Mapper.Map<BookDto>(bookFromRepository);
            return Ok(book);
        }

        [HttpPost]
        public IActionResult CreateBookForAuthor(Guid authorId, [FromBody] BookForCreationDto bookForCreationDto)
        {
            if (bookForCreationDto == null)
                return BadRequest();

            if (!repository.AuthorExists(authorId))
                return NotFound();

            var bookEntity = Mapper.Map<BookEntity>(bookForCreationDto);

            if (repository.BookExists(bookEntity.Id))
                return BadRequest();

            repository.AddBookForAuthor(authorId, bookEntity);

            isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Creating a book for author {authorId} failed on save.");

            var bookToReturn = Mapper.Map<BookDto>(bookEntity);
            return CreatedAtRoute("GetBookForAuthor", new { authorId, id = bookToReturn.Id }, bookToReturn);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBookForAuthor(Guid authorId, Guid id)
        {
            if (!repository.AuthorExists(authorId))
                return NotFound();

            var bookEntityForAuthor = repository.GetBookForAuthor(authorId, id);
            if (bookEntityForAuthor == null)
                return NotFound();

            repository.DeleteBook(bookEntityForAuthor);
            isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Deleting book {id} for author {authorId} failed on save.");

            return NoContent();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBookForAuthor(Guid authorId, Guid id, [FromBody] BookForUpdateDto book)
        {
            if (book == null)
                return BadRequest();

            if (!repository.AuthorExists(authorId))
                return NotFound();

            var bookFromRepository = repository.GetBookForAuthor(authorId, id);

            if (!repository.BookExists(bookFromRepository.Id))
            {
                var bookToAdd = Mapper.Map<BookEntity>(book);
                bookToAdd.Id = id;

                repository.AddBookForAuthor(authorId, bookToAdd);


                isSaved = repository.Save();
                if (!isSaved)
                {
                    throw new Exception($"Upserting book {id} for author {id} failed on save.");
                }

                var bookToReturn = Mapper.Map<BookDto>(bookToAdd);

                return CreatedAtRoute("GetBookForAuthor", new { authorId, id = bookToReturn.Id }, bookToReturn);
            }


            Mapper.Map(book, bookFromRepository);
            repository.UpdateBookForAuthor(bookFromRepository);

            isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Updating book {id} for author {authorId} failed on save.");

            return Ok(book);
        }


        [HttpPatch("{id}")]
        public IActionResult PartiallyUpdateBookForAuthor(Guid authorId, Guid id, [FromBody] JsonPatchDocument<BookForUpdateDto> patchDocument)
        {
            if (patchDocument == null)
                return BadRequest();


            if (!repository.AuthorExists(authorId))
                return NotFound();

            var bookForAuthorFromRepository = repository.GetBookForAuthor(authorId, id);
            if (!repository.BookExists(bookForAuthorFromRepository.Id))
            {
                var bookDto = new BookForUpdateDto();
                patchDocument.ApplyTo(bookDto);

                var bookToAdd = Mapper.Map<BookEntity>(bookDto);
                bookToAdd.Id = id;

                repository.AddBookForAuthor(authorId, bookToAdd);

                isSaved = repository.Save();
                if (!isSaved)
                    throw new Exception($"Patching book {id} for author {authorId} failed on save.");

                var bookToReturn = Mapper.Map<BookDto>(bookToAdd);

                return CreatedAtRoute("GetBookForAuthor", new { authorId, id = bookToReturn.Id }, bookToReturn);
            }

            var bookToPatch = Mapper.Map<BookForUpdateDto>(bookForAuthorFromRepository);
            patchDocument.ApplyTo(bookToPatch);

            Mapper.Map(bookToPatch, bookForAuthorFromRepository);

            repository.UpdateBookForAuthor(bookForAuthorFromRepository);

            isSaved = repository.Save();
            if (!isSaved)
                throw new Exception($"Patching book {id} for author {authorId} failed on save.");

            return NoContent();
        }

        //

        private readonly ILibraryRepository repository;
        private bool isSaved;
    }
}
