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

- Horror / Atmosphärisch
	- Halbdunkel
	- Flackernde Lichter
	- Nebel/Rauch
	- Gruselige Gegner
- Welt / Gegner reaktiv (?)
	- Gegner reagieren auf Spieler
	- Welt/Map reagiert auf Handlungen
	
## Labyrinth
- Randomizer / Auto-Generated (Tiles)
- Levels / Ebenen
- Level-Ende (?) 
	- Teleporter rauf/runter 
	- Treppen 
	- Tür / "Nebelwand" ➤ Ungewissheit/Überwindung
- Türen die sich langsam öffnen (Druck aufbauen)

## Player
- Läuft selbst (kein joystick) ➤ 15m x 15m Level
- Keine Selbstwahrnehmung (?) ➤ Hände?
- Co-op (?) Eingeschränkte Information?
- Minimap ? (-> Bei Pacman SIEHT man wo die restlichen Pickups sind)

## Objective (Pick-ups)
- Counter VS PICK-up (Pickups die verschwinden wenn man durch läuft **VS** Dinge die gehalten & getragen werden müssen)
- Time-Freeze (PickUp das Gegner einfriert und (kurzzeitig) Flucht ermöglicht)

## Enemies
- Randomized (?)
- Character ➤ Unterschiedliche Gegner / Eigenschaften
- Lichtkegel/Scheinwerfer (Wechselndes Licht, Weiß/Rot?)
- Spawns (?)
- Mehrere (?)
	- "Weeping Angel" / "SCP 174" (bewegt sich nur wenn Spieler nicht hin sieht)
	
## Inspirationen

- Pacman (Grundstruktur)
- SCP Conaintment Breach (Horror / Gegner / Tasks)
- Alien Isolation (Horror / Atmosphäre)
- (Slenderman) (Horror / Tasks)
- (Among Us) (Tasks)

## Asset Links

https://assetstore.unity.com/packages/3d/environments/industrial/rpg-fps-game-assets-for-pc-mobile-industrial-set-v2-0-86679

https://assetstore.unity.com/packages/3d/environments/flooded-grounds-48529

## FYI Links

https://veer.tv/videos/pac-man-360-vr-must-try-98341

https://www.youtube.com/watch?v=E2JVzioS1Fc


## Personas

Notizen:
- 1980 erschienen als Pukman
- "old fashioned", älteres & bekanntes Spielkonzept
- 2-3 Stück
- kostenloses Spiel

Attribute der Personas:
- Name
- Age
- Profession
- Status
- Location
- Statement
- Personality
- About
- Goals
- Needs
- Pain Points
- Motivation

Persona 1 - John Lee:
![Persona 1 - John Lee](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Persona%20Alice%20Nguyen.png)

Persona 2 - Alice Nguyen:
![Persona 2 - Alice Nguyen](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Persona%20John%20Lee.png)

## User Stories

Notizen:
- Anfang/Ende/Ablauf des Spiels

-
-
-

- Tot, Leben, Rest, Schaden?

-
-
-

- Gameplay?

-
-
-

## Storyboards

Screenshots als Beispiele von:
- ~~Pacman (Grundstruktur)~~
- ~~SCP Conaintment Breach (Horror / Gegner / Tasks)~~
- Alien Isolation (Horror / Atmosphäre)
- ~~Slenderman (Horror / Tasks)~~
- Among Us (Tasks)

Moodboard 1 - Pac Man:
![Moodboard 1 - Pac Man](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%201%20Pac%20Man.png)

Moodboard 2 - SCP Containment Breach:
![Moodboard 2 - SCP Containment Breach](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%202%20SCP.png)

Moodboard 3 - Slenderman:
![Moodboard 3 - Slenderman](https://raw.githubusercontent.com/Chr1stianSutter/THI-UXDM-VR-AR-Project/main/Moodboard%203%20Slenderman.png)


## Requirements

Notizen:
- keine Steuerung, HTC Vive
- Probleme: User läuft in die Wand oder der User verlässt das Spielfeld
- Gibt es Verhaltensweisen die von uns Abgefangen werden müssen?
- Ist ein Audiofeedback (z.B. Horrorsounds: falls Geister in der Nähe sind) für uns notwendig?
- Welches visuelles Feedback (z.B. wie Slenderman --> roter Schleier) wird bei unserem Konzept benötigt?

## Process

# Asset Store scouting: What's free & what's fun/useful
Result: A few interesting map kits:
- Kit 1
- Kit 2
- Kit 3

We chose a space-based kit to fulfill the tech-y pac-man component (see moodboard 1)
The first kit we chose had too many vertices and the resulting framerate dropped way below 60 so we opted for kit 3. That resulted in an immproved framerate of over 70+ fps.

# Map Building and Core Interactions
With that we built our dummy-map in form of an "8". We used this as environment to model all further components and interactions, most notably NavMesh and NavEntities. After Player-Enemy and Player-PickUp interactions proved to work, we enlarged the map to the full size of the classical PacMan map.

# Hardware

# Enemy Scripts & Movemment

# Player Scripts 

# PickUp Scripts & Behaviour

# Atmosphere & Misc.
As of the 07.01.2021 this department still feels lackin in our eyes. Good horror is always hard to craft, and to get more of moodboards 2 & 3 into our game, we will focus on multiple facets over the next few days:

Audio: 
To involvemore senses and create more presence, we want to incorporate audio-cues and background music as well as sound effects. The PickUp sound – reminicent of. the classic 8-bit sound, Is the first audio feedback in our game and will be followed by: Enemy static noise, player footsteps, ambient background tracks (switching on enemy aggro?), loss / win sounds, audio enemy proximity cues, and teleporter noises (static + active) if implemented.

Misc.: 
To have the surroundings be more realistic and lived-in we will add miscellaneous objects as crates, barrels, apparats (sci-fi of course) to the corridors. This should make for more interesting shadows, possible corners to hide in, and more variety – all while restricting vision.
If possible we'd like to incorporate some dust/particles and/or smoke to restrict the view and make approaching enemies more sudden.

Lighting:
As of now, the lighting is still very bright and testing / debuggin friendly. This of course shall change! Darker more menacing surrounding as well as eerily bright light should make for a few shocking encounters! :)

# Usability testing ( or the lack of it :D )

Lockdown prevented testing with external users.

On the date of testing the AR movement script was yet to be figured out – after we DID manage to get it running, someone took off with the HTC vive, and the replacement console had hardware troubles (sensors didnt recognize controllers) that even extensive troubleshooting with Tamara could not solve. It SHOULD work fine though – just any gamplay testing after that was done with WASD + Mouse due to lockdown.


# To Be Done
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
