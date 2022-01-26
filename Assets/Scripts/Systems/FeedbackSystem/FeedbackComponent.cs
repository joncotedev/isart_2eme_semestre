using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JC.Feedback;

namespace JC.Feedback
{
    public class FeedbackComponent : MonoBehaviour
    {
        #region Fields

        [SerializeField]
        private List<Feedback> feedbacks = new List<Feedback>();

        public FeedbackType feedbackType = FeedbackType.None;

        #endregion

        #region Methods

        /// <summary>
        /// Launch all defined feedbacks.
        /// </summary>
        public void PlayFeedbacks()
        {
            foreach (var item in feedbacks)
            {
                item.Play();
            }
        }

        #endregion
    }
}

