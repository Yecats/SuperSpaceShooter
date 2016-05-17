# Medium Development Challenges 
## Add Touch-Input for a Mobile Device
**Skills:** Scripting | **Resources:** Mobile Device Input [Manual](http://docs.unity3d.com/Manual/MobileInput.html) and [Script](http://docs.unity3d.com/ScriptReference/Input.html)

Super Space Shooter does not take into consideration the possibility that someone might use their fingers to provide it input, rather than the mouse and keyboard. This is a very common scenario for mobile devices and can be solved fairly easily.

The "[Mobile Device Input](http://docs.unity3d.com/Manual/MobileInput.html)" manual entry will be key in understanding how input works within Unity. You'll also need to work with the [Input](http://docs.unity3d.com/ScriptReference/Input.html) class.

## Add Power Ups
 **Skills:** Animation, Scripting, Sound | **Resources:** Prefabs [Manual](http://docs.unity3d.com/Manual/Prefabs.html)

Power-Ups enhance the game play by giving the player something that is different and interesting. They typically spawn randomly around the game screen. Some power-up ideas are:

* A shield energy replenisher.
* Advanced weapons that run out.
* Refill the ship's hit points.

The spawning can be done very similar to how the enemy spawning was completed. Remember, you'll need to create prefabs for the power-ups.  

## Better Spawn Logic
**Skills:** Scripting

The current game logic is to have the AI spawn rate based on a result of ``` Random.Range(3,10)```. This can lead to boring gameplay if the rate takes too long and the player has killed all of the enemies. Additionally, it randomly selects the enemy type to spawn. 

To address this, the range of the spawn rate should factor in the amount and types of enemy AI that are present. For example, if the game currently has 3 heavily shielded enemies, it could either slow it's respawn rate down or respawn with an enemy that dies quickly.
