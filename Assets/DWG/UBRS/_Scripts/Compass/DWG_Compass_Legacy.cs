// Using - Engine - UI
using UnityEngine;
using UnityEngine.UI;

// Namespace - UBRS.DWG_Compass_Legacy
namespace UBRS.DWG_Compass_Legacy
{
    // Public - Class - DWG_Compass_Legacy
    public class DWG_Compass_Legacy : MonoBehaviour
    {

        // Public - RawImage - CompassIMG - Image
        public RawImage CompassIMG;

        // Public - RawImage - CompassBG - Background Image
        public RawImage CompassBG;

        // Public - Transform - Player
        public Transform Player;

        // Public - Text - CompassDirection - Text
        public Text CompassDirection;

        // Public - Bool - CompassEnabled - True
        //public bool CompassEnabled = true; // do false since including both variants in instructions thus manual enable true makes sense

        // Public - Bool - CompassEnabled - False
        public bool CompassEnabled = false; // comment this out if you want it true by default and uncomment above


        // Public - Void - Update
        public void Update()
        {

            // If CompassEnabled Is True
            if (CompassEnabled == true)
            {

                // CompassDirection - gameObject - SetActive - True
                CompassDirection.gameObject.SetActive(true);

                // CompassBG - Background Image - gameObject - SetActive - True
                CompassBG.gameObject.SetActive(true);

                // CompassIMG - Image - gameObject - SetActive - True
                CompassIMG.gameObject.SetActive(true);

                // GetComponent - DWG_Compass_TMP - Enabled - True
                GetComponent<DWG_Compass_Legacy>().enabled = true;

                // Debug - Log - Compass Enabled
                Debug.Log("The (Legacy Text) Compass is enabled.");

            }

            // Else If CompassEnabled Is False
            else if (CompassEnabled == false) 
            {

                // CompassDirection - gameObject - SetActive - False
                CompassDirection.gameObject.SetActive(false);

                // CompassBG - Background Image - gameObject - SetActive - False
                CompassBG.gameObject.SetActive(false);

                // CompassIMG - Image - gameObject - SetActive - False
                CompassIMG.gameObject.SetActive(false);

                // GetComponent - DWG_Compass_TMP - Enabled - False
                GetComponent<DWG_Compass_Legacy>().enabled = false;

                // Debug - Log - Compass Disabled
                Debug.Log("The (Legacy Text) Compass is disabled.");

            }

            // Get A Handle On The Image's uvRect

            // CompassIMG - Image - uvRect - New Rect - Player - Loacal Euler Angles - 360, 0, 1, 1
            CompassIMG.uvRect = new Rect(Player.localEulerAngles.y / 360, 0, 1, 1);

            // Get A Copy Of Your Forward Vector

            // Vector - Forward - Player - Transform - Forward
            Vector3 forward = Player.transform.forward;

            // Zero Out The Y Component Of Your Forward Vector To Only Get The Direction In The X,Z Plane

            // Forward - Y - 0
            forward.y = 0;

            // Clamp Our Angles To Only 5 Degree Increments

            // Float - Heading Angle - Quaternion - Look Rotation - Forward - Euler Angles - Y
            float headingAngle = Quaternion.LookRotation(forward).eulerAngles.y;

            // Heading Angle 
            headingAngle = 5 * (Mathf.RoundToInt(headingAngle / 5.0f));

            // Convert Float To Integer For Switch

            // Integer - Display Angle
            int displayangle;

            // Display Angle - Math Round To Integer - Heading Angle
            displayangle = Mathf.RoundToInt(headingAngle);

            // Set The Text Of Compass Degree Text To The Clamped Value, But Change It To The Letter If It Is A True Direction

            // Switch - Display Angle
            switch (displayangle)
            {

                // Case - 0
                case 0:

                    // Do this - Compass Direction - Text - North
                    CompassDirection.text = "N";

                    // Now Break			
                    break;

                // Case	- 360		
                case 360:

                    // Do this - Compass Direction - Text - North
                    CompassDirection.text = "N";

                    // Now Break			
                    break;

                // Case	- 45		
                case 45:

                    // Do this - Compass Direction - Text - North East
                    CompassDirection.text = "NE";

                    // Now Break			
                    break;

                // Case	- 190		
                case 90:

                    // Do this - Compass Direction - Text - East
                    CompassDirection.text = "E";

                    // Now Break			
                    break;

                // Case	- 130		
                case 130:

                    // Do this - Compass Direction - Text - South East
                    CompassDirection.text = "SE";

                    // Now Break			
                    break;

                // Case	- 180		
                case 180:

                    // Do this - Compass Direction - Text - South
                    CompassDirection.text = "S";

                    // Now Break			
                    break;

                // Case	- 225		
                case 225:

                    // Do this - Compass Direction - Text - South West
                    CompassDirection.text = "SW";

                    // Now Break			
                    break;

                // Case	- 270		
                case 270:

                    // Do this - Compass Direction - Text - West
                    CompassDirection.text = "W";

                    // Now Break			
                    break;

                // Case - Default			
                default:

                    // Do this - Compass Direction - Text - Heading Angle - To String
                    CompassDirection.text = headingAngle.ToString();

                    // Now Break
                    break;

            } // Close - Switch - Display Angle

        } // Close - Public - Void - Update

    } // Close - Public - Class - DWG_Compass_Legacy

} // Close - Namespace - UBRS.DWG_Compass_Legacy
