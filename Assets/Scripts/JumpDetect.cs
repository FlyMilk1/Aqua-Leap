using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDetect : MonoBehaviour
{
    public bool IsOnLand = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == ("Ground"))
        {
            IsOnLand = true;
        }
        
    }
}
