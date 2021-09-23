using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string LevelToLoad;
    private void OnTriggerEnter(Collider other)
    {
        if (Options.timer == 2)
        {
            Debug.Log(Options.time);
            if (Options.timer == 2) { }
            Options.time = 0;
        }
        Options.LeftOff = LevelToLoad.ToString();
        SceneManager.LoadScene(LevelToLoad);
    }
}
