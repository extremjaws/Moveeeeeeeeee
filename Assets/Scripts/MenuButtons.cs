using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] private GameObject MainPanel;
    [SerializeField] private GameObject SettingsPanel;
    [SerializeField] private Slider Sens;
    [SerializeField] private TMP_InputField Fov;
    [SerializeField] private Toggle GMode;
    [SerializeField] private TMP_Dropdown timer;
    [SerializeField] private TMP_Dropdown mode;
    [SerializeField] private Toggle Croshair;

    private void Start()
    {
        Sens.value = Options.Sens;
        Fov.text = Options.fov.ToString();
        GMode.isOn = Options.gamermode;
        timer.value = Options.timer;
        mode.value = Options.mode;
    }

    public void Play()
    {
        switch(Options.mode)
        {
            case 0:
                SceneManager.LoadScene(Options.LeftOff);
                break;
            case 1:
                Options.LevelTypes = new List<int> { };
                Options.LevelVecs = new List<Vector3> { };
                SceneManager.LoadScene("Editor");
                break;
            case 2:
                SceneManager.LoadScene("Player");
                break;
        }
    }

    public void Settings()
    {
        MainPanel.SetActive(false);
        SettingsPanel.SetActive(true);
    }

    public void Back()
    {
        MainPanel.SetActive(true);
        SettingsPanel.SetActive(false);
    }

    public void SetSens()
    {
        float newValue = Sens.value;
        Options.Sens = newValue;
    }

    public void SetFov()
    {
        string fov = Fov.text;
        Options.fov = float.Parse(fov);
    }

    public void SetGMode()
    {
        bool gm = GMode.isOn;
        Options.gamermode = gm;
    }
    public void SetCroshair()
    {
        Options.CroshairEnabled = Croshair.isOn;
    }

    public void SetTimer()
    {
        Options.timer = timer.value;
    }

    public void SetMode()
    {
        Options.mode = mode.value;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
