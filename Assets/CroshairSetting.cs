using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CroshairSetting : MonoBehaviour
{
    public GameObject croshairImage;
    // Start is called before the first frame update
    void Start()
    {
        croshairImage.SetActive(Options.CroshairEnabled);
    }

}
