using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstre : Personnage
{
    private Player EnemyTarget;

    public void Attaque()
    {
        Debug.Log("attaque depuis la classe Monstre");
    }
    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected override void FindTarget()
    {
        //Lance un scan pour detecter un présence 
    }

    public override void Walk()
    {
        Debug.Log("marche depuis la classe Monstre");
    }
}
