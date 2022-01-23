using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : Monstre
{

    public override string Jump(string value)
    {
        return value + "saute depuis la classe zombie";
    }

}
