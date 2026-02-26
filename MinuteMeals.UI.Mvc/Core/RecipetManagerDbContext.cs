using Microsoft.EntityFrameworkCore;

namespace MinuteMeals.UI.Mvc.Core
{
    public class RecipetManagerDbContext(DbContextOptions<RecipetManagerDbContext> options) : DbContext(options)
    {
        public DbSet<Recipe> Recipes => Set<Recipe>();
        public void GenerateDemoData()
        {

            List<Recipe> recipes = new List<Recipe>
            {
                new()
                {
                    Name = "Spaghetti Bolognese",
                    Ingredients = "Spaghetti, minced beef, onion, garlic, tomato sauce, olive oil, salt, pepper",
                    Steps = "1. Cook spaghetti. 2. Brown the beef. 3. Add onion and garlic. 4. Stir in tomato sauce. 5. Combine and serve.",
                    CookingTimeInMinutes = 30
                },
                new()
                {
                    Name = "Chicken Curry",
                    Ingredients = "Chicken breast, curry paste, coconut milk, onion, garlic, rice",
                    Steps = "1. Cook rice. 2. Cook chicken. 3. Add onion and garlic. 4. Stir in curry paste and coconut milk. 5. Simmer and serve.",
                    CookingTimeInMinutes = 40
                },
                new()
                {
                    Name = "Pancakes",
                    Ingredients = "Flour, milk, eggs, sugar, butter",
                    Steps = "1. Mix ingredients. 2. Heat pan. 3. Pour batter. 4. Flip when bubbles form. 5. Serve warm.",
                    CookingTimeInMinutes = 20
                },
                new()
                {
                    Name = "Caesar Salad",
                    Ingredients = "Lettuce, chicken, croutons, parmesan, Caesar dressing",
                    Steps = "1. Grill chicken. 2. Chop lettuce. 3. Mix ingredients. 4. Add dressing and toss.",
                    CookingTimeInMinutes = 15
                },
                new()
                {
                    Name = "Beef Tacos",
                    Ingredients = "Taco shells, minced beef, lettuce, tomato, cheese, taco seasoning",
                    Steps = "1. Cook beef with seasoning. 2. Prepare vegetables. 3. Fill taco shells. 4. Serve.",
                    CookingTimeInMinutes = 25
                },
                new()
                {
                    Name = "Vegetable Stir Fry",
                    Ingredients = "Broccoli, carrot, bell pepper, soy sauce, garlic, noodles",
                    Steps = "1. Cook noodles. 2. Stir fry vegetables. 3. Add garlic and soy sauce. 4. Combine and serve.",
                    CookingTimeInMinutes = 20
                },
                new()
                {
                    Name = "Tomato Soup",
                    Ingredients = "Tomatoes, onion, garlic, vegetable broth, cream, salt, pepper",
                    Steps = "1. Cook onion and garlic. 2. Add tomatoes and broth. 3. Simmer. 4. Blend. 5. Add cream and serve.",
                    CookingTimeInMinutes = 35
                },
                new()
                {
                    Name = "Grilled Cheese Sandwich",
                    Ingredients = "Bread, cheese, butter",
                    Steps = "1. Butter bread. 2. Add cheese. 3. Grill until golden brown.",
                    CookingTimeInMinutes = 10
                }
            };

            Recipes.AddRange(recipes);

            SaveChanges();
        }
    }
    
}
