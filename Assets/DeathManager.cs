using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.AddDeaths();
        

    }

}
