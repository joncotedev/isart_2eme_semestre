using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    #region Fields

    private State state = null;

    #endregion

    #region Messages

    private void Awake()
    {
        var child = this.gameObject.transform.GetChild(0);

        if (child.GetComponent<State>() != null)
        {
            state = child.GetComponent<State>();
        }
    }

    private void Update()
    {
        state?.Process();
    }

    #endregion

    #region Methods

    // EnterState
    // ChangeTo

    #endregion
}
