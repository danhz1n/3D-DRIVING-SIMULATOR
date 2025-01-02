3D DRIVING SIMULATOR




RigidbodyController
Overview
The RigidbodyController script provides basic movement and jumping functionality for objects in Unity using the Rigidbody component. It handles keyboard inputs to control movement along the horizontal and vertical axes and allows the object to jump when grounded. This script is ideal for implementing player-controlled objects in 3D environments, such as character controllers or vehicles.

Features
Smooth Movement: Move the object along the horizontal and vertical axes using keyboard inputs.
Jump Mechanic: Enables jumping functionality when the object is grounded.
Physics-Based Control: Uses Unity's Rigidbody component for realistic physics interactions.
Customizable Parameters: Easily adjust movement speed and jump force in the Unity Inspector.
Requirements
Unity Version: 2019.4 LTS or later (recommended 2021.3 LTS or newer).
Components:
A GameObject with a Rigidbody component attached.
A Collider component (e.g., BoxCollider or CapsuleCollider) to detect ground contact.
Installation
Create a new script in Unity and name it RigidbodyController.
Copy and paste the code into the script file.
Attach the script to the GameObject you want to control.
Ensure the GameObject has a Rigidbody component.
Adjust the moveSpeed and jumpForce values in the Unity Inspector to fit your gameplay needs.
Usage
Movement Controls:

W/S or Up/Down Arrow Keys: Move forward and backward.
A/D or Left/Right Arrow Keys: Move left and right.
Jumping:

Press the Spacebar to jump when the object is grounded.
Customizing Behavior:

Move Speed: Adjust the moveSpeed value to change how fast the object moves.
Jump Force: Modify the jumpForce value to increase or decrease the jump height.
Script Details
Properties:
public float moveSpeed: Controls how fast the object moves.
public float jumpForce: Sets the force applied when jumping.
Key Functions:
void Start(): Initializes the Rigidbody component.
void Update(): Handles movement and jumping based on user input.
bool IsGrounded(): Uses a raycast to check if the object is grounded.
Future Enhancements
Add double-jump functionality for more complex gameplay.
Implement dash mechanics for quick bursts of speed.
Integrate animations for smoother visual transitions during movement and jumping.
Allow for customizable ground detection distance.
