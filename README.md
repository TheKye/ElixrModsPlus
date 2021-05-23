# ElixrModsPlus
The Elixr Mods Plus is a Bridge System between Elixr Mods Modules for the Game Eco

This project will not accept Pull Requests, While open source it is designed this way so you can make a fork and adjust the recipes too your liking, 

The Plus Modules are only recipe overrides at this time, they add a bridge between other elixr mods modules, while the default plus modules 
are not very extensive and you will be familliar with the recipes, you are free to fork this repo and customize them however you like!

you can even use these to bridge other mods to the elixr mods modules! Thats right! something like the beekeeping mod can be bridged with the EM Food module with the recipe overrides allowing you too use their honey in our food recipes instead of our own, the possibilites are endless with these modules! chop and change them however you like, 

we hope you have fun chopping and changing the modules how you like them!

This is also our solution to allowing you to edit the recipes! so with a fork you can remove some dependencies ( so long as its not the main one ) and just override the original recipe!

## The Aim

Elixr Mods Plus is our way of allowing you to configure our mods through the mod hook overrides allowing you to tailor out packs to your server easily without a bunch of config files too raught through or any confusing bs

Simple open the project in an IDE of your choice (We use Visual Studios 2019) and start editing the recipes, 

All Eco DLLs needed are included in the project and should be attached to each project allowing you to easily build and distribute your own version of the plus modules

Thanks to the nuget packages of the Elixr Mods Modules these can be easily updated just by using nuget update! 

When the Eco Dlls are added to nuget we will also change to using nuget for those to make life even easier!

## Requirements

Below you will see the nuget references that can not be removed from each module so they work in your forks and with the intended module:

The requirements listed here are not optional. they must be included to work.

EM Storage Plus - Requires ElixrMods.Storage nuget

EM Green Energy Plus - Requires ElixrMods.GreenEnergy nuget

EM Doors Plus - Requires ElixrMods.Doors nuget

EM Food Plus - Requires ElixrMods.Food nuget

EM Games Plus - Requires ElixrMods.Games nuget

EM Home Objects Plus - Requires ElixrMods.HomeObjects nuget

EM Transportation Plus - Requires ElixrMods.Transportation nuget

EM Windows Plus - Requires ElixrMods.Windows nuget

