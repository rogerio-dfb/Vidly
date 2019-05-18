﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number In Stock")]
        [Range(1,20,ErrorMessage =("The Number in Stock must between 1 and 20."))]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }

        [Display(Name ="Genre")]
        [Required]
        public byte GenreId { get; set; }
    }
}