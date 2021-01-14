/*  This Class is very simple; it allows for the object that this script is attached to
 *  to follow the specified object with an offset.
 * 
 *  This is useful if you do not want to do a parenting with the specific object.
 * 
 */

namespace GameUtils {
    
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class FollowObj : MonoBehaviour
    {
        public GameObject objToFollow;
        public Vector3 offset;

        private void Update()
        {
            gameObject.transform.position = objToFollow.transform.position + offset;
        }
    }
}