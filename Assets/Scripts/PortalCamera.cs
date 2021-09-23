using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalCamera : MonoBehaviour
{
    public Camera Pcam;
    public Camera cam;
    public Transform window;
    public Transform destination;
    public RenderTexture tex;
    private void Start()
    {
        cam.enabled = false;
    }
    private void OnPreRender()
    {
        Matrix4x4 m = destination.localToWorldMatrix * window.worldToLocalMatrix * Pcam.transform.localToWorldMatrix;
        cam.transform.SetPositionAndRotation(m.GetColumn(3),m.rotation);
        cam.fieldOfView = Pcam.fieldOfView;
        tex.width = Screen.width;
        tex.height = Screen.height;
        cam.Render();
    }
}
