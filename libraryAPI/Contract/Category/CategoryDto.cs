﻿using System.ComponentModel.DataAnnotations;

namespace libraryAPI.Contract.Category
{
    public record CategoryDto
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
