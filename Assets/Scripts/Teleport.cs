﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject carrot;
    private void OnTriggerEnter(Collider other)
    {
        if (Options.timer == 2)
        {
            Debug.Log(Options.time);
            if (Options.timer == 2) { }
            Options.time = 0;
        }
        Options.LeftOff = LevelToLoad.ToString();
        carrot.GetComponent<Animation>().enabled = false;
        carrot.GetComponent<Rigidbody>().useGravity = true;
        carrot.GetComponent<Rigidbody>().AddForce(2, 0, 0, ForceMode.Impulse);
        Invoke("LoadNextLevel", 4);
        
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
