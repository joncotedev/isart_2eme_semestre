using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Feedback
{
    public enum FeedbackType
    {
        None,
        General,
        Particles
    }

    public class FeedbackSystem : MonoBehaviour
    {
        #region Fields

        public static FeedbackSystem Instance { get; private set; } // get permet de lire, private set empeche la modification a partir d'une autre classe

        #endregion

        #region Messages

        private void Awake()
        {
            if (Instance == null) // on s'assure que instance est null
            {
                Instance = this; // on assigne cette classe a l'instance
                DontDestroyOnLoad(this); // on s'assure que cet objet n'est pas detruit entre les scenes
            }
            else
            {
                Destroy(this.gameObject); // si jamais cette classe a deja une instance, on la detruit
            }
        }

        #endregion

        #region Methods

        public void PlayFeedbacks(FeedbackType type)
        {
            var items = GameObject.FindObjectsOfType<FeedbackComponent>();

            foreach (FeedbackComponent item in items)
            {
                if (item.feedbackType == type)
                {
                    item.PlayFeedbacks();
                }
            }
        }

        #endregion
    }
}
