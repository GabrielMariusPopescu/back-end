using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.API.Entities
{
    public class BookEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [ForeignKey("AuthorId")]
        public AuthorEntity AuthorEntity { get; set; }

        public Guid AuthorId { get; set; }
    }
}
