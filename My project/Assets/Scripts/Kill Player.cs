using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillProjectile : MonoBehaviour
{

    void Start()
    {
        
    }
public int Respawn;

    void Update()
    {
        
    }


void OnTriggerEnter2D(Collider2D other) 
{
    if(other.CompareTag("Player"))
{
    SceneManager.LoadScene(Respawn);
}
}
}