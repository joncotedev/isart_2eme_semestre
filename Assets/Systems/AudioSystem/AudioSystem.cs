using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    #region Variables

    public static AudioSystem Instance { get; private set; }

    public GameObject AudioSource;

    #endregion

    #region Messages

    /// <summary>
    /// 
    /// </summary>
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
    /// Example
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
