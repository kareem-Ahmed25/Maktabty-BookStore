using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Maktabty.Models
{
    public class Category
    {
       
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name="Category Name")]
        public string Name { get; set; } = string.Empty;
        [Display(Name = "Display Order")]
        //[ValidateNever]
        [Range(1, 100, ErrorMessage = "Display order must be between 1 and 100")]
        public int? DisplayOrder { get; set; }

    }
}
