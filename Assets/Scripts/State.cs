using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State : MonoBehaviour
{

    #region Fields

    private StateMachine fsm;

    #endregion

    #region Virtuals

    public virtual void Enter()
    {
        Debug.Log("Entered " + gameObject.name.ToString() + " state.");
    }

    public virtual void Process()
    {
        Debug.Log("Runnning " + gameObject.name.ToString() + " state.");
    }

    public virtual void Exit()
    {
        Debug.Log("Exited " + gameObject.name.ToString() + " state.");
    }

    #endregion
}
