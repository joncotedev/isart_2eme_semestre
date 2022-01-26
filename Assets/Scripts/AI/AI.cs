using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CapsuleCollider))]
[RequireComponent(typeof(Rigidbody))]
public class AI : MonoBehaviour
{
    #region Fields

    private int currentHealth;
    private StateMachine stateMachine;

    [SerializeField]
    [Range(1, 10)]
    private int health = 3;

    [SerializeField]
    [Range(30, 60)]
    private float speed = 30f;

    #endregion
}
