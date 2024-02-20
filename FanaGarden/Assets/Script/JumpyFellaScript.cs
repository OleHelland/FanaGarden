using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpyFellaScript : MonoBehaviour
{
    public Animator a;
    bool grounded;
    bool holdHopp;
    bool hoppe;
    float hoppeCharge;
    public float maxHoppeCharge;
    public float fart;
    float idleLengde;
    public float Maxidle;
    int retning;
    Rigidbody2D rb;
    public float hoppeKraft;
    int randomRetning;
    public int snuSjanse;
    public bool rulle;
    Vector3 rotation;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = true;
        retning = 1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(retning, 1, 1);
        if (rulle)
        {
            a.SetBool("bliBall", true);
            //if (transform.rotation.z < 180)
            //{
            //    retning = 1;
            //}
            //else
            //{
            //    retning = -1;
            //}
            rotation.z = rotation.z + fart *retning *Time.deltaTime;
            movement.x = movement.x +fart *retning *Time.deltaTime;
            transform.position = movement;
            transform.Rotate(rotation * retning * Time.deltaTime * 100);
        }
        if (!rulle)
        {
            if (holdHopp)
            {
                a.SetBool("jumpHold", true);
                hoppeCharge = hoppeCharge - 1 * Time.deltaTime;
                if (hoppeCharge < 0)
                {
                    hoppe = true;
                }
            }
            else
            {
                hoppeCharge = Random.Range(0.2f, 0.2f + maxHoppeCharge);
            }
            if (hoppe)
            {
                a.SetBool("jumpHold", false);
                rb.AddForce(new Vector3(0, hoppeKraft, 0));
                grounded = false;
                holdHopp = false;
                hoppe = false;
            }
            a.SetBool("grounded", grounded);
            hopp();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        grounded = true;
        StartCoroutine(idle());

    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

    void hopp()
    {
        if (!grounded)
        {
            transform.position = movement;
            movement.x = movement.x + fart * retning * Time.deltaTime;
        }
        else
        {
            movement = transform.position;
        }
    }
    IEnumerator idle()
    {
        yield return new WaitForSeconds(Random.Range(0.2f, Maxidle/2));
        randomRetning = Random.Range(-1, snuSjanse);
        if (randomRetning == 1)
        {
            retning = retning * -1;
        }
        yield return new WaitForSeconds(Random.Range(0, Maxidle));
        holdHopp = true;
    }

}
