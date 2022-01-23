using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monstre : Personnage
{
    //private Player EnemyTarget;

    public override string Attaque(string value)
    {        
        return value + " %% attaque depuis la classe Monstre %% ";
    }
    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected override void FindTarget(string value)
    {
        //Lance un scan pour detecter un présence 
    }

    public override string Jump(string value)
    {       
        return value + " %% Jump depuis la classe Monstre %% ";
    }
}
