
# Duck Hunt Shooter - AR Game

### Description

Duck Hunt Shooter is a first-person shooting game developed in Unity using Vuforia. The main objective is to shoot ducks that appear in the environment using your Android device's camera. The game includes features like character movement, weapon handling, a bird counter, and a scoring system displayed on the game canvas.

### Features

- **Vuforia**: Utilizes the device's camera to detect surfaces and place the game in a real-world environment.
- **Low-poly scenery**: Includes mountains, valleys, trees, and other elements to create a visually appealing environment.
- **Enemy system (ducks)**: Ducks either fly or perch on surfaces, and the player must shoot them.
- **Shooting and movement mechanics**: First-person character control with realistic animations and physics.
- **Informative canvas**: Displays information such as remaining ammo, duck count, and end-game messages.
- **Sounds**: Includes sound effects for shooting, character movement, and more.

### Folder Structure

- `Assets/Scripts`: Only the scripts of the project will be uploaded, handling player control, duck logic, canvas interactions, and other core game mechanics.
  - `Movement.cs`, `Character.cs`, `CanvasSpawner.cs`, `TimeHandler.cs`, `CharacterKinematics.cs`, `Lb_BirdController.cs`, etc.

### Important Note

Although the project uses AR with Vuforia to interact with the real world, the demo video will be presented without AR. This is for testing purposes only. The full project is designed to function with AR enabled.

### How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/duck-hunt-shooter.git
   ```
2. Open the project in Unity 2021.3.11f1 (LTS) or later.
3. Ensure that Vuforia is installed.
4. Connect an Android device, build, and run the project.

### Requirements

- Unity 2021.3.11f1 (LTS)
- Android SDK
- Vuforia
- Android device with AR support
