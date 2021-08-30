# ElixrModsPlus
The Elixr Mods Plus is a Bridge System between Elixr Mods Modules for the Game Eco as well as other Mods!

This project will not accept Pull Requests, While open source it is designed this way so you can make a fork and use it as a base for your own versions!

We May also include some default Elixr Mods Plus Modules for some of our mods that used to depend on the Artistry Mod!

The purpose of this repo and this system is to make your life, Server owners lives easier and our mods more configurable! 

## The Aim

Elixr Mods Plus is our way of allowing you to configure our mods through the EM Framework Recipe Resolver overrides allowing you to tailor out packs to your server easily without a bunch of config files too raught through or any confusing bs

Simply open the project in an IDE of your choice (We use Visual Studios 2019) and start editing/adding recipes, 

All Eco DLLs needed are included in the project and should be attached to each project allowing you to easily build and distribute your own version of the plus modules

Thanks to the nuget packages of the Elixr Mods Modules these can be easily updated just by using nuget update! 

When the Eco Dlls are added to nuget we will also change to using nuget for those to make life even easier!

## Important Notes

While the plus Modules or the IConfigurableRecipe allows you to override our Recipes the Server Owner has final say on the Recipe used as noted on the Documentation for the IConfigurableRecipe, so keep that in mind.

## Installation 

We Recommend installing the Plus Modules in the New Plus Modules Folder inside the Elixr Mods Folder Located: 

`Server/Mods/Elixr Mods/Plus Modules`

The Reason for this recomendation is so they Load Last, This way we can ensure that all the recipes you are overriding are loaded before it tries to override the recipe just incase of not found errors. 

## Uninstallation

Just goto: `Server/Mods/Elixr Mods/Plus Modules` and Remove the module you no longer want and that is it!

## Help

You make the Plus Modules at your own Risk, if they break your server we can't be held liable, However, we are not so mean as to say figure it out! 

While our Docs are In Progress, we have the EM Framework pretty well documented for you to make life easier! So any information you may need can be found in our [Docs]()!

If you are using an Elixr Mods built plus module and have a problem or its not working please leave a bug report in the [Issues](https://github.com/TheKye/ElixrModsPlus/issues) With Server Logs, All Mods you are using and Which Plus Modules you are using and we will try to help as best as we can

## Examples

For an Example on how this is Implemented and Used check out the [Example](https://github.com/TheKye/ElixrModsPlus/blob/Master/Examples/Info.MD)

