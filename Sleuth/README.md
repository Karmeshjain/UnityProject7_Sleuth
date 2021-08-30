
# Sleuth First Person Shooter Game In Unity 3D:

Player has to complete four objectives and reach the final destination in order to complete the mission and 
it has a limited health which is shown in health bar and it get depleted if player got attack by enemy soldier 
and player has to shoot the enemy soldier using its two guns one is assault rifle and second one is sniper rifle.

# Game Report Document
-----------

Introduction
-----------
First-person shooter (FPS) is a video game genre centered on gun and other weaponbased combat in a first-person perspective; that is, the player experiences the action 
through the eyes of the protagonist. The genre shares common traits with other shooter 
games, which in turn makes it fall under the heading action game.
First-person shooters are a type of shooter game featuring a first-person point of view with 
which the player sees the action through the eyes of the player character

<img width="100%" src="screenshots/1.jpg" />

Game Overview
-----------
A Fps 3D Game made for mobile phones & tablets. It has been developed in Unity 3D 
using C# and as for the sprites, all of them are downloaded via internet and make in adobe 
photoshop. The prime motive of the game is to kill the enemies (Enemy soldier) and reach 
the final destination.. Player has to keep in mind that it did not get vision of the enemy 
and also too close to enemy as it take damage to player
<img width="100%" src="screenshots/2.jpg" />
Game Mechanics
--------
Game
-------
Player has to complete four objectives and reach the final destination in order to 
complete the mission and it has a limited health which is shown in health bar and it get 
depleted if player got attack by enemy soldier and player has to shoot the enemy soldier 
using its two guns one is assault rifle and second one is sniper rifle.
Where as sniper can zoom in at a large range where as assault rifle can zoom in through 
short range.
And player has four objectives in which player has to collect some materials in the game 
using action keys and finally reach the final destination where game ends.
Player has given a ammo levels to clear the stage and some ammo box to refil the ammo 
is also there.
Player can use minimap to check where enemy is and take advantage of it in order to 
complete the stage.
Assault rifle has lesser damage and sniper rifle is one shot one kill.

<img width="100%" src="screenshots/3.jpg" />

Controls
--------
Player use mouse left mouse button to shoot and right mouse button to zoom in and out 
and to pickup the objects that it has to in order to complete the objectives player use key E 
and key Z.
Player can move forward,backward,right,left using W,S,D,A respectively and also using 
arrow keys. Player can also jump with space keys. And for sprint in order to run fast player 
can use combination of W and Shift key and also switch its weapons with mouse scrolling 
and Key X.
and All basic fps controls are same

<img width="100%" src="screenshots/4.jpg" />

Controls
-------
Player use mouse left mouse button to shoot and right mouse button to zoom in and out 
and to pickup the objects that it has to in order to complete the objectives player use key E 
and key Z.
Player can move forward,backward,right,left using W,S,D,A respectively and also using 
arrow keys. Player can also jump with space keys. And for sprint in order to run fast player 
can use combination of W and Shift key and also switch its weapons with mouse scrolling 
and Key X.
and All basic fps controls are same

<img width="100%" src="screenshots/5.jpg" />
<img width="100%" src="screenshots/6.jpg" />

