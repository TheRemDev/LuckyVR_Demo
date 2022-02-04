using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public GameObject networkPlayerPrefab;
    public string playerName;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
}
