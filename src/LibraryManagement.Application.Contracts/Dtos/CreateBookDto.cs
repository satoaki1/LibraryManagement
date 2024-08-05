using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using LibraryManagement.Enums;

namespace LibraryManagement.Dtos
{
	public class CreateBookDto
	{
        [Required]
        [StringLength(20)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Required]
        [StringLength(50)]
        public string Publisher { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        [Required]
        public int PageCount { get; set; }

        [Required]
        public BookGenre Genre { get; set; }

        [Required]
        public BookFormat Format { get; set; }

        [Required]
        public BookStatus Status { get; set; }

        [Required]
        [StringLength(20)]
        public string Language { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int CopiesAvailable { get; set; }

        [Required]
        [StringLength(100)]
        public string Location { get; set; }

        [Required]
        public List<string> Tags { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? LastBorrowedDate { get; set; }
    }
}

