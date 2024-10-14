using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstMethods : MonoBehaviour
{
    public int currentNumber = 24;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tallet er " + currentNumber + ".");
    }

    // Update is called once per frame
    void Update()
    {
        HandleInput();
    }

    private void HandleInput() 
    {
        if (Input.GetKeyUp("up"))
        {
            currentNumber = currentNumber + 1;
            Debug.Log("Oi, nå er tallet " + currentNumber + ".");
        }
    }
}
