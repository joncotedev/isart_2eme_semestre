using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Audio
{
    public class AudioComponent : MonoBehaviour
    {
        #region Fields

        public List<AudioClip> audioList = new List<AudioClip>();

        #endregion

        #region Methods

        public void Play(AudioClip audio)
        {
            AudioSystem.Instance.PlayAudio(audio);
        }

        #endregion
    }
}
