//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Windows;

namespace Eco.EM.Building.Windows.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class BlackGlassRecipeOverride : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(BlackGlassRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(BlackGlassRecipe).Name,
            Assembly = typeof(BlackGlassRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("GlassItem", false, 6, true),
                new EMIngredient("BlackDyeItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("GlassBlackItem", 6),
            },

            //This is the Parent Recipe, Here we must be sure to redefine the default settings so they apply like they normally would, all values here can be changed
            BaseExperienceOnCraft = 1,      // Experience Multiplier
            BaseLabor = 50,                 //Labor cost for crafting
            LaborIsStatic = false,          // Requires skill or not
            BaseCraftTime = 2,           // Time to craft
            CraftTimeIsStatic = false,      // Can craft time be affected by skill talents
            CraftingStation = "GlassworkingTableItem",   // Crafting Station Must Use Item not Object!
        };
        public bool debug => false;
    }

    public partial class AltBlackGlassRecipeOverride : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(AltBlackGlassRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(AltBlackGlassRecipe).Name,
            Assembly = typeof(AltBlackGlassRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("SandItem", false, 24),
                new EMIngredient("CrushedLimestoneItem", false, 6, true),
                new EMIngredient("BlackDyeItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("GlassBlackItem", 6),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "GlassworkingTableItem",   // Crafting Station Must Use Item not Object!
        };

        public bool debug => false;
    }
}
