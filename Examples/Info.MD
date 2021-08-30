# Overriding An Existing Recipe with the EM Recipe Resolver

When using our Bridge Modules to override a recipe it can be very simple, there are a few steps but we will break it down for you!

!!Please Note!! In order to Override a Recipe with the Recipe Resolver the Target Recipe MUST be an IConfigurableRecipe! you can not just override another recipe that does not use the IConfigurableRecipe! So if you would like to use this method in a mod that does not support it you will need to speak with the mod author about them making the change!

HOWEVER! The mod you wish to use to ADD Items to an IConfigurableRecipe does not need to use anything from EM Framework, You can add any items from any other mod to an IConfigurableRecipe! Isn't that neat!

## Step 1 - Getting What You Need

One of the first things you will need is a mod to use, in our Case we are using 2 Different mods and using items from one in another.

We are using the: Eco.EM.Building.Windows mod that has the colored glass

And the Eco.EM.Artistry Mod that has the Dyes and Paint.

And by default to use the Recipe Resolver we need the Eco.EM.Framework Mod.

Thankfully the Eco.EM Mods will be available on Nuget so you can use nuget to add and manage the mods you are using, if you are using another mod you just need the mod DLL and add that reference to be able to change the recipes.

## Step 2 - Getting Ready

First we need to make a new project, in ECO 9.4.x we use .NET 5.0 so you will need to make a new .NET 5.0 Class Library and give it a name. 

Then we need to add a reference to: Eco.EM.Framework, Eco.EM.Artistry and Eco.EM.Building.Windows 

Once this is done we can make a new class file or a .cs file. 

We now only need to add these References ( Using these mods, others may be different so check with the author! )

```
using Eco.EM.Framework;
using Eco.EM.Framework.DataStructures;
using Eco.EM.Artistry;
using Eco.EM.Building.Windows;
```

This allows us to use the IRecipeOverride Interface used to override the recipes, as well as gives us access to the Other Namespaces to get the recipe to override and have the reference there to use the items from the Artistry Mod.

These 2 References here are the most important. They allow us to use the IRecipeOverride Interface and get the Data Structure used to Implement the interface

```
using Eco.EM.Framework;
using Eco.EM.Framework.DataStructures;
```

These 2 Namespaces gives us access to the Recipes and Items in these mods so we can override them

```
using Eco.EM.Artistry;
using Eco.EM.Building.Windows;
```

## Set 3 - Implementing the Interface

When we start to implement this interface we need to set it up very specfically to start with. 

We first make our partial class:

```
public partial class MyRecipeOverride : IRecipeOverride
{

}
```

The next part is we Implement the Interface to get everything we need:

```
public partial class MyRecipeOverride : IRecipeOverride
{
        public string OverrideType => typeof(RecipeToOverrideRecipe).Name;
        public RecipeModel Model => new()
        {
            ModelType = typeof(RecipeToOverrideRecipe).Name,
            Assembly = typeof(RecipeToOverrideRecipe).AssemblyQualifiedName,
            IngredientList = new()
            {
                new EMIngredient("FirstIngredientItem", false, 6,
                new EMIngredient("SecondIngredientItem", false, 1)
            },
            ProductList = new()
            {
                new EMCraftable("ReturningItem", 6),
            },
            BaseExperienceOnCraft = 1,
            BaseLabor = 50,
            LaborIsStatic = false,
            BaseCraftTime = 2,
            CraftTimeIsStatic = false,
            CraftingStation = "CraftingTableItem",
        };
}
```

The "RecipeToOverrideRecipe" is the Recipe class in the mod you wish to override, in our case we want to override the BlackGlassRecipe 

For all information on each part used in this interface and how everything is used properly please look at the EM Framework : IConfigurableRecipe Documentation

Next we use the EM Ingredient to add new items or even change the current recipes, but most of these can be done with the config file, Where in this case we want to add new items to the recipe.

For more information on the EMIngredient please check out the EM Framework : EMIngredient, EMCraftable Documentation

So we will use the original items in this case it will be the GlassItem and we will be adding the BlackDyeItem to the recipe so we have another item in the recipe to give it variety

We can also adjust other values here such as the Labor Cost and the craft time as well as the Crafting table the item is made at, 

So below here we will see our completed Class with the Recipe Override:

```
using Eco.EM.Framework;
using Eco.EM.Framework.DataStructures;
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
    }
}
```
