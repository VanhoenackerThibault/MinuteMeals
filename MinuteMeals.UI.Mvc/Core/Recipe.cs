using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MinuteMeals.UI.Mvc.Core
{
    public class Recipe
    {

        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Ingredients { get; set; }
        public required string Steps { get; set; }
        public int CookingTimeInMinutes { get; set; }
    }
}
