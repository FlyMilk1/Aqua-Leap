using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Incoming : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-Speed, 0);
    }

   
}
