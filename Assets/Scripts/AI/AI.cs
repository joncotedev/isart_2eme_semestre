using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
public class AI : MonoBehaviour
{
    #region Fields

    private float health = 0;

    private StateMachine fsm;

    [SerializeField]
    [Range(1, 10)]
    private int maximumHealth = 3;

    [SerializeField]
    [Range(30, 60)]
    private float speed = 30f;

    #endregion

    #region Messages

    private void Awake()
    {
        health = maximumHealth;

        var child = this.gameObject.transform.GetChild(0);

        if (child.GetComponent<StateMachine>() != null)
        {
            fsm = child.GetComponent<StateMachine>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            DamageHealth(1);
        }
    }

    #endregion

    #region Methods

    public void DamageHealth(float value)
    {
        if (health < Mathf.Ceil(maximumHealth / 2))
        {
            fsm?.ChangeTo("Fleeing");
        }

        health -= value;
    }

    #endregion
}
