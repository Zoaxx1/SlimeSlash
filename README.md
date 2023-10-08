# SlimeSlash
A video game inspired by a Cuphead boss fight. In this game you are a soldier with the mission to eliminate a Big Slime that causes disaster in the town and you must prevent it from reaching the city. Rain of Slimes, small Slimes that attack you, and you only have your weapon to eliminate the danger before becoming bigger...

## Pseudocode

```
[Scenario]
|_ Ground
|_ Background

[Player]
|_Actions
|	|_Move
|	|	|_Left and Right Keys
|	|_Attack
|	|	|_Space Key
|	|	|_Ranged Attack
|	|		|_Deals (1) damage
|	|_Jump
|		|_Up Key
|_Health (20)
	|_Represented with a health bar at the top left of the screen
	|_Loses health
	|	|_Touching any enemy
	|_When it reaches 0, the game ends (Lose)
		|_A message appears
		|_Text "You Lost"
		|_Restart Button

[Boss]
|_Health (100)
|	|_When it reaches 0, the game ends (Win)
|	|_A message appears
|		|_Text "You Won"
|		|_Restart Button
|_Interactions
	|_Collision with Slime from the left
	|	|_Grows
	|	|_Can grow a maximum of 5 times
	|	|_Reaches the fifth time, the game ends (Lose)
	|		|_A message appears
	|			|_Text "You Lost"
	|			|_Restart Button
	|_Player
		|_Deals (5)? damage

[Spawn of Slimes]
|_Location
|	|_Inside the Boss (The idea is that it looks like they come out of it)
|_Spawn Time
|	|_Random between a range
|		|_Minimum
|		|_Maximum
|_Spawns
	|_[Slime]

[Spawn of Mini Slimes]
|_Location
|	|_Above the camera
|_Spawn Time
|	|_Random between a range
|		|_Minimum
|		|_Maximum
|_Spawns
	|_[Mini Slime]

[Spawn of Power Slimes]
|_Location
|	|_On the left side of the camera, near the ground
|_Spawns
	|_[Power Slime]
	|_When a Slime reaches the left side

[Slime]
|_Movement
|	|_Moves from right to left
|_Health (20)?
|	|_If its health is reduced, it is destroyed
|_Interactions
	|_Touches the Player
	| |_Reduces (2)? health
  |_Reaches the end of the path
		|_Automatically destroyed
		|_Activates [Spawn of Power Slimes]

[Mini Slimes]
|_Movement
|	|_None
|	|_Falls with gravity
|_Interactions
	|_Collision
	|	|_Any collision destroys it
	|_Player
		|_Takes away (1) health
		|_Is destroyed

[Power Slime]
|_Movement
|	|_Moves from left to right
|_Health (30)?
|	|_If its health is reduced, it is destroyed
|_Interactions
	|_Player
	|	|_Takes away (3) health
	|_Boss
		|_Is destroyed
		|_Grows the boss
