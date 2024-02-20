using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuppetManScript : MonoBehaviour
{
    Animator a;
    public bool Ga;
    public float fart;
    public bool hoyre;
    int retning;
    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3 (retning,1,1);
        if (hoyre)
        {
            retning = 1;
        }
        else
        {
            retning = -1;
        }
        if (Ga)
        {
            a.SetBool("walk", true);
            transform.position = new Vector3(transform.position.x+fart *retning *Time.deltaTime,transform.position.y,transform.position.z);
        }
        else
        {
            a.SetBool("walk", false);
        }
    }
}
