using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public string LevelToLoad;
    public GameObject carrot;
    public GameObject target;
    public AnimationClip comeAnimation;
    private bool collected = false;
    private Animation animation;

    private void Start()
    {
        animation = carrot.GetComponent<Animation>();
    }

    private void Update()
    {
        if (collected)
        {
            carrot.transform.position = Vector3.Lerp(carrot.transform.position, target.transform.position, 0.8f * Time.deltaTime);
            if (Vector3.Distance(carrot.transform.position, target.transform.position) <= 0.5f)
            {
                carrot.SetActive(false);
            }
        }
            
    }

    private void OnTriggerEnter(Collider other)
    {
        if (Options.timer == 2)
        {
            Debug.Log(Options.time);
            if (Options.timer == 2) { }
            Options.time = 0;
        }
        Options.LeftOff = LevelToLoad.ToString();
        animation.Stop();
        collected = true;
        animation.clip = comeAnimation;
        animation.Play();
        Invoke("LoadNextLevel", 4);
        
    }
    private void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
