using Eco.EM.Framework.Resolvers;
using System;
using Eco.EM.Food.Zymology;

namespace NoMoreBooks_Eco.EM.Zymology
{
    public partial class DefaultZymologyBookOverride : IRecipeOverride
    {
        public string OverrideType => typeof(ZymologySkillBookRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(ZymologySkillBook).Name,
            Assembly = typeof(ZymologySkillBook).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("Lumber", true, 40),
                new EMIngredient("MortarItem", false, 50),
                new EMIngredient("ClothItem", false, 20),
                new EMIngredient("VegetableSoupItem", false, 10),
                new EMIngredient("CulinaryResearchPaperBasicItem", false, 5)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("ZymologySkillScroll", 1),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            BaseExperienceOnCraft = 1,
            BaseLabor = 2000,
            LaborIsStatic = true,
            BaseCraftTime = 15,
            CraftTimeIsStatic = true,
            CraftingStation = "ResearchTableItem",
        };

        public bool debug => false;
    }
}
