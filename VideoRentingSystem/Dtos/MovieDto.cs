﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VideoRentingSystem.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte? GenreId { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
    }
}