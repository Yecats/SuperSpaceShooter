# Development Challenges
The following is a list of development challenges to enhance Super Space Shooter and continue learning the Unity engine. Each challenge is a feature that is being added or enhanced to build the game up to draw the player in. By the end of the challenges you'll have a complete space shooter game with better visuals, power ups, customizations, player profiles and AI improvements.

**Note: Some challanges may depend on another being completed. For example, achievements depend on a player profile.**

## Easy Challenges
### Player Lives
**Difficulty:** Easy   |   **Skills:** Coding, User Interface

The player has 3 lives and once killed should respawn if they have additional lives left. 

### Add Shields
**Difficulty:** Easy   |   **Skills:** Animation, Coding, Sound


### Break Apart Models
**Difficulty:** Easy   |   **Skills:** Animation, Coding

## Medium Challenges
### Add Power Ups
**Difficulty:** Medium   |   **Skills:** Animation, Coding

### Add Weapons
**Difficulty:** Medium   |   **Skills:** Animation, Coding, Sound

### Better Spawn Logic
**Difficulty:** Medium   |   **Skills:** Coding

The current game logic is to have the AI spawn rate based on a result of ``` Random.Range(3,10)```. This can lead to boring gameplay if the rate takes too long and the player has killed all of the enemies. Additionally, it randomly selects the enemy type to spawn. 

To address this, the range of the spawn rate should factor in the amount and types of enemy AI that are present. For example, if the game currently has 3 heavily shielded enemies, it could either slow it's respawn rate down or respawn with an enemy that dies quickly.

## Hard Challenges
### Player Profiles
**Difficulty:** Hard   |   **Skills:** Coding, User Interface

Player profiles are an excellent way to draw your players into your game. Profiles can store achievements, customization unlocks, friends, etc. In Super Space Shooter, the player profile challenge would lay the ground work for future enhancements to occur. That means that it would handle connecting to a service or local database in order to store information. The remaining 'hard' challenges will use this feature in order to fully function. 

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

### Achievements
**Difficulty:** Hard   |   **Skills:** Coding, User Interface

Achievements are a very common component of video games. With Super Space Shooter, players could earn achievements for attacking a certain amount and/or type of enemy. For example, there could be three achievments around killing a "Small Enemy" unlocked at the 10, 50 and 100 kill mark.

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

### Ship Customization
**Difficulty:** Hard   |   **Skills:** Coding, User Interface

There's only one player ship and weapon combination available to players. This could be expanded to let players choose the color, model and weapon combination for their ship. If this feature was integrated with the Player Profile and Achievement challenges, it could be enhanced to unlock new customization skins based on when an achievement has been earned.

### Leaderboard
**Difficulty:** Hard   |   **Skills:** Coding, User Interface

Players earn points based on the amount of enemies that they have killed. Once they die, their information should be logged into a leaderboard. This logic could be based off of whether or not they made the top X of the list or it could be a long running history. 

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

