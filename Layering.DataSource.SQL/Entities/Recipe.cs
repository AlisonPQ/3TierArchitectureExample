using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Layering.DataSource.SQL.Entities
{
    public class Recipe
    {
        [Key]
        public Int32 RecipeId { get; set; }
        [Required]
        public string RecipeName { get; set; }
        [Required]
        public Int32 ProductRefId { get; set; }
    }
}
