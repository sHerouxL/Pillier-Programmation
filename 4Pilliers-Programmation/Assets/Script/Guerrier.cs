using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Guerrier : Humain
{
    private Enemy mEnemy;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public override string Attaque(string value) // can override virtual methods from parent class
    {
        //Debug.Log(value + "  Ont une attaque sp�ciale qui est encore plus sp�cifique, override du grand-parent et celle du parent ");
        return value + "  Ont une attaque sp�ciale qui est encore plus sp�cifique, override du grand-parent et celle du parent ";
    }

}
