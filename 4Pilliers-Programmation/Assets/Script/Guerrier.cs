using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guerrier : Humain
{

    public override string Attaque(string value) // can override virtual methods from parent class
    {
      
        return value + " $$ Ont une attaque sp�ciale qui est encore plus sp�cifique, override du grand-parent et celle du parent $$ ";
    }

}