ENEMY MECHANICS : 
--------
For the enemy Movements, 
Two types of enemy player one which is without patrolling and anthor one with patrol 
points and they move within the patrol points and as player come into different ranges 
they perform the actions accordingly through there AI code.
Enemy has a fixed attack range and spot range and as player comes in spot range and as 
well as player is in vision of the enemy enemy start chasing the player and as it come into 
attack range of the enemy it start attacking the player and start dealing damage to enemy.
Here red represent attack range of player and yellow represent chase range and three red 
sphere are the patrolling points.
<img width="100%" src="screenshots/7.jpg" />
And player also having a gun through using which it can shoot the player and decrease the 
health player and increase difficulty in the game
<img width="100%" src="screenshots/8.jpg" />
Game Design
-------
User-Interface
-------
In three scenes: 
First one is Intro A video player is attached to canvas for intro of the 
Game and publisher
<img width="100%" src="screenshots/9.jpg" />
Second one is Game menu in which two buttons Play and credits 
And as play button get clicked game starts that is third screen get load.
<img width="100%" src="screenshots/10.jpg" />
And the gameMenu looks
<img width="100%" src="screenshots/11.jpg" />
Third one:
In user interface for first two seconds one fade in fade out screen black come in order to
make game more realistic and player has Minimap at the top left and Health bar at the
top right of the screen.And at the bottom right player has shown the ammo levels for gun
player is holding and as player switch to other gun the ammo level for that gun is getting
displayed and switched.
<img width="100%" src="screenshots/12.jpg" />
And for better gameplay this black screen animation for 2 seconds is there;
<img width="100%" src="screenshots/13.jpg" />
And the game looks like;
<img width="100%" src="screenshots/14.jpg" />
Sound
------
The sound is used in first scene in intro of the game and in second scene helicopter sound
used.
And in third scene:
A background sound,Two Gun sounds,Reload sound,Ammo pickup sound,Three Hurt
sounds when player receive damage,Helicopter sound at the last of the stage (3D sound
for limited distance),subtitle voice in starting of game.
<img width="100%" src="screenshots/15.jpg" />
Scenes/Screens
-------
In the game there are three scenes
First scene is Intro A video player is attached to canvas for intro of
the Game and publisher.
<img width="100%" src="screenshots/16.jpg" />
<img width="100%" src="screenshots/17.jpg" />
Second scene is Game menu in which two buttons Play and credits
And as play button get clicked game starts that is third screen get
load. Which have animation for soldier standing and helicopter
<img width="100%" src="screenshots/18.jpg" />
Third scene is our main game where player plays and enjoys the
game.
<img width="100%" src="screenshots/19.jpg" />
Assets and Game Objects
-------
All the Assets and game objects are created in BLENDER and textured
within the unity itself. And download via internet.
Some sprites:

<img width="100%" src="screenshots/20.jpg" />
Main Character:

<img width="100%" src="screenshots/21.jpg" />
Enemy
<img width="100%" src="screenshots/22.jpg" />
<img width="100%" src="screenshots/23.jpg" />
Background & Environment Items;
--------
<img width="100%" src="screenshots/24.jpg" />
<img width="100%" src="screenshots/25.jpg" />
<img width="100%" src="screenshots/26.jpg" />
<img width="100%" src="screenshots/27.jpg" />
<img width="100%" src="screenshots/28.jpg" />
<img width="100%" src="screenshots/29.jpg" />
<img width="100%" src="screenshots/30.jpg" />
<img width="100%" src="screenshots/31.jpg" />
<img width="100%" src="screenshots/32.jpg" />
Animation
-------
For the animation, we created most of the animation part in the unity animation editor and
some animation download via internet.
Animations are used in reloading of both guns ,shooting animation of both guns ,Enemy
player patrol,idle,walk,run,And die animation.and also one animation used for screen fade
in fade out for 2 seconds in starting.
And for main player Idle , Walk,Sprint animation are used which shown on weapons when
player perform different actions.
<img width="100%" src="screenshots/33.jpg" />


<img width="100%" src="screenshots/34.jpg" />
<img width="100%" src="screenshots/35.jpg" />
And after that, we use a component called ANIMATOR to apply trigger
to each animation. So that each animation will play after the execution of
a specific function not before that. 
Enemy Animator
-----
The one which is patrolling;
<img width="100%" src="screenshots/36.jpg" />
The one which is not patrolling;
<img width="100%" src="screenshots/37.jpg" />
 Player Animator:
-----
For idle,walk,sprint;
<img width="100%" src="screenshots/38.jpg" />
For gun animations zoom reload;
<img width="100%" src="screenshots/39.jpg" />
Camera
------
In first scene we have one camera which displays the video
In second scene we have one camera which displays the menu.
In third scene;
We have three cameras first which render the Whole scene except gun
which player is holding and second one render only the gun so that
problem of clipping get removed. And third camera is our minimap
<img width="100%" src="screenshots/40.jpg" />
Post Processing
-----
<img width="100%" src="screenshots/41.jpg" />




