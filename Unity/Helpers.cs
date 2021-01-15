/*  A helper script that can be referenced statically in any class that this is declared.
 *  
 *  This script is useful if there is a specific helper function that is being used in more than
 *  one class, so by having it referenced in here, it will be less copy/pasting.
 * 
 */

using System.Collections;
using UnityEngine;

namespace GameUtils
{
    public static class HelperFuncs
    {
        // An Enumerator that times the destruction of a passed in object
        // The actual Coroutine should still happen in the obj that is using the Coroutine
        public static IEnumerator DestroyObjAtTime(float timeToWait, GameObject objToDestroy)
        {
            yield return new WaitForSeconds(timeToWait);
            GameObject.Destroy(objToDestroy);
        }

        // A function that returns either true or false if a given tag is in an array of tags
        // As soon as it finds an exact match, the function concludes
        // Meaning the longest time this function will take is the length of the tagList
        public static bool CompareTagWithList(string comparedTag, string[] tagList)
        {
            for (int index = 0; index < tagList.Length; ++index)
            {
                if (comparedTag == tagList[index])
                {
                    return true;
                }
            }
            return false;
        }
    }

}