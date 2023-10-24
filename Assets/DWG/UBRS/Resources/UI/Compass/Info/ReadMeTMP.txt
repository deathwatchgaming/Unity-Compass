Compass (Text Mesh Pro)
--------------------------------------------------------------------------------

Description: Add a Compass (Text Mesh Pro) for your Unity Projects


Important Note: 

The compass requires a "characterController" say either an "FPSController" 
or "TPSController" and as such one would not be able to test such unless 
they have one already, else since that fact is a required, I opted to supply
a "TestStuff_Controller" simply for testing purposes in case say the user 
does not yet have a decided upon controller and is simply desiring to try out 
the compass. As such the basic controller supplied has setup instructions that 
explain simply how to setup a simple testing terrain plane, terrain and then 
add the "TestStuffController" to such if desired before then applying the 
compass setup. 

Also Note: 

That using such included "tester controller" is not required if you say already 
have a desired controller that you want to use the compass with. 
I hope that makes sense.


Manual Setup Instruction:
-------------------------

* Simply follow the instruction for manual setup found below.


Step 1: UI & Canvas
___________________________________________________________________________________


1.A) Create an empty object called: "UI"

1.B) Inside the new "UI", then create a UI: -> "Canvas"

Note: You can set your canvas up how you want, that is why I did not comment much 
      on such. Same Goes fo uvRect on things within the UI canvas as that is perhaps 
      personal prefs and for these instructions one assumed one would just start with 
      the default middle center such and tweak such from there.

     * Such is up to the end-user and their prefs, but just so noone says I left it 
     out, so here is just one "Canvas" example:

      UI Scaler: 
      ----------

      UI Scale Mode: Scale With Screen Size
      Reference Resolution: X: 1920 Y: 1080
      Match: 0 (Width)
      Reference Pixels Per: 1920
      
1.C) Inside the "Canvas", create a new empty called: "Compass"
     * Note: This will house all the compass related stuff

1.D) Add / Modify Details for "Compass":

Rect Transform Anchors: middle & center * 

 * default, though you can change as you desire later

Position: X: 357 Y: -229 Z: 0
Width: 100
Height: 100     

------------------------------------------------------------------------------------


Step 2: Text Mesh Pro Text
____________________________________________________________________________________


2.A) Inside "Compass", create a UI: -> "Text Mesh Pro (TMP)" and rename it 
     to: "Compass Degree Text (TMP)" *

     * Layer should also be "UI"

2.B) Add / Modify Details for "Compass Degree Text (TMP)":

Rect Transform Anchors: middle & center * 

 * default, though you can change as you desire later

Position: X: -357 Y: 338 Z: 0
Width: 200
Height: 200

Text: 360
Font: LiberationSans SDF
Material Preset: LiberationSans SDF Material
Font Style: Bold
Font Size: 48
Vertex Color: Hex: #FFFFFF
Alignment: Center & Top
Overflow: Overflow

------------------------------------------------------------------------------------


Step 3: RawImage 1
____________________________________________________________________________________


3.A) Inside "Compass", create a UI: -> RawImage

3.B) Rename the "RawImage" to: "Compass Background"

3.C) In Inspector Edit the following as follows:

Rect Transform Anchors: middle & center * 

 * default, though you can change as you desire later

Position: X: -357 Y: 486 Z: 0
Width: 1152
Height: 77
Scale: X: 0.875 Y: 1 Z: 1

3.D)Add / Import the actual image to your project: "DWG_CompassBackground.png"

Change the folllowing settings as such:

 Texture Type: Sprite (2D and UI)
 Texture Shape: 2D
 Compression: None

 Then select "Apply" to apply the changes.

 3.E) Lastly, now we need to add the actual image we just imported.

      So go back into UI -> "Compass Background" via "Inspector" and find: "RawImage"

      Change the folllowing settings as such:

 Texture: "DWG_CompassBackground.png"
 Color: set "rgba" as follows:

 R: 127
 G: 127
 B: 127
 A: 25     

------------------------------------------------------------------------------------


Step 4: RawImage 2
____________________________________________________________________________________


4.A) Inside "Compass", create a UI: -> RawImage

4.B) Rename the "RawImage" to: "Compass"

4.C) In Inspector Edit the following as follows:

Rect Transform Anchors: middle & center * 

 * default, though you can change as you desire later

Position: X: -357 Y: 486 Z: 0
Width: 1152
Height: 77
Scale: X: 1 Y: 1 Z: 1

4.D) Add / Import the actual image to your project: "DWG_Compass.png"

Change the folllowing settings as such:

 Texture Type: Sprite (2D and UI)
 Texture Shape: 2D
 Compression: None
 Wrap Mode: Repeat * 

 * Note: This is very important for compass to rotate / display correctly!

 Then select "Apply" to apply the changes.

 4.E) Lastly, now we need to add the actual image we just imported.

      So go back into UI -> "Compass" via "Inspector" and find: "RawImage"

      Change the folllowing settings as such:

 Texture: "DWG_Compass.png"    

------------------------------------------------------------------------------------


Step 5: Add Component / Script
____________________________________________________________________________________


5.A) Go back to: UI -> Canvas - Compass
     
     Add component / script: "DWG_Compass_TMP.cs"

5.B) Ok, now fill out the related settings:

For -> DWG_Compass_TMP (Script):
--------------------------------

Script: DWG_Compass_TMP.cs
Compass IMG: Compass (Raw Image)
Compass BG: Compass Background (Raw Image)
Player: FPSController (Transform)
Compass Direction: Compass Degree Text (Legacy)
Compass Enabled: Check this * 


* Note: this is set to false by default because since we include both variants in the 
package and cannot predict whether someone will add both it simply makes sense to set 
as false. This can be changed in the source code by commenting out the false 
declaration and un-commenting the true definition if that is your desire and you only 
have one setup rather than both variants. Hopefully that reasoning makes sense.

-------------------------------------------------------------------------------------



Alright, now that is it for setup! Simple enough, right?! Best of Luck!


______________________________________________________________________________________

NOTE: On Changing Transform Anchors & Stretching Compass Out
______________________________________________________________________________________

As noted in previous instructions this was mentioned:

"Rect Transform Anchors: middle & center * 

 * default, though you can change as you desire later"


 Here is just one basic example of saying moving the transform anchors from
 "Middle & Center" to: "Top & Center" and then say for example: stretching the
 compass across the top and scaling the font to reflect such just for an example.

----------------------------------------------------------------------------------------
Compass (Holder):
----------------------------------------------------------------------------------------

Modify for example:

Rect Transform Anchors: Top & Center

Position: X: 357 Y: -537 Z: 0

----------------------------------------------------------------------------------------
Compass Degree Text (TMP) (Text):
----------------------------------------------------------------------------------------

Modify for example:

Rect Transform Anchors: Top & Center

Position: X: -357 Y: 288 Z: 0 

----------------------------------------------------------------------------------------
Compass Background (Image):
----------------------------------------------------------------------------------------

Modify for example:

Rect Transform Anchors: Top & Center

Position: X: -357 Y: 436 Z: 0

Width: 1920 
Height: 97

----------------------------------------------------------------------------------------
Compass (Image):
----------------------------------------------------------------------------------------

Modify for example:

Rect Transform Anchors: Top & Center

Position: X: -357 Y: 436 Z: 0

Width: 1920 
Height: 77

----------------------------------------------------------------------------------------


Alright, now that is it for that! Simple enough, right?! Best of Luck!

