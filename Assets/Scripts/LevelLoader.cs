using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private GameObject[] Prefabs;
    void Start()
    {
        for(int i=0; i < Options.LevelTypes.Count; i++)
        {
            Instantiate(Prefabs[Options.LevelTypes[i]], Options.LevelVecs[i], Quaternion.identity);
        }
    }
}
