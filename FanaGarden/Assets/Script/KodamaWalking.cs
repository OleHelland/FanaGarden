using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KodamaWalking : MonoBehaviour
{
    /*
    float horizontal;
    public float moveSpeed = 2;
    public Animator animator;
    public bool facingRight;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        walk();
        //FlipCheck();
    }


    void walk()
    {

        transform.position = new Vector3(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y, transform.position.z);
        animator.SetFloat("Speed", Mathf.Abs(moveSpeed));
    }
    
    void FlipCheck()
    {
        if ( moveSpeed < 0 && !facingRight)
        {
            Flip();
        }
        else if ( moveSpeed > 0 && facingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    */
}
