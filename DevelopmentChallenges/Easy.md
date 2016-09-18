#Easy Development Challenges 
## Better Game Over Behavior
**Skills:** Scripting, User Interface | **Resources:** Text [Manual](http://docs.unity3d.com/Manual/script-Text.html) & [Script](http://docs.unity3d.com/ScriptReference/UI.Text.html), UI RectTransform [Video](https://unity3d.com/learn/tutorials/modules/beginner/ui/rect-transform?playlist=17111), UI Button [Video](https://unity3d.com/learn/tutorials/modules/beginner/ui/ui-button?playlist=17111), UI Text [Video](https://unity3d.com/learn/tutorials/modules/beginner/ui/ui-text?playlist=17111)

The game over logic in Super Space Shooter returns the player to the main screen. This can be enhanced for a better flow by doing simple things such as:

* Changing the text of the "Play" button to say "Retry". (It should still say "Play" when the game first launches.)
* Displaying the final score on the main screen.

<details> 
  <summary>**Hint 1**</summary>
   To change the text, you'll need to access the Text component. Look at the ```User Interface``` class for an example on how to do this.
</details>
<details> 
  <summary>**Hint 2**</summary>
   Buttons have a child game object that have a text component on them.
</details>
<details> 
  <summary>**Hint 3**</summary>
   Use the anchor points to move UI game objects around the canvas. Holding ctrl will let you keep the same sizing but reposition its location.  
</details>

## Better Game Start Behavior
**Skills:** Scripting, User Interface | 
**Resources:** Coroutine [Script](http://docs.unity3d.com/ScriptReference/Coroutine.html) & [Manual](http://docs.unity3d.com/Manual/Coroutines.html), Invoke [Script](http://docs.unity3d.com/ScriptReference/MonoBehaviour.Invoke.html)

The player is not given much time to prepare themselves for the battle that is about to begin. An easy way to give the player time to prepare is to provide them with a countdown before the ```GameManager``` class begins spawning the enemies. This can be done by using a [coroutine](http://docs.unity3d.com/Manual/Coroutines.html). 

Coroutines are similar to Invoking, which was used to spawn the enemies at a random rate. As you may recall, Invoking lets you call a method after a set amount of time (in seconds) has gone by. Coroutines let you pause execution until it's given [YieldInstruction](http://docs.unity3d.com/ScriptReference/YieldInstruction.html) is finished.

<details> 
  <summary>**Hint 1**</summary>
   The syntax for creating the corotuine is ```IEnumerator ExampleName() { }```.
</details>
<details> 
  <summary>**Hint 2**</summary>
   ```StartCoroutine(methodName)``` will need to be called in order to begin the coroutine.
</details>
<details> 
  <summary>**Hint 3**</summary>
   ```yield return new WaitForSeconds(1)``` will cause the coroutine to pause every 1 second. This is useful in a while loop.
</details>

## Player Lives
**Skills:** Scripting, User Interface | **Resources:** UI RectTransform [Video](https://unity3d.com/learn/tutorials/modules/beginner/ui/rect-transform?playlist=17111), UI Image [Video](http://unity3d.com/learn/tutorials/modules/beginner/ui/ui-image?playlist=17111)

The player can be hit three times and once killed should respawn if they have additional lives left. With this challenge you'll need to modify the code to account for having lives in addition to having health. The lives left should be displayed visually to the player.

<details> 
  <summary>**Hint 1**</summary>
   The User Interface will need to be updated to show how many lives the player has. Take a look at how the health is being done in the ```UserInterfaceManager``` class for an example. 
</details>
<details> 
  <summary>**Hint 2**</summary>
   You can reuse the player sprite for the user interface.   
</details>
<details> 
  <summary>**Hint 3**</summary>
   The ```CalculateHit(int amount)``` method is a good location to check if the player has any lives remaining before calling ```GameManager.EndGame()```. 
</details>

## Add Shields
**Skills:** Animation, Scripting, Sound | **Resources:** Time [Script](http://docs.unity3d.com/ScriptReference/Time.html), Vector2.Lerp [Script](http://docs.unity3d.com/ScriptReference/Vector2.Lerp.html)

Shields add another element of depth to the game play. The actual implementation of the shield mechanics can be done in a few different ways, depending on the play style that you'd like to introduce. 

**Static Shield**

One option is to have the shield always be an extension of the player ship. That is to say that it will automatically replenish itself after the player has not been hit for a certain amount of time. [Time.time](http://docs.unity3d.com/ScriptReference/Time-time.html) will be helpful in tracking how much time has passed in seconds. 

<details> 
  <summary>**Hint 1**</summary>
    Hits should be processed against the shield before hit points are deducted. The ```Ship.CalculateHit(int amount)``` method will be the starting point for this. 
</details>
<details> 
  <summary>**Hint 2**</summary>
   Use [Time.time](http://docs.unity3d.com/ScriptReference/Time-time.html) in the update method to increment it and to check if the limit has been reached for resetting the shield. 
</details>
<details> 
  <summary>**Hint 3**</summary>
   [Vector2.Lerp](http://docs.unity3d.com/ScriptReference/Vector2.Lerp.html) can be used to animate the visual element of the shield.
</details>

**Randomly Generated Shields**

Another option is to have a shield appear in a random spot somewhere in the game and require the player ship to pick it up. Once the shield has been depleted it is gone until the player picks another randomly spawned one up. The nice thing about this path is that it can be written in a way where it is extensible (like the ```Ship``` class to prepare for the randomly spawning power-up medium level challenge!

<details> 
  <summary>**Hint 1**</summary>
   The same mechanics behind the enemy spawning can be used to create spawning for the shield.  
</details>
<details> 
  <summary>**Hint 2**</summary>
    Hits should be processed against the shield before hit points are deducted. The ```Ship.CalculateHit(int amount)``` method will be the starting point for this. 
</details>

## Block AI and Players From Leaving the Screen
**Skills:** Scripting, User Interface | **Resources:** 

Currently the player and AI can move off of the camera's view. This should be corrected so that they cannot move off of the screen. [Screen](http://docs.unity3d.com/ScriptReference/Screen.html) and [Mathf.Clamp](http://docs.unity3d.com/ScriptReference/Mathf.Clamp.html) are going to be very helpful for this. 

<details> 
  <summary>**Hint 1**</summary>
   Update the movement code inside the ```Update()``` method for the player and the enemy.  
</details>
