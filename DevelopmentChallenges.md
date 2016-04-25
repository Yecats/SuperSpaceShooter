# Development Challenges
The following is a list of development challenges to enhance Super Space Shooter and continue learning the Unity engine. Scenarios have been ranked in difficulty.

* [Easy Challenges](#easyStart)
* [Medium Challenges](#mediumStart)
* [Hard Challenges](#hardStart)

## [Break Apart Models](#easyStart)
**Difficulty:** Easy   |   **Skills:** Animation, Coding

## Player Lives
**Difficulty:** Easy   |   **Skills:** Coding, User Interface

The player has 3 lives and once killed should respawn if they have additional lives left. 

## Add Shields
**Difficulty:** Easy   |   **Skills:** Animation, Coding, Sound

Create a shield that allows 

## Add Power Ups
**Difficulty:** Medium   |   **Skills:** Animation, Coding

## Add Weapons
**Difficulty:** Medium   |   **Skills:** Animation, Coding, Sound

## [Better Spawn Logic](#mediumStart)
**Difficulty:** Medium   |   **Skills:** Coding

The current game logic is to have the AI spawn rate based on a result of ``` Random.Range(3,10)```. This can lead to boring gameplay if the rate takes too long and the player has killed all of the enemies. Additionally, it randomly selects the enemy type to spawn. 

To address this, the range of the spawn rate should factor in the amount and types of enemy AI that are present. For example, if the game currently has 3 heavily shielded enemies, it could either slow it's respawn rate down or respawn with an enemy that dies quickly.

## [Ship Customization](#hardStart)
**Difficulty:** Hard   |   **Skills:** Coding, User Interface

There's only one player ship and weapon combination available to players. This could be expanded to let players choose the color, model and weapon combination for their ship.

