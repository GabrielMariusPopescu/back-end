using System;
using System.Collections.Generic;
using Library.API.Entities;

namespace Library.API.Services
{
    public interface ILibraryRepository
    {
        IEnumerable<AuthorEntity> GetAuthors();
        AuthorEntity GetAuthor(Guid authorId);
        IEnumerable<AuthorEntity> GetAuthors(IEnumerable<Guid> authorIds);
        void AddAuthor(AuthorEntity authorEntity);
        void DeleteAuthor(AuthorEntity authorEntity);
        void UpdateAuthor(AuthorEntity authorEntity);
        bool AuthorExists(Guid authorId);
        IEnumerable<BookEntity> GetBooksForAuthor(Guid authorId);
        BookEntity GetBookForAuthor(Guid authorId, Guid bookId);
        void AddBookForAuthor(Guid authorId, BookEntity bookEntity);
        void DeleteBook(BookEntity bookEntity);
        void UpdateBookForAuthor(BookEntity bookEntity);
        bool BookExists(Guid bookId);
        bool Save();
    }
}
