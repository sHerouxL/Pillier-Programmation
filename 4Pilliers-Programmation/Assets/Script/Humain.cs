using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humain : Personnage
{
    // Polymorphysme method virtual indicates that it can, but doesn’t have to, be overridden..
    public override string Attaque(string value)
    {
        return value + "  -- les humain ont un attaque Spécial, elle override celle de la classe parent ";        
    }

    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected override void FindTarget(string value)
    {
        //Lance un scan pour detecter un présence 
    }

    public override void GoTo(Vector3 position)
    {
        // fait une action différente
        base.GoTo(position); // run method from base class
    }

    public override string Walk(string value)
    {
        value = base.Walk(value + "  -- les humain ont une actin a faire avant et ensuite on retourne dans la base classe + ");
        return  value;

    }
}

