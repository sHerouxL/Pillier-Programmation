using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Humain
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override string Walk(string value)
    {        
        return value + " Les archer ne font pas l'action sp�cial de l'humain, m�thode differnte override 3iem niveau ";
    }
}
