﻿using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
    public abstract record HamsterForManipulationDto
    {
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        [MinLength(1, ErrorMessage = "Minimum length for the Name is 1 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is a required field.")]
        [Range(0, 5, ErrorMessage = "Age must be between 0 and 5.")]
        public int Age { get; set; }

        [StringLength(20, ErrorMessage = "Favourite food too long")]
        public string? FavouriteFood { get; set; }

        [StringLength(20, ErrorMessage = "Favourite activity too long")]
        public string? FavouriteActivity { get; set; }
        public string ImageName { get; set; }
        public int Wins { get; set; }
        public int Defeats { get; set; }
        public int Games { get; set; }
        public int Likes { get; set; }
    }
}
