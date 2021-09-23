using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TryCounter : MonoBehaviour
{
    public GameObject Player;
    private Die DieScript;
    public TextMeshProUGUI Text;
    // Start is called before the first frame update
    void Start()
    {
        DieScript = Player.GetComponent<Die>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "Tries: " + (DieScript.Deaths/2).ToString();
    }
}
