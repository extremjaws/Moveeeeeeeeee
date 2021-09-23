using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject Player;
    private Vector3 StartPosition;
    void Start()
    {
        StartPosition = Player.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.name == "Player")
       // {
            Player.transform.position = StartPosition;
       // } 
    }
}   
