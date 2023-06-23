using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMeatSeed : MonoBehaviour
{
    [SerializeField] private int movePower;
    [SerializeField] private Rigidbody2D rigidbody;

    private void Start()
    {
        if(rigidbody== null)
        {
            rigidbody = GetComponent<Rigidbody2D>();
        }
    }

    private void FixedUpdate()
    {
        Vector3 force = new Vector2(0.0f, movePower);
        rigidbody.AddForce(force); // —Í‚ð‰Á‚¦‚é
    }
}
