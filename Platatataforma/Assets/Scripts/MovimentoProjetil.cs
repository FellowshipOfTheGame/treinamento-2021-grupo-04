using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoProjetil : MonoBehaviour
{
    public int dir;
    public float speed = 400;
    public Rigidbody2D rb2d;
    public Vector2 vel;

    // Start is called before the first frame update,
    void Start()
    {
        vel.x = 1f;
        vel.y = 1f;
        rb2d.AddForce(vel * speed);

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
