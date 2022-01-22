using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humain : Personnage
{
    // Start is called before the first frame update

    private Enemy PlayerTarget;

    //public void Start()
    //{
    //    Debug.Log("Classe Humain lancée");
    //}


    // Polymorphysme method virtual indicates that it can, but doesn’t have to, be overridden..
    public virtual void Attaque()
    {
        PlayerTarget.EnemyLife -= 10;

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
        //JumpText.text = "saute depuis la classe personnage";
    }
}

