//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Roadworking;

namespace Eco.EM.Building.Roadworking.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class CustomerParkingSignRecipeOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(CustomerParkingSignRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(CustomerParkingSignRecipe).Name,
            Assembly = typeof (CustomerParkingSignRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("WoodBoard", true, 8),
                new EMIngredient("IronBarItem", false, 4),
                new EMIngredient("BluePaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("CustomerParkingSignItem"),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "AnvilItem",   // Crafting Station Must Use Item not Object!
        };
    }
}
