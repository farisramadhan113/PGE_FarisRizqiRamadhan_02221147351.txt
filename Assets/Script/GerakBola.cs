using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakBola : MonoBehaviour
{
    private Rigidbody2D RB2d;
    public Rigidbody2D _RB2d => RB2d;
    public float speed = 500f;

    private void Awake()
    {
        RB2d = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        Invoke(nameof(SetRandomTrajectory), 1f);
    }

    private void SetRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-0.5f, 0.5f);
        force.y = -1;

        RB2d.AddForce(force.normalized * speed);
    }
}
