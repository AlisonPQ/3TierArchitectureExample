namespace Layering.DataSource.SQL.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Product
    {
        [Key]
        public Int32 ProductId { get; set; }
        [Required]
        public String ProductName { get; set; }
        [ForeignKey("ProductRefId")]
        public ICollection<Recipe> Recipes { get; set; }
    }
}
