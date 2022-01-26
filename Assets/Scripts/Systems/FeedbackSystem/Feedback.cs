using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JC.Feedback 
{
    public abstract class Feedback : MonoBehaviour // "abstract" cette classe servira de base pour d'autres classes
    {
        #region Virtuals

        public virtual void Play() // cette fonction pourra etre "overrided"
        {
            Debug.Log("FeedbackPlayed");
        }

        #endregion
    }
}
