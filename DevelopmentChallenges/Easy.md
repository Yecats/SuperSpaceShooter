#Easy Development Challenges 
## Better Game Over Behavior
**Skills:** Scripting, User Interface | **Resources:**

The game over logic in Super Space Shooter returns the player to the main screen. This can be enahnced for a better flow by doing simple things such as:

* Changing the text of the "Play" button to say "Retry". 
* Displaying the final score on the main screen.

<details> 
  <summary>**Hint 1**</summary>
   The syntax for creating the corotuine is ```IEnumerator ExampleName() { }```.
</details>

## Better Game Start Behavior
**Skills:** Scripting, User Interface | 
**Resources:** Coroutine [Script](http://docs.unity3d.com/ScriptReference/Coroutine.html) & [Manual](http://docs.unity3d.com/Manual/Coroutines.html), Invoke [Script](http://docs.unity3d.com/ScriptReference/MonoBehaviour.Invoke.html)

The player is not given much time to prepare themselves for the battle that is about to begin. An easy way to give the player time to prepare is to provide them with a countdown before the ```GameManager``` class begins spawning the enemies. This can be done by using a [coroutine](http://docs.unity3d.com/Manual/Coroutines.html). 

Coroutines are similiar to Invoking, which was used to spawn the enemies at a random rate. As you may recall, Invoking lets you call a method after a set amount of time (in seconds) has gone by. Coroutines let you pause execution until it's given [YieldInstruction](http://docs.unity3d.com/ScriptReference/YieldInstruction.html) is finished.

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
**Skills:** Scripting, User Interface

The player can be hit three times and once killed should respawn if they have additional lives left. With this challenge you'll need to modify the code to account for having lives in addition to having health. The lives left should be displayed visually to the player. 

## Add Shields
**Skills:** Animation, Scripting, Sound

## Break Apart Models
**Skills:** Animation, Scripting

## Block AI and Players From Leaving the Screen
**Skills:** Scripting, User Interface

Currently players and AI can move off of the camera's view. This should be corected so that they cannot move off of the screen. [Screen](http://docs.unity3d.com/ScriptReference/Screen.html) and [Mathf.Clamp](http://docs.unity3d.com/ScriptReference/Mathf.Clamp.html) are going to be very helpful for this. 