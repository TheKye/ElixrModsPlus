using Eco.EM.Framework.Resolvers;
using Eco.EM.Artistry;
using Eco.EM.Building.Windows;

namespace Eco.EM.Building.Windows.Plus
{
    public partial class BlackGlassOverrideRecipe : IRecipeOverride
    {
        public string OverrideType => typeof(BlackGlassRecipe).Name;
        public RecipeModel Model => new()
        {
            ModelType = typeof(BlackGlassRecipe).Name,
            Assembly = typeof(BlackGlassRecipe).AssemblyQualifiedName,
            IngredientList = new()
            {
                new EMIngredient("GlassItem", false, 6, true),
                new EMIngredient("BlackDyeItem", false, 1, true)
            },
            ProductList = new()
            {
                new EMCraftable("GlassBlackItem", 6),
            },
            BaseExperienceOnCraft = 1,
            BaseLabor = 50,
            LaborIsStatic = false,
            BaseCraftTime = 2,
            CraftTimeIsStatic = false,
            CraftingStation = "GlassworkingTableItem",
        };

        public bool debug => false;
    }
}
