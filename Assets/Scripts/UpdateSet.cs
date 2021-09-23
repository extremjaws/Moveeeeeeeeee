using Fragsurf.Movement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UpdateSet : MonoBehaviour
{
    [SerializeField] private Camera camera;
    [SerializeField] private TMP_Text TimeDis;
    void Update()
    {
        camera.fieldOfView = Options.fov;
        camera.GetComponentInParent<PlayerAiming>().sensitivityMultiplier = Options.Sens;
        gameObject.GetComponent<SurfCharacter>().movementConfig.autoBhop = Options.gamermode;
        if (Input.GetButtonDown("Cancel"))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Options.time = 0;
            SceneManager.LoadScene("Main Menu");
        }
        if(Options.timer > 0)
        {
            Options.time += Time.deltaTime;
            TimeDis.text = (Mathf.Floor(Options.time*100)/100).ToString();
        }
    }
}
