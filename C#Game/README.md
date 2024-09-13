# Your README for A2 HERE
https://github.com/olivia-boyer/cs283-f24-assignments/blob/main/C%23Game/egggame.mp4
(it is egg themed because I used an ellipse as a placeholder for the player and eggs are a similar shape.
Also, eggs are easy to draw.)

2. Press the up arrow or w to jump. Use the down arrow or s to duck. Avoid the boxes.

3. Create the player class, which updates the player by calling jump if necessary. Draw
 draws the player avatar and changes to a sliding one if the user ducks. The CreateCharacter method
 returns a rectangle defining the dimensions of the player avatar.
 Jump changes the player's  y value based on the current y-value to very roughly simulate 
 changes in velocity due to gravity. StartJump tells the player to jump. And Duck tells the player
 to duck by changing an int value to zero which is then incremented to control the ducking length.
Obstacles also implements an update and draw funtion with similar functions to the player's but instead
deciding action determine position and location.The obstacle moves reight to left and returns to the 
right side of the screen after reaching the far left. 
The game.cs program calls the update and draw functions for obstacles and player and also checks for 
collision between the two. If the two have collided the Draw method displays a Game Over screen.
