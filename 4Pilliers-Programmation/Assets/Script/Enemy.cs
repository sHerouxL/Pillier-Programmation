using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Zombie zombie;
    private Ghoule ghoule;
    private Skelton skelton;

    [SerializeField]
    public int EnemyLife, EnemyStrong, EnemyEnduro;

    [SerializeField]
    private List<GameObject> EnemyListe = new List<GameObject>();

    [SerializeField]
    private List<Transform> EnemySpawnPoint = new List<Transform>();

    public GameObject EnemyHolder;

    //[SerializeField]
    //private GameObject enemyPrefab;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Classe enemy lancée");

        zombie = GameObject.Find("Zombie").GetComponent<Zombie>();
        ghoule = GameObject.Find("Ghoule").GetComponent<Ghoule>();
        skelton = GameObject.Find("Skelton").GetComponent<Skelton>();

    }


    public void CreateEnemy(int Qty)
    {


        int RandomEnemy = Random.Range(0, EnemyListe.Count);
        int RandomPosition = Random.Range(0, EnemySpawnPoint.Count);

        //Instantiate(EnnemyPrefabs, EnemySpawnPoint[RandomPosition].transform.position, Quaternion.identity, EnemyFolder.transform);

        GameObject enemy = Instantiate(EnemyListe[RandomEnemy], EnemySpawnPoint[RandomPosition].transform.position, Quaternion.identity, EnemyHolder.transform) as GameObject;

     
        enemy.SetActive(true);
        enemy.name = "ZombieSylvain";

        Debug.Log("Classe wavegenerator cree enemy  " + Qty + "  Enemy  " + RandomEnemy + "  Posi  " + RandomPosition + "  Name  " + enemy.name);
    }
}

