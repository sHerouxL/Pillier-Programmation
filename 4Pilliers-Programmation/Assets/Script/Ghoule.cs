using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghoule : Monstre
{


    public override string Jump(string value)
    {
        Condition condition = GameObject.Find("PlayerHolder").GetComponent<Condition>();



        if (!condition.Night)
        {
            value = base.Jump(" $$ le jours,  $$ " + value);
            return value;
        }
        else
        {
            return " $$ la nuit,  $$ " + value  + " $$ saute depuis la classe ghoule $$ ";
        }   

    }
    



}


