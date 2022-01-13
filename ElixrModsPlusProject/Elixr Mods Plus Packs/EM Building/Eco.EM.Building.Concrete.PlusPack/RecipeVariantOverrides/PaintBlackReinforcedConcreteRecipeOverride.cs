//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Concrete;

namespace Eco.EM.Building.Concrete.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class PaintBlackReinforcedConcreteOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(PaintBlackReinforcedConcreteRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(PaintBlackReinforcedConcreteRecipe).Name,
            Assembly = typeof(PaintBlackReinforcedConcreteRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("ReinforcedConcreteItem", false, 4, true),
                new EMIngredient("BlackPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("BlackReinforcedConcreteItem", 4),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "CementKilnItem",
        };
        public bool debug => false;
    }
}
