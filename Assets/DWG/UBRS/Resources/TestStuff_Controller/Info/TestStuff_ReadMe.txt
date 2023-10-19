Create Simple Testing Plane, Testing Terrain & Tester FPSController:
____________________________________________________________________


Description:
------------

Simple Test Controller for Testing Stuff.


Setup Instructions:
-------------------

* Simply follow the simple steps found below.

____________________________________________________________________

Step 1:
____________________________________________________________________

Create New 3D Object: "Plane"

Position: X: 0 Y: 0 Z: 0
Rotation: X: 0 Y: 0 Z: 0
Scale:    X: 10 Y: 0 Z: 10

Rename to: "Terrain Plane"

____________________________________________________________________

Step 2:
____________________________________________________________________

Create New 3D Object: "Terrain"

Modify via:

"Terrain" Inspector: Terrain Settings

Mesh Resolution (On Terrain Data):

Terrain Width: 100
Terrain Length: 100

Position: X: -50 Y: 0.01 Z: -50
Rotation: X: 0 Y: 0 Z: 0
Scale:    X: 1 Y: 1 Z: 1

____________________________________________________________________

Step 3:
____________________________________________________________________

Create Empty Game Object: "FPSController" And Add Tag: "Player"

Position: X: 0 Y: 0.01 Z: 0
Rotation: X: 0 Y: 0 Z: 0
Scale:    X: 1 Y: 1 Z: 1

____________________________________________________________________

Step 4:
____________________________________________________________________

In "FPSController" Create: 3D Object "Capsule" And Rename To: 

"Player Capsule"

Position: X: 0 Y: 1 Z: 0
Rotation: X: 0 Y: 0 Z: 0
Scale:    X: 1 Y: 1 Z: 1

Add Material: "capsule_material.mat"

____________________________________________________________________

Step 5:
____________________________________________________________________

In "FPSController" Create: "Camera" And Rename To: 

"Player Camera"

Position: X: 0 Y: 1.6 Z: 0
Rotation: X: 0 Y: 0 Z: 0
Scale:    X: 1 Y: 1 Z: 1

____________________________________________________________________

Step 6:
____________________________________________________________________

Now Attach The Component / Script To: 

"FPSController" 

Script: "TestStuff_FPSController.cs"

Modify In "FPSController" Inspector, The Component: 
"Test Stuff_FPS Controller (Script)" -> Player Camera: "Player Camera"


Final Note:
----------------------------------------------------------------------

* That is it, simple enough, right?! So now you have a very simple test 
  area and tester controller so that you can test whatever.

  Best of Luck!

