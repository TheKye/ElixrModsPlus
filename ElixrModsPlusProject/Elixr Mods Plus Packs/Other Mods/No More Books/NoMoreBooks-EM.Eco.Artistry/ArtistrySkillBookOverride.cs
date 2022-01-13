using Eco.EM.Artistry;
using Eco.EM.Framework.Resolvers;
using System;

namespace NoMoreBooks_EM.Eco.Artistry
{
    public partial class DefaultPaintingBookOverride : IRecipeOverride
    {
        public string OverrideType => typeof(PaintingSkillBookRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(PaintingSkillBook).Name,
            Assembly = typeof(PaintingSkillBook).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("PaperItem", false, 40),
                new EMIngredient("ClothItem", false, 10),
                new EMIngredient("WoodBoard", true, 20),
                new EMIngredient("Basic Research", true, 5)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("PaintingSkillScroll", 1),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "ResearchTableItem",
        };

        public bool debug => false;
    }
}