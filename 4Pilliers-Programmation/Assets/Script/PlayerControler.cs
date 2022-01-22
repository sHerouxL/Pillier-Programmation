using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControler : MonoBehaviour
{
    public delegate void OnPlayerSpawn(bool value);
    public static event OnPlayerSpawn onPlayerSpawn;

    private Vector3 posClick;
    public float MaxDistance = 100;

    void Start()
    {
        Debug.Log("start class playerControler");

    }

    public void SpawnZombie()
    {
        onPlayerSpawn?.Invoke(true); ;
    }
}
