using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Edit : MonoBehaviour
{
    [SerializeField] private List<GameObject> Objects;
    [SerializeField] private GameObject[] Prefabs;
    private int Selected = 0;
    private GameObject prev;
    [SerializeField] private Material PrevMaterial;

    private void Start()
    {
        prev = Instantiate(Prefabs[Selected], gameObject.transform);
        prev.GetComponent<MeshRenderer>().material = PrevMaterial;
    }

    void Update()
    {
        if (Input.GetButtonDown("W"))
            gameObject.transform.position += new Vector3(0, 0, 1);//  W
        if (Input.GetButtonDown("A"))
            gameObject.transform.position += new Vector3(-1, 0, 0);// A
        if (Input.GetButtonDown("S"))
            gameObject.transform.position += new Vector3(0, 0, -1);// S
        if (Input.GetButtonDown("D"))
            gameObject.transform.position += new Vector3(1, 0, 0);//  D
        if (Input.GetButtonDown("R"))
        {
            for(int i=0; i<Objects.Count; i++)
            {
                if(Objects[i].transform.position == prev.transform.position)
                {
                    GameObject g = Objects[i];
                    Options.LevelTypes.RemoveAt(i);
                    Options.LevelVecs.RemoveAt(i);
                    Objects.Remove(g);
                    Destroy(g);
                }
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            GameObject e = Instantiate(Prefabs[Selected], gameObject.transform.position, Quaternion.identity);
            Options.LevelTypes.Add(Selected);
            Options.LevelVecs.Add(e.transform.position);
            Objects.Add(e);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Selected += 1;
            if (Selected >= Prefabs.Length)
                Selected = 0;
            Destroy(prev);
            prev = Instantiate(Prefabs[Selected], gameObject.transform);
            prev.GetComponent<MeshRenderer>().material = PrevMaterial;
        }
        if (Input.GetButtonDown("Cancel"))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
