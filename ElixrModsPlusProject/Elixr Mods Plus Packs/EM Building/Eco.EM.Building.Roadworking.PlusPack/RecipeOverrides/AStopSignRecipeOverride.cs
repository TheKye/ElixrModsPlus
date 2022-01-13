//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Roadworking;

namespace Eco.EM.Building.Roadworking.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class AStopSignRecipeOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(StopSignRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(StopSignRecipe).Name,
            Assembly = typeof (StopSignRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("WoodBoard", true, 8),
                new EMIngredient("IronBarItem", false, 4),
                new EMIngredient("RedPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("AStopSignItem"),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "AnvilItem",   // Crafting Station Must Use Item not Object!
        };
        public bool debug => false;
    }
}
