using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magicien : Humain
{
    // Start is called before the first frame update
    public override string Defence(string value)
    {
        return value + " Les magicien ont un mallus en défence ";
    }
}
