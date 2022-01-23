using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameControler : MonoBehaviour
{
    public delegate void OnWaveRequest(bool value, int Quantite);
    public static event OnWaveRequest onWaveRequest;

    
    private PlayerControler playerControler;   
    private Player player;
    private bool GameON = false;

    void OnEnable()
    {
        MenuUIHandeler.onGameReady += GameReady;
        PlayerControler.onPlayerSpawn += SpawnRequest;
    }

    void OnDisable()
    {
        MenuUIHandeler.onGameReady -= GameReady;
        PlayerControler.onPlayerSpawn -= SpawnRequest;
    }


    public void Start()
    {
        player = GameObject.Find("PlayerHolder").GetComponentInChildren<Player>();
  
    }



    public void GameReady(bool value)
    {
        if (value)
            GameON = true;
    }

    public void SpawnRequest(bool value)
    {
       
        if (value && GameON)
            onWaveRequest?.Invoke(true, 6); ;


    }

}
