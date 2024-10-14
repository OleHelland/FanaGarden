using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstVariables : MonoBehaviour
{
    public int playerHealth = 100;
    // float playerPosition = 0.2f;
    public bool playerAlive;
    public string playerName = "Bob";
    public string monsterName = "Kåre";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello, my name is " + playerName + ", and I have " +
            playerHealth + " in HP.");
    }
    // < > = &
    // Update is called once per frame
    void Update()
    {
        PlayerInput();     
        
    }
    void PlayerInput()
    {
        if (Input.GetButtonDown("Fire1") && playerHealth > 0)
        {
            playerHealth = playerHealth - 1;
            Debug.Log("Oh no, I met a " + monsterName + ", and now I only have "
                + playerHealth + " in HP.");
        }

        else if (playerHealth == 0)
        {
            Debug.Log("And I am dead. :(");
            playerHealth = playerHealth - 1;
        }
    }

    void GameOver()
    {

    }
}
