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

    }

    public virtual void Process()
    {
        
    }

    public virtual void Exit(State next)
    {

    }

    #endregion
}
