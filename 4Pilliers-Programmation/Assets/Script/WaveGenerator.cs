using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveGenerator : MonoBehaviour
{

    private Enemy enemy;
    //MyScript script = obj.AddComponent<MyScript>();

    private void Start()
    {
        //Constructeur de Unity GetComponent vs New, spécific CSharp constructor 
        enemy = GameObject.Find("EnemyHolder").GetComponentInChildren<Enemy>();
    }

    // inscription a un evenement et entre dans la fonction si message envoyé, 
    void OnEnable()
    {
        GameControler.onWaveRequest += WaveRequested;
    }

    void OnDisable()
    {
        GameControler.onWaveRequest -= WaveRequested;
    }



    public void WaveRequested(bool value, int Quantite)
    {
        Debug.Log("SpawnRequest from wave generator");
        if (value)
            enemy.CreateEnemy(Quantite);

    }





}
