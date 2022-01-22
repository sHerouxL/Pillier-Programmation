using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humain : Personnage
{
    // Polymorphysme method virtual indicates that it can, but doesn’t have to, be overridden..
    public virtual void Attaque()
    {
       
    }

    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected override void FindTarget()
    {
        //Lance un scan pour detecter un présence 
    }

    public override void GoTo(Vector3 position)
    {
        // fait une action différente
        base.GoTo(position); // run method from base class
    }

    public override void Walk()
    {

        Debug.Log("marche depuis la classe humain");
       
    }
}

