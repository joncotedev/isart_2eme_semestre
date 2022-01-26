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
            state.Enter();
        }
    }

    private void Update()
    {
        if (state != null)
        {
            state.Process();
        }
    }

    #endregion

    #region Methods

    public void ChangeTo(string name)
    {
        State newState = null;
        var states = GetComponentsInChildren<State>();

        foreach (var item in states)
        {
            if (item.transform.name == name)
            {
                newState = item;
            }
        }

        if(newState != null)
        {
            state.Exit();
            state = newState;
            state.Enter();
        }
        else
        {
            Debug.Log("Could not find new state.");
        }
    }

    #endregion
}
