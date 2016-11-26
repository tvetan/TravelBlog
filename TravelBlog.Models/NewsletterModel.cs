﻿using System.ComponentModel.DataAnnotations;

namespace TravelBlog.Models
{
    public class NewsletterModel : BaseModel
    {
        [Required]
        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$")]
        public string Email { get; set; }
    }
}
