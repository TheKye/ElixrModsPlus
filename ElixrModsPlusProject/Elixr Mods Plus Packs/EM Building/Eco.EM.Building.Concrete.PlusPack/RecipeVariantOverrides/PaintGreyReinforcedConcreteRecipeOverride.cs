//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Concrete;

namespace Eco.EM.Building.Concrete.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class PaintGreyReinforcedConcreteOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(PaintGreyReinforcedConcreteRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(PaintGreyReinforcedConcreteRecipe).Name,
            Assembly = typeof(PaintGreyReinforcedConcreteRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("ReinforcedConcreteItem", false, 4, true),
                new EMIngredient("GreyPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("GreyReinforcedConcreteItem", 4),
            },

            //This is the Parent Recipe, Here we must be sure to redefine the default settings so they apply like they normally would, all values here can be changed
            BaseExperienceOnCraft = 1,          // Experience Multiplier
            BaseLabor = 50,                     //Labor cost for crafting
            LaborIsStatic = false,              // Requires skill or not
            BaseCraftTime = 1,                  // Time to craft
            CraftTimeIsStatic = false,          // Can craft time be affected by skill talents
            CraftingStation = "CementKilnItem",       // Crafting Station Must Use Item not Object!
        };
    }
}
