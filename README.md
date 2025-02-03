# Zombies

# First-Person Shooter Game Documentation

## Game Overview
This is a Unity-based first-person shooter (FPS) game featuring enemy AI, weapon systems, health management, and multiple scene interactions. The game incorporates core FPS mechanics including weapon switching, ammo management, zoom functionality, and enemy combat.

## Core Systems

### Combat System
#### Weapons (`Weapon.cs`)
- Implements ray-based shooting mechanics using Unity's Physics.Raycast
- Features muzzle flash effects and hit impact visualization
- Manages ammunition consumption and shooting cooldown
- Displays current ammo count using TextMeshPro UI
- Supports multiple weapon types through the AmmoType enum

#### Weapon Management (`WeaponsSwitcher.cs`)
- Enables weapon switching using number keys (1,2,3) or mouse scroll wheel
- Manages weapon activation/deactivation
- Maintains weapon state across scene transitions
- Supports dynamic weapon inventory system

#### Ammunition System (`Ammo.cs`, `AmmoPickup.cs`, `AmmoType.cs`)
- Defines three ammo types: Bullets, Shells, and Rockets
- Implements ammo pickup mechanics with sound feedback
- Manages ammo inventory through serializable ammo slots
- Provides methods for ammo manipulation (increase/decrease/query)

### Enemy System
#### AI Behavior (`EnemyAI.cs`)
- Utilizes Unity's NavMeshAgent for pathfinding
- Implements chase and attack behaviors based on player proximity
- Features a provocation system that responds to damage
- Includes combat animations for movement and attacks
- Visualizes chase range using Gizmos in the Unity editor

#### Enemy Combat (`EnemyAttack.cs`, `EnemyHealth.cs`)
- Manages enemy health and damage handling
- Implements death mechanics with animation triggers
- Broadcasts damage events to coordinate AI response
- Handles enemy-to-player damage dealing

### Player Systems
#### Health Management (`PlayerHealth.cs`)
- Tracks player hit points
- Updates health UI display
- Triggers death handling when health depletes
- Manages damage reception from enemies

#### Combat Feedback (`DisplayDamage.cs`)
- Shows visual feedback when player takes damage
- Implements temporary impact effects using coroutines
- Manages UI canvas visibility for damage indication

### Game Flow Management
#### Scene Management (`SceneLoader.cs`, `SceneChange.cs`, `SceneChangeTrigger.cs`)
- Handles scene transitions and level progression
- Provides game restart functionality
- Implements quit game feature
- Supports trigger-based scene changes

#### Death Handling (`DeathHandler.cs`)
- Manages game over state
- Shows game over UI
- Freezes gameplay on death
- Handles cursor state changes

#### UI and Feedback
- Displays intro text (`IntroText.cs`)
- Shows health and ammo counts
- Implements damage feedback system
- Manages UI state across different game states

### Additional Features
#### Weapon Zoom (`WeaponZoom.cs`)
- Implements aim-down-sights functionality
- Manages FOV changes for zoom effect
- Handles zoom state persistence

#### Background Music (`BackgroundMusic.cs`)
- Implements singleton pattern for continuous music playback
- Persists across scene changes
- Prevents audio duplication

#### Object Animation (`ObjectAnimationTrigger.cs`)
- Handles environment object animations
- Responds to player proximity
- Manages animation state triggers

## Technical Implementation Notes

### State Management
- Utilizes Unity's component system for modular functionality
- Implements proper state handling across scene transitions
- Uses coroutines for time-based effects

### Performance Considerations
- Efficient weapon switching system
- Optimized enemy AI with appropriate chase ranges
- Smart damage and collision detection

### Best Practices
- Follows Unity's component-based architecture
- Implements proper encapsulation of functionality
- Uses serialized fields for easy configuration in Unity Inspector
- Maintains clean separation of concerns across scripts

## Setup and Configuration
1. Ensure all scripts are attached to appropriate GameObjects
2. Configure serialized fields in Unity Inspector
3. Set up proper tags for player and enemy objects
4. Configure NavMesh for enemy AI navigation
5. Set up proper audio sources for sound effects
6. Configure UI elements and canvases

## Dependencies
- Unity Engine
- TextMeshPro package for UI text
- Unity's NavMesh system for AI pathfinding
- Standard Unity Asset packages for effects
