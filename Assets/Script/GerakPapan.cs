using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerakPapan : MonoBehaviour
{
    private Rigidbody2D RB2d;
    private Vector2 jarak;
    public float speed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        RB2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            jarak = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            jarak = Vector2.right;
        }
        else
        {
            jarak = Vector2.zero;
        }    
    }

    void FixedUpdate()
    {
        if (jarak == Vector2.zero)
        {
            return;
        }
        RB2d.AddForce(jarak * speed);
    }
}
