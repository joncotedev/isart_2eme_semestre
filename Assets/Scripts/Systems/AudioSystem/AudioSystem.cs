using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Audio
{
    public class AudioSystem : MonoBehaviour
    {
        #region Fields

        public static AudioSystem Instance { get; private set; }

        public GameObject AudioSource;

        #endregion

        #region Messages

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Play an AudioClip.
        /// </summary>
        public void PlayAudio(AudioClip clip)
        {
            var inst = Instantiate(AudioSource);
            AudioSource source = inst.GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
        }

        #endregion
    }
}

