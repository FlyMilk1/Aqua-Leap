using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovingBar : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator BarAnimation;
    GameObject colliding;
    public JumpDetect Jump;
    public Image img;
    // Start is called before the first frame update

    
    // Update is called once per frame
    public void Pressed()
    {
        
        BarAnimation.enabled = false;
        if (colliding.name == ("Green"))
        {
            img.transform.SetLocalPositionAndRotation(new Vector2(0, Random.Range(-36, 36)), Quaternion.identity);
            if (Jump.IsOnLand)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
                rb.AddForce(new Vector2(200, 600));
            }
            
            Jump.IsOnLand = false;

        }
    }
    private void Update()
    {
        if (Jump.IsOnLand)
        {
            if(rb.gameObject.transform.position.x > -13)
            {
                rb.velocity = new Vector2(-10, rb.velocity.y);
            }
            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
            BarAnimation.enabled = true;
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y);
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        colliding = other.gameObject;
        Debug.Log("gg");
    }
}
