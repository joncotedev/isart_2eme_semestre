using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioComponent : MonoBehaviour
{
    #region Variables

    public List<AudioClip> audioList = new List<AudioClip>();

    #endregion

    public void Play(AudioClip audio)
    {
        AudioSystem.Instance.PlayAudio(audio);
    }
}
