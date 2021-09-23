using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    private Vector3 StartPosition;
    public int Deaths;
    private void Start()
    {
        StartPosition = gameObject.transform.position;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Respawn")
        {
            gameObject.transform.position = StartPosition;
            Deaths += 1;
        }
    }
}
