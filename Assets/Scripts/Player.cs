using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioComponent audioComp = GetComponent<AudioComponent>();
        audioComp.Play(audioComp.audioList[0]);
    }
}
