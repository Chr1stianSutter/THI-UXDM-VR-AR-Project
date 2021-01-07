# THI-UXDM-VR-AR-Project
Project for the THI UXD Master VR/AR course

## Members
	Name: Katharina Vogl
	Bachelor: Stuttgart
	Experience in VR/AR: Paragliding Simulation with HTC Vive and Unreal4

	Name: Christian Sutter
	Bachelor: Ravensburg
	Experience in VR/AR: none

	Name: Elias Kwaka
	Bachelor: UXD bachelor at THI
	Experience in VR/AR: Not much, just from the bachelor VR/AR lecture



## VR GAME: First-Person Pacman
![Pacman](https://katzlberger.ai/wp-content/uploads/2020/05/pacman-screen.jpg)

- Horror / Atmosperic
	- Twilight / darkness
	- Flickering lights
	- Mist / Smoke
	- Scary Enemies
- World that reacts to player / is interactive
	- Enemies react to player
	- Map reacts to player actions
	
## Labyrinth
- Randomizer / Auto-Generated (Tiles)
- Levels / Layers
- Level-End (?) 
	- Teleporter up/down? 
	- Stairs?
	- Door / "Wall of Mist?" ➤ Uncertainty / Fear of the unknown
- Heavy automatic doors that open slowly (create time pressure)

## Player
- Player movees by walking (No Joystick) ➤ 15m x 15m Level
- Problem: Diminsihed sense of self (?) ➤ Add Hands?
- Co-op (?) Limited Information for both players?
- Minimap? (-> in the original Pac Man you can SEE where the last few / next picups are)

## Objective (Pick-ups)
- Counter VS PICK-up (Pickups that disappear by walking through them**VS** Things/Objects that have to be carried using hands)
- Time-Freeze (Pickup that temporarily stuns enemy and may allow escape)

## Enemies
- Randomized (?)
- Character ➤ Different enemies / properties / "quirks"
- Light cones / Spotlights? (Unstable / Changing light, White/Red?)
- Spawns (?)
- Multiple different enemy types (appearance as well as properties)
	- "Weeping Angel" / "SCP 174" (only moves when NOT looked at by player)
	
## Inspiration

- Pacman (Base Game & Gameplay)
- SCP Conaintment Breach (Horror / Enemies / Tasks)
- Alien Isolation (Horror / Atmosphere)
- (Slenderman) (Horror / Tasks)
- (Among Us) (Tasks)

## Free Asset Links that have been butchered in the creation of this game (state of 07.01.2021)

https://assetstore.unity.com/packages/3d/environments/3d-free-modular-kit-85732

https://assetstore.unity.com/packages/vfx/shaders/ultimate-10-shaders-168611

https://assetstore.unity.com/packages/tools/input-management/first-person-all-in-one-135316


## FYI Links

https://veer.tv/videos/pac-man-360-vr-must-try-98341

https://www.youtube.com/watch?v=E2JVzioS1Fc


## Personas

Persona 1 - John Lee:
![Persona 1 - John Lee](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Persona%20Alice%20Nguyen.png)

Persona 2 - Alice Nguyen:
![Persona 2 - Alice Nguyen](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Persona%20John%20Lee.png)

## User Stories
Since game-users are "players" and a player's "journey"/"story" is conveyed via gameplay first and foremost, our "user story" is a planned interaction and summarization of conditions from game-start to game-end.

### Start of the game

- Player may need context, maybe a home-screen or home-scene.
- Player may need understanding of base controls and game-goals /-conditions.
- Player may need to familiarize themselves with their surroundings / explore.

### Game & Gameplay
- PLayer may need to be reminded of game goals / progress
- Player may need audiovisual cues on establishing enemy / pickup differentiation and pickup-goal-progress-relationship
- Core gameplay (pursuit & picking up happens)
- (Fleeing to  win-zone ensues after pick-up goal is reached)

### End of the Game

- Win-Condition (Picking up all / a certain number of pickups)
- Lose-Condition (Contact with enemy)
- Entering of "Win-Zone" (teleporter / door / stairs / lift or similar) 

## Storyboards

Moodboard 1 - Pac Man:
![Moodboard 1 - Pac Man](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%201%20Pac%20Man.png)

Moodboard 2 - SCP Containment Breach:
![Moodboard 2 - SCP Containment Breach](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%202%20SCP.png)

Moodboard 3 - Slenderman:
![Moodboard 3 - Slenderman](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%203%20Slenderman.png)

## Process

### Asset Store scouting: What's free & what's fun/useful
Result: A few interesting map kits:
- Kit 1: Tech-y space corridor kit #1
https://assetstore.unity.com/packages/3d/environments/3d-scifi-kit-starter-kit-92152

- Kit 2: Tech-y space corridor kit #2
https://assetstore.unity.com/packages/3d/environments/sci-fi/modular-sci-fi-corridor-142811

- Kit 3: Techy space corridor kit #3
https://assetstore.unity.com/packages/3d/environments/3d-free-modular-kit-85732

We chose a space-based kit to fulfill the tech-y pac-man component (see moodboard 1)
The first kit we chose had lighting/baking issues, so we opted for a different one that was visually quite impressive. Sadly, this one had too many vertices and the resulting framerate dropped way below 60 (5-15 at times) so we opted for kit #3. That resulted in an immproved framerate of over 70+ fps (often times even 150-250fps).

### Map Building and Core Interactions
With that we built our dummy-map in form of an "8". We used this as environment to model all further components and interactions, most notably NavMesh and NavEntities. After Player-Enemy and Player-PickUp interactions proved to work, we enlarged the map to the full size of the classical PacMan map.

Power-Ups and Door interactions have been benched due to time limitations, and us wanting to flesh-out and polish what we have already. Although it will reduce immersion by not having the player being able to act – and presenting the danger of a "walking-simulator" – we ultimately chose to leave in-game hand-interactions (besides walking) out of the picture.

### Hardware
We decided on the HTC Vive early on, because it is a solid workhorse, and we wanted to gain more experience in working with THE VR setup out there. At. first we had somme troubles setting up the system, keybinding, receiving and using controller feedback values, but that quickly dissipated and we were able to make use of both, the headset and the controllers.

The controllers are used as joysticks, with touchpad input being translated to player movement

### Enemy Scripts & Movemment
As of now, enemies move by randommly patrolling fixed points within the NavMesh.

Chase & Scatter are the classical movement patterns of PacMan enemies. When chasing, they display unique characteristics, that have yet to be implemented. These characteristics are following, cutting off, patrolling and random movement or avoidance. The enemies would switch between these two patterns continously. In addition, we planned on implementing certain characteristics that stem from moodboard 2, like the inability for enemies to move while being directly looked at. 

Fleeing: While in PacMan the player has the opportunity to "eat" power-ups that make the enemies flee, and the player able to "eat" them to reset them to the starting point in the middle, we decided against this, to prevent the player from entering an empowered state as this would clash with our horror theme.

### Player Scripts & Movement
The Player sports an HTC Vive movement script, as well as a WASD+Mouse debug movement script to allow for easy & safe work from home. The HTC Vive Movement Script works by translating Touchpad input into player movement, so the player gets a more natural, joystick-like way of moving around. At first we wanted our player to PHYSICALLY walk within a track environment to maximize presence and immersion, but since tracked spaces are generally small, lab-time was limited - and frankly, the ability to physically run from a pursuer in VR (while technically blind) – made us decide to opt for a more "safe" way of in-game movement. We deliberately decided against trigger-based. teleport movement, since a pursuit-style gamme works better with consistent movement: We wouldn't want the player to be able to cheat by teleporting through and behind the enemies, or dirupt the flow of the pursuit by having the player "walk" in increments.

Our player moves via touchpad-input, where the touch direction translates to the movement direction, and the distance from the touchpad-center to the outer edge translates to movement speed. This allows the player not only to walk in the direction he is facing, but also side-step or strafe, as well as to walk backwards.

### PickUp Scripts & Behaviour
The Pickups rotate and float for additional visibility & engagement. 
They react to intersections with the player collider by playing a sound file, upping a PlayerCount variable by 10, and disabling themselves. Over 90 Pickups are placed in the full-sized map version!

### Atmosphere & Misc.
As of the 07.01.2021 this department still feels lackin in our eyes. Good horror is always hard to craft, and to get more of moodboards 2 & 3 into our game, we will focus on multiple facets over the next few days:

Audio: 
To involvemore senses and create more presence, we want to incorporate audio-cues and background music as well as sound effects. The PickUp sound – reminicent of. the classic 8-bit sound, Is the first audio feedback in our game and will be followed by: Enemy static noise, player footsteps, ambient background tracks (switching on enemy aggro?), loss / win sounds, audio enemy proximity cues, and teleporter noises (static + active) if implemented.

Misc.: 
To have the surroundings be more realistic and lived-in we will add miscellaneous objects as crates, barrels, apparats (sci-fi of course) to the corridors. This should make for more interesting shadows, possible corners to hide in, and more variety – all while restricting vision.
If possible we'd like to incorporate some dust/particles and/or smoke to restrict the view and make approaching enemies more sudden.

Lighting:
As of now, the lighting is still very bright and testing / debuggin friendly. This of course shall change! Darker more menacing surrounding as well as eerily bright light should make for a few shocking encounters! :)
To turn the scariness up even more, we want to have swinging, and/or flickering lights!

### Usability testing ( or the lack of it :D )

Lockdown prevented testing with external users.

On the date of testing the AR movement script was yet to be figured out – after we DID manage to get it running, someone took off with the HTC vive, and the replacement console had hardware troubles (sensors didnt recognize controllers) that even extensive troubleshooting with Tamara could not solve. It SHOULD work fine though – just any gamplay testing after that was done with WASD + Mouse due to lockdown.

But after implementing the base functionalities and playtesting amongst ourselves we noticed the following relevant things:

- gameplay needs more tension (more overall stress, as well as more shifts in stress vs non-stress phases)
- atmosphere lacking (more contrasts, uninteresting environment, corridors look too similar)
- game goal / player location not transparent enough (especially on big map)



### To Be Done
- Extend enemy behaviour range + "quirks"
- Minimap
- Ghost Model (Polygon Count too high & needs mesh animation)
- small (online) user test(s) and feedback loop(s)

- Misc. Containers and elements that make the corridors more believable 
- background music (switch on enemy aggro??)
- Enemy proximity cues 
- add hand models for controllers

- add teleporters
- add step sound
- pause/start menu / ui 
