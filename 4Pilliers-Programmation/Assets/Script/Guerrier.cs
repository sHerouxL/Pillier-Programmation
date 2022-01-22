using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guerrier : Humain
{
    private Enemy mEnemy;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void Attaque() // can override virtual methods from parent class
    {
        mEnemy.EnemyLife -= 15;
        Debug.Log(mEnemy.EnemyLife);

    }

}
