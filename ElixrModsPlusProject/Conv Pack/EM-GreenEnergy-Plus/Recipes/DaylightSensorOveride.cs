using Eco.EM.GreenEnergy;
using Eco.EM.ModTools.RecipeResolver;
using Eco.Gameplay.Items;
using Eco.Mods.TechTree;
using Eco.Shared.Localization;
using System.Collections.Generic;

namespace Eco.EM.Overrides
{
    public class DaylightSensorWallOverrideRecipe: IRecipeOverride
    {
        public static Type OverrideType => typeof(DaylightSensorWallRecipe);

        public static List<Recipe> NewRecipe => new List<Recipe>() 
        {
            new Recipe(
            "TheBob",
            Localizer.DoStr("The Bob"),
            new IngredientElement[]
            {
                new IngredientElement("WoodBoard", 10),
            },
            new CraftingElement<DaylightSensorWallItem>(1)
            )
        };        
    }
}
