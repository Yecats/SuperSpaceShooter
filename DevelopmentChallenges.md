# Development Challenges
The following is a list of development challenges to enhance Super Space Shooter and continue learning the Unity engine. Each challenge is a feature that is being added or enhanced to build the game up to draw the player in. By the end of the challenges you'll have a complete space shooter game with better visuals, power ups, customizations, player profiles and AI improvements.

*Note: Some challanges may depend on another being completed. For example, achievements depend on a player profile.*

## Easy Challenges
### Better Game Over Behavior
**Difficulty:** Easy   |   **Skills:** Scripting, User Interface

The game over logic in Super Space Shooter returns the player to the main screen. This can be enahnced for a better flow by doing simple things such as:

* Changing the text of the "Play" button to say "Retry"
* Displaying the final score on the main screen

### Better Game Start Behavior
**Difficulty:** Easy   |   **Skills:** Scripting, User Interface
Timer.

### Player Lives
**Difficulty:** Easy   |   **Skills:** Scripting, User Interface

The player can be hit three times and once killed should respawn if they have additional lives left. With this challenge you'll need to modify the code to account for having lives in addition to having health. The lives left should be displayed visually to the player. 

### Add Shields
**Difficulty:** Easy   |   **Skills:** Animation, Scripting, Sound

### Break Apart Models
**Difficulty:** Easy   |   **Skills:** Animation, Scripting

### Block AI and Players From Leaving the Screen
**Difficulty:** Easy   |   **Skills:** Scripting, User Interface

Currently players and AI can move off of the camera's view. This should be corected so that they cannot move off of the screen. [Screen](http://docs.unity3d.com/ScriptReference/Screen.html) and [Mathf.Clamp](http://docs.unity3d.com/ScriptReference/Mathf.Clamp.html) are going to be very helpful for this. 

## Medium Challenges
### Add Touch-Input for a Mobile Device
**Difficulty:** Medium   |   **Skills:** Scripting

Super Space Shooter does not take into consideration the possibility that someone might use their fingers to provide it input, rather than the mouse and keboard. This is a very common scenario for mobile devices and can be solved fairly easily.

The "[Mobile Device Input](Mobile Device Input)" manual entry will be key in understanding how input works within Unity. You'll also need to work with the [Input](http://docs.unity3d.com/ScriptReference/Input.html) class.

### Add Power Ups
**Difficulty:** Medium   |   **Skills:** Animation, Scripting

Power-Ups enhance the game play by giving the player something that is different and interesting. They typically respawn randomly around the game screen. Some power-up ideas are:

* A shield energy replenisher.
* Advanced weapons that run out.
* Refill the ship's hit points.

### Add Weapons
**Difficulty:** Medium   |   **Skills:** Animation, Scripting, Sound

### Better Spawn Logic
**Difficulty:** Medium   |   **Skills:** Scripting

The current game logic is to have the AI spawn rate based on a result of ``` Random.Range(3,10)```. This can lead to boring gameplay if the rate takes too long and the player has killed all of the enemies. Additionally, it randomly selects the enemy type to spawn. 

To address this, the range of the spawn rate should factor in the amount and types of enemy AI that are present. For example, if the game currently has 3 heavily shielded enemies, it could either slow it's respawn rate down or respawn with an enemy that dies quickly.

## Hard Challenges
### Player Profiles
**Difficulty:** Hard   |   **Skills:** Scripting, User Interface

Player profiles are an excellent way to draw your players into your game. Profiles can store achievements, customization unlocks, friends, etc. In Super Space Shooter, the player profile challenge would lay the ground work for future enhancements to occur. That means that it would handle connecting to a service or local database in order to store information. The remaining 'hard' challenges will use this feature in order to fully function. 

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

### Achievements
**Difficulty:** Hard   |   **Skills:** Scripting, User Interface

Achievements are a very common component of video games. With Super Space Shooter, players could earn achievements for attacking a certain amount and/or type of enemy. For example, there could be three achievments around killing a "Small Enemy" unlocked at the 10, 50 and 100 kill mark.

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

### Ship Customization
**Difficulty:** Hard   |   **Skills:** Scripting, User Interface

There's only one player ship and weapon combination available to players. This could be expanded to let players choose the color, model and weapon combination for their ship. If this feature was integrated with the Player Profile and Achievement challenges, it could be enhanced to unlock new customization skins based on when an achievement has been earned.

### Leaderboard
**Difficulty:** Hard   |   **Skills:** Scripting, User Interface

Players earn points based on the amount of enemies that they have killed. Once they die, their information should be logged into a leaderboard. This logic could be based off of whether or not they made the top X of the list or it could be a long running history. 

*Note: Some external services you could integrate with are [Google Play](https://play.google.com/apps/publish) or [PlayFab](https://playfab.com/).*

