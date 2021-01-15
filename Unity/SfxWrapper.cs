/*  This class is used to instanciate objects that can hold useful data for
 *  the programmer/designer. Specifically, if we want to create a box for easily
 *  accessing and playing specific sound effects in the Unity Engine.
 *  
 *  To use this, simply place this in your scripts folder and import in this namespace.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameUtils
{

    [System.Serializable]
    public struct SfxWrapper
    {
        [Tooltip("The soundclip to associate with this sound file")]
        [SerializeField]
        private AudioClip soundClip;
        [Tooltip("The volume associated with this sound file. Range of [0f,1f]")]
        [Range(0.1f, 1f)]
        [SerializeField]
        private float soundVolume;

        // Creates a new SfxWrapper with the associated files
        public SfxWrapper(AudioClip currClip, float currVol)
        {
            soundClip = currClip;
            soundVolume = currVol;
        }

        // Plays the sound clip using a referenced Audio Source
        public void PlaySoundClip(AudioSource sfx)
        {
            sfx.PlayOneShot(soundClip, soundVolume);
        }
    }

}