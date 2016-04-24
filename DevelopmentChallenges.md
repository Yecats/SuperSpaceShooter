# Development Challenges
The following is a list of development challenges to enhance Super Space Shooter and continue learning the Unity engine. Scenarios have been ranked in difficulty.

## Player Lives
**Difficulty:** Easy

**Skills:** Coding

The player has 3 lives and once killed should respawn if they have additional lives left. 

## Shield Behavior (Player and Enemy)
**Difficulty:** Easy

**Skills:** Animation, Coding, Sound

Create a shield that allows 

## Power Ups
**Difficulty:** Medium - Hard

**Skills:** Animation, Coding

## Break Apart Models
**Difficulty:** Easy

**Skills:** Animation, Coding


## Additional Weapons
**Difficulty:** Medium

**Skills:** Animation, Coding, Sound

## Better Spawn Logic
**Difficulty:** Medium

**Skills:** Coding

The current game logic is to have the AI spawn rate based on a result of ``` Random.Range(3,10);```. This can lead to boring gameplay if the rate takes too long and the player has killed all of the enemies. Additionally, it completely randomly selects the enemy type to spawn. 

To address this, the range of the spawn rate should factor in the amount and types of enemy AI that are present. For example, if the game currently has 3 heavily shielded enemies, it could either slow it's respawn rate down or respawn with an emeny that dies quickly.

