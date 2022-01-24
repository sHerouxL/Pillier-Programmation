using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Humain
{

    public override string Walk(string value)
    {        
        return value + " $$ Les archer ne font pas l'action spécial de l'humain, méthode differnte override 3iem niveau $$ ";
    }

    public override string Attaque(string value)
    {
        Condition condition = GameObject.Find("PlayerHolder").GetComponent<Condition>();

        if (condition.Allie)
        {
            value = base.Attaque(" $$ Allie proche, bonus attaque  $$ " + value);
            return value;
        }
        else
        {
            return value + " $$ Les archer ne font pas l'action spécial de l'humain, méthode differnte override 3iem niveau $$ ";
        }
               
    }

}




