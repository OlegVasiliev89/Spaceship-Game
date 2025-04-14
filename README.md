The Spaceship Game is a 2D space shooter style game. 

The game was developed using Windows Forms in C#, where each game entity is represented as a PictureBox. The player battles difficult aliens, requiring fast reflexes and precise movement with Real-time hit detection and health system.

The game was rebuilt from scratch using OOP principles to improve code modularity and maintainability.

Player Class represents the player’s spaceship. Contains properties like health, speed, and handles input, movement, and bullet firing.

Alien Class, base class for enemies defines position, health, attack behavior. Supports inheritance for specialized bosses.

Bullet Class, represents bullets fired by the player, manages direction, speed, and collision detection.

GameEntity Interface (Planned/Used) shared interface for all game entities (Player, Alien, Bullet), allows easy iteration and collision handling in the game loop.

Internal state (e.g., health, position) is kept private and modified via methods.

