using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.API.Entities
{
    public class AuthorEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        [MaxLength(50)]
        public string Genre { get; set; }

        public ICollection<BookEntity> Books { get; set; } = new List<BookEntity>();
    }
}
