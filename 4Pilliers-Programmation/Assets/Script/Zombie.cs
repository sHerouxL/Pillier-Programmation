using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Monstre
{

    public override string Jump(string value)
    {
        //Debug.Log("saute depuis la classe zombie");
        return value + "saute depuis la classe zombie";
    }

}
