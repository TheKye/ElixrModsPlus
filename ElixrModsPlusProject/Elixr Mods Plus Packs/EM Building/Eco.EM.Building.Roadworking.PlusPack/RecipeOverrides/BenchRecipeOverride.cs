//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Roadworking;

namespace Eco.EM.Building.Roadworking.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class BenchRecipeOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(BenchRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(BenchRecipe).Name,
            Assembly = typeof (BenchRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("Lumber", true, 20, true),
                new EMIngredient("IronBarItem", false, 4),
                new EMIngredient("RivetItem", false, 20),
                new EMIngredient("BrownPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("BenchItem"),
            },

            //This is the Parent Recipe, Here we must be sure to redefine the default settings so they apply like they normally would, all values here can be changed
            BaseExperienceOnCraft = 1,      // Experience Multiplier
            BaseLabor = 250,                 //Labor cost for crafting
            LaborIsStatic = false,          // Requires skill or not
            BaseCraftTime = 5,           // Time to craft
            CraftTimeIsStatic = false,      // Can craft time be affected by skill talents
            CraftingStation = "SawmillItem",   // Crafting Station Must Use Item not Object!
        };
        public bool debug => false;
    }
}
