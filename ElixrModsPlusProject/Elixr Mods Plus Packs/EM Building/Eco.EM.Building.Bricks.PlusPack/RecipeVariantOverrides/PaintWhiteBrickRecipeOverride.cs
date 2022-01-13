//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, Bricks Namespace for Recipe finding
using Eco.EM.Building.Bricks;

namespace Eco.EM.Building.Bricks.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class PaintWhiteGlassOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(PaintWhiteBrickRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(PaintWhiteBrickRecipe).Name,
            Assembly = typeof(PaintWhiteBrickRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("BrickItem", false, 6, true),
                new EMIngredient("WhitePaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("WhiteBrickItem", 6),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "KilnItem",
        };
        public bool debug => false;
    }
}
