﻿//EM Framework Resolvers Reference to override the recipe
using Eco.EM.Framework.Resolvers;

// Artistry Namespace for linking
using Eco.EM.Artistry;

// EM Building, ReinforcedConcretes Namespace for Recipe finding
using Eco.EM.Building.Concrete;

namespace Eco.EM.Building.Concrete.PlusPack
{
    //Our New Recipe using the IRecipeOverride Interface
    public partial class BlueReinforcedConcreteOverrideRecipe : IRecipeOverride
    {
        //Recipe We are Overriding
        public string OverrideType => typeof(BlueReinforcedConcreteRecipe).Name;
        public RecipeModel Model => new()
        {
            //Required for internal referencing
            ModelType = typeof(BlueReinforcedConcreteRecipe).Name,
            Assembly = typeof(BlueReinforcedConcreteRecipe).AssemblyQualifiedName,

            // List of new ingredients using the EM Ingredient
            IngredientList = new()
            {
                new EMIngredient("CementItem", false, 1),
                new EMIngredient("RebarItem", false, 2),
                new EMIngredient("SandItem", false, 2),
                new EMIngredient("CrushedRock", true, 5),
                new EMIngredient("BluePaintItem", false, 1, true)
            },

            // List of new Products to output
            ProductList = new()
            {
                new EMCraftable("BlueReinforcedConcreteItem", 4),
            },

            //Recipe is a Variant of a Parent Recipe, Only Crafting Table is needed
            CraftingStation = "CementKilnItem",
        };
    }
}
