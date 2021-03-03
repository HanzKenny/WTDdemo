using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImaginaryMissile : MonoBehaviour
{
    public enum HomingMode
    {
        SnapToTarget,
        EaseToTarget,
        PredictTargetMovement,
    }

    [SerializeField]
    private float m_speed;
    [SerializeField]
    private float m_damage;
    [SerializeField]
    private bool m_willFollowTarget;
    [SerializeField]
    private HomingMode m_homingMode;
    [SerializeField]
    private GameObject m_explosionFX;

    private Transform m_target;
    private Rigidbody2D m_rigidbody2D;

    public event Action OnExplode;

    public HomingMode homingMode { get { return m_homingMode; } set { m_homingMode = value; } }
    public Transform target => m_target;

    public void SetSpeed(float speed)
    {
        m_speed = speed;
    }

    public void SetTarget(Transform transform)
    {
        m_target = target;
    }

    public void Explode()
    {
        //Create Explosion
        OnExplode?.Invoke();
        Destroy(gameObject);
    }

    private Quaternion GetRotationAdjustmentToTarget()
    {
        var rotationAdjustment = Quaternion.identity;
        //Do Some Calculation base on HomingAccuracy
        return rotationAdjustment;
    }

    private void MoveTowardsDirection(Vector3 direction)
    {
        m_rigidbody2D.velocity = direction * m_speed;
    }

    private void HandleCollisionWith(GameObject collidedWith)
    {
        //Deal Damage to whatever we collideded with, 
    }

    private void Start()
    {
        MoveTowardsDirection(transform.right);
    }

    private void Update()
    {
        if (m_willFollowTarget)
        {
            var rotationAdjustment = GetRotationAdjustmentToTarget();
            //Apply Rotation Adjustment
        }
        MoveTowardsDirection(transform.right);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HandleCollisionWith(collision.gameObject);
        Explode();
    }
}
