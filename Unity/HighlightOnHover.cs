/* This script is based on using this shader I found here: https://github.com/Shrimpey/UltimateOutline 
*  The functionality of this shader is to allow for objects to be highlighted when hovering over them.
*
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameUtils
{
    public class HighlightOnHover : MonoBehaviour
    {
        [Header("General Refs")]
        public float disitanceToActivate;               // How far does the target need to be to the associatedObj?
        public Material newMatrial;                     // The material to swap to on the associated obj

        [Header("UI Refs")]
        public Text textUI;                             // Alerts the player to hit the specified button.
        public string textToShow;                       // What text will pop up in textUI?
		
        [Header("External Refs")]
        public GameObject associatedObject;				// The GameObject that is associated with the selection
        public GameObject targetObject;                 // The GameObject that is used as the comparison point

        // Private Vars
        private Material origMaterial;

        // Sets all of the private variables
        void Start()
        {
			if(associatedObject == null)
			{
				// We assume the gameobject the player wants to select is the parent itself
				associatedObject = gameObject;
			}
            associatedObject.material = origMaterial;
        }

        // When the player is a certain disitance away, the GameObject will change color
        void OnMouseOver()
        {
            float diff = Vector3.Distance(targetObject.transform.position, gameObject.transform.position);
            if (diff <= disitanceToActivate)
            {
                textUI.text = textToShow;
                associatedObject.material = newMatrial;
            }
        }

        // When the mouse leaves the GameObject, it will turn back to its original color
        void OnMouseExit()
        {
            textUI.text = "";
            associatedObject.material = origMaterial;
        }
    }
}