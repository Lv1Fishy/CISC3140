## 3/31/2025 Jiahui Yu ##
Added "documentation.md" to notes
Detailing the explanation and plan of our project

## 4/2/2025 Jiahui Yu ##
Setting up the Unity Project such that changes made in Unity is ready for commits
i.e. no need for manual changes, changes in unity mean changes in repository.

    -   In Unity Project, added a few folders for future uses where we organize Prefabs, Scripts, and Scenes
    -   Future folders may be needed such as packages, assets, animations, etc. As of now, we start simple.
    -   <IMPORTANT> When creating a scene, make sure to build that scene on the top left corner of Unity Editor
        (file -> Build Profiles -> Scene List -> Add Open Scenes)
        Make sure that the scene you want to build is opened in the editor
        
## 4/2/2025 Oscar Huang ##
Added "Link" to notes \
Listing all the links we'll be using for this projects

## 4/6/2025 Jiahui Yu ##
Created a bunch of more folders in the "Prefab" folder for future uses \
Created a player script for simple movement, allows for the player object to move around

## 4/7/2025 Jiahui Yu ##
Created a persistent data script to keep track of the player's stats \
Added a script where the camera follows the player object \
Began developing the player's inventory UI

## 4/8/2025 Jiahui Yu ##
Worked on the Inventory UI, added a bunch of visual icons. \
Scripts for Inventory UI and items requires further coding or may need to be scrapped.

## 4/9/2025 Jiahui ##
Continued working on the Inventory UI, scrapped the scripts for Item and Inventory UI

## 4/9/2025 Oscar Huang ##
Updated Link to Link.md \
Updated and added new link and link to asset packs into the file \
Implementing asset pack into the project. \

-- Project (I DID NOT PUSH THIS TO GITHUB YET)-- \
-IMPORTANT NOTE- Currently this project is 16 pixel, if i should change it let me know
 -   Created a file called Tileset
       - Tileset -> To store different tiles to use to create the map
         
 -   Created 6 different Layers (Just a label for objects)
       - Ground -> Flooring of the map
       - WalkinFront -> Actions of walking in front of an object
       - Collision   -> Player collision against object
       - Player      -> How the player react
       - WalkBehind  -> Action of walking behind buildings or objects
       - Decor       -> Decoration

## 4/10/2025 Jiahui Yu ##
Added a functional Draggable item and Inventory Slot Scripts

## 4/10/2025 Oscar Huang ##
Created a personal branch \
Finally pushed the project to my branch \
I've only created a small path for now \

## 4/11/2025 Jiahui Yu ## 
Added the functionality of items being able to be dragged from one inventory slot to another

## 4/12/2025 Jiahui Yu ##
Added a bunch of consumable items, need to fix the issue of images showing up as canvas and sprite renderers as in game objects. Need an Inventory Manager script to handle the player inventory such as adding a backpack increases the list size.

## 4/12/2025 Oscar Huang ##
Updated the map (map is bigger and more decorated) \
Added new files
- ReliefPalette -> Hill tileset
- WaterPalette -> Pond tileset
- NaturePalette -> Nature tileset
    
## 4/13/2025 Jiahui Yu ##
Working on the Inventory Manager script, need to fix the bug on items being able to swap places with backpack slot when it is in backpack slot and nearby slot

## 4/14/2025 Jiahui Yu ##
Fixed the backpack slot bug; added some items images (throwables), items need functionality images
Merged my branch with Oscar's branch as checkpoint, need to resolve the issue with player and canvas not showing up when on Oscar's map

## 4/15/2025 Jiahui Yu ##
Resolved the issue with the player and canvas not showing up in Oscar's map. The problem was with the sorting layer where the player object in the Sprite Renderer has its sorting layer set to default. The issue was also the same with the canvas sortin layer.
