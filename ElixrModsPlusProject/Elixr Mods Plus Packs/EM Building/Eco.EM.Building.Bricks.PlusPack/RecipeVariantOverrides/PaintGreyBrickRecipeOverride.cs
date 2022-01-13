//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, Bricks Namespace for Recipe finding
using Eco.EM.Building.Bricks;

namespace Eco.EM.Building.Bricks.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class PaintGreyGlassOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(PaintGreyBrickRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(PaintGreyBrickRecipe).Name,
            Assembly = typeof(PaintGreyBrickRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("BrickItem", false, 6, true),
                new EMIngredient("GreyPaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("GreyBrickItem", 6),
            },

            //This is the Parent Recipe, Here we must be sure to redefine the default settings so they apply like they normally would, all values here can be changed
            BaseExperienceOnCraft = 1,          // Experience Multiplier
            BaseLabor = 40,                     //Labor cost for crafting
            LaborIsStatic = false,              // Requires skill or not
            BaseCraftTime = 4,                  // Time to craft
            CraftTimeIsStatic = false,          // Can craft time be affected by skill talents
            CraftingStation = "KilnItem",       // Crafting Station Must Use Item not Object!
        };
        public bool debug => false;
    }
}
