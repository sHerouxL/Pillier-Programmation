using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstre : Personnage
{
    private Player EnemyTarget;

    public void Attaque(string value)
    {
        Debug.Log("attaque depuis la classe Monstre");
    }
    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected override void FindTarget(string value)
    {
        //Lance un scan pour detecter un présence 
    }

    public override string Walk(string value)
    {
        Debug.Log("marche depuis la classe Monstre");
        return value + "marche depuis la classe Monstre";
    }
}
