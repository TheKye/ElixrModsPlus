//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, Bricks Namespace for Recipe finding
using Eco.EM.Building.Bricks;

namespace Eco.EM.Building.Bricks.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class RedGlassOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(RedBrickRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(RedBrickRecipe).Name,
            Assembly = typeof(RedBrickRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("ClayItem", false, 6),
                new EMIngredient("MortarItem", false, 24),
                new EMIngredient("RedPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("RedBrickItem", 6),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "KilnItem",
        };
        public bool debug => false;
    }
}
