using System;
using System.Collections.Generic;
using System.Linq;
using Library.API.Entities;

namespace Library.API.Services
{
    public class LibraryRepository : ILibraryRepository
    {
        public LibraryRepository(LibraryContext context)
        {
            _context = context;
        }

        public void AddAuthor(AuthorEntity authorEntity)
        {
            authorEntity.Id = Guid.NewGuid();
            _context.Authors.Add(authorEntity);

            // the repository fills the id (instead of using identity columns)
            if (!authorEntity.Books.Any())
                return;

            foreach (var book in authorEntity.Books)
                book.Id = Guid.NewGuid();
        }

        public void AddBookForAuthor(Guid authorId, BookEntity bookEntity)
        {
            var author = GetAuthor(authorId);
            if (author == null)
                return;

            // if there isn't an id filled out (ie: we're not upserting),
            // we should generate one
            if (bookEntity.Id == Guid.Empty)
                bookEntity.Id = Guid.NewGuid();
            author.Books.Add(bookEntity);
        }

        public bool AuthorExists(Guid authorId) =>
            _context.Authors.Any(author => author.Id == authorId);

        public void DeleteAuthor(AuthorEntity authorEntity) =>
            _context.Authors.Remove(authorEntity);

        public void DeleteBook(BookEntity bookEntity) =>
            _context.Books.Remove(bookEntity);

        public AuthorEntity GetAuthor(Guid authorId) =>
            _context.Authors.FirstOrDefault(author => author.Id == authorId);

        public IEnumerable<AuthorEntity> GetAuthors() =>
            _context.Authors.OrderBy(author => author.FirstName).ThenBy(author => author.LastName);

        public IEnumerable<AuthorEntity> GetAuthors(IEnumerable<Guid> authorIds) =>
            _context
                .Authors
                .Where(author => authorIds.Contains(author.Id))
                .OrderBy(author => author.FirstName)
                .ThenBy(author => author.LastName)
                .ToList();

        public void UpdateAuthor(AuthorEntity authorEntity)
        {
            // no code in this implementation
        }

        public BookEntity GetBookForAuthor(Guid authorId, Guid bookId) =>
            _context
                .Books
                .FirstOrDefault(book => book.AuthorId == authorId && book.Id == bookId);

        public IEnumerable<BookEntity> GetBooksForAuthor(Guid authorId) =>
            _context
                .Books
                .Where(book => book.AuthorId == authorId)
                .OrderBy(book => book.Title)
                .ToList();

        public void UpdateBookForAuthor(BookEntity bookEntity)
        {
            // no code in this implementation
        }

        public bool BookExists(Guid bookId) =>
            _context.Books.Any(book => book.Id == bookId);

        public bool Save() =>
            _context.SaveChanges() >= 0;

        //

        private readonly LibraryContext _context;
    }
}
