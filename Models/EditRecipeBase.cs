using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace RecipeApp.Models
{
    public class EditRecipeBase
    {
        [Required, StringLength(100)]
        public string Name { get; set; }

        [Range(0, 24), DisplayName("Time to cook (hrs)")]
        public int TimeToCookHrs { get; set; }

        [Range(0, 59), DisplayName("Time to cook (mins)")]
        public int TimeToCookMins { get; set; }

        [Required]
        public string Method { get; set; }

        [DisplayName("Vegetarian?")]
        public bool IsVegetarian { get; set; }

        [DisplayName("Vegan?")]
        public bool IsVegan { get; set; }

        [Required(ErrorMessage = "กรุณาเลือกประเภทอาหาร")]
        [DisplayName("ประเภทอาหาร")]
        public string Category { get; set; }
    }
}