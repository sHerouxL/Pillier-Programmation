using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Personnage : MonoBehaviour
{
    // Start is called before the first frame update

    public static Personnage Instance { get; private set; }

    private string NomPerso;
    private string ClassePerso;
    private int ViePerso = 100;


    public int LifeControle // delete semicolon
    {
        get { return ViePerso; } // getter returns backing field
        set { ViePerso -= value; } // setter uses backing field
    }

    public string NameControle // delete semicolon
    {
        get { return NomPerso; } // getter returns backing field
        set { NomPerso = value; } // setter uses backing field
    }

    public string ClasseControle // delete semicolon
    {
        get { return ClassePerso; } // getter returns backing field
        set { ClassePerso = value; } // setter uses backing field
    }


    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected abstract void FindTarget(string value);

    // method overloading
    public virtual void GoTo(Enemy enemy)
    {

    }

    public virtual void GoTo(Player position)
    {

    }

    public virtual void GoTo(Vector3 position)
    {
       
    }


    //Afficheur générique, on peut lui passer n'importe quoi
    public void Afficheur<T>(T valeur)
    {
        Debug.Log("Affiche depuis la classe Génerique :  " + valeur + "  " + valeur.GetType());
    }

    public void Ajouter<T>(T x, T y)
    {
        if (x is int && y is int)
        {
            int nbrX = (int)(object)x;
            int nbrY = (int)(object)y;
            Debug.Log("le resultat est : " + (nbrX + nbrY));
        }
    }

    public virtual string Jump(string value)
    {
        return value + "  saute depuis la base classe personnage";
    }

    public virtual string Walk(string value)
    {
        return value + "  marche depuis la base classe personnage";
    }

    public virtual string Attaque(string value)
    {
        return value + "  Attaque depuis la base classe personnage";  
    }

    public virtual string Defence(string value)
    {
        return value + "  Défence depuis la base classe personnage";
    }
}



