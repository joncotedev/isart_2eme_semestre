using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Feedback;
using JC.Audio;

public class Player : MonoBehaviour
{
    [SerializeField]
    private FeedbackComponent jumpFeedback;

    void Start()
    {
        AudioComponent audioComp = GetComponent<AudioComponent>();
        audioComp.Play(audioComp.audioList[0]);
    }

    #region Messages

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
            JC.Feedback.FeedbackSystem.Instance.PlayFeedbacks(JC.Feedback.FeedbackType.Particles);
        }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Makes the player jump.
    /// </summary>
    private void Jump()
    {
        // logic to jump
        jumpFeedback.PlayFeedbacks();
    }

    #endregion
}
