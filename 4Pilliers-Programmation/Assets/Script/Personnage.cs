using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Personnage : MonoBehaviour
{
    // Start is called before the first frame update

    public static Personnage Instance { get; private set; }

    private string NomPerso;
    private int ViePerso = 100;
    //private int Force = 10;

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


    void awake()
    {
        Debug.Log("Classe personnage lancée dans l'awake");

    }

    void Start()
    {
        Debug.Log("Classe personnage lancée");


    }

    // Humain détecte créature avec range fonction du perso attaque sinon retour point vecteur donne (vecteur vs collider)
    // Enemy cherche un objet a détruire et attaque personnage seulement si un range en fonction du genre de creature

    // Polymorphysme, Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden
    protected abstract void FindTarget();

    // method overloading
    public virtual void GoTo(Enemy enemy)
    {

    }

    public virtual void GoTo(Player position)
    {

    }

    public virtual void GoTo(Vector3 position)
    {
        // marche vers le point a
    }


    public void Afficher()
    {
        Debug.Log("Affiche depuis la classe personnage");
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

    public virtual void Jump()
    {

        Debug.Log("saute depuis la classe personnage");
        //JumpText.text = "saute depuis la classe personnage";
    }

    public virtual void Walk()
    {
        //WalkText.text = "marche depuis la classe personnage";
        Debug.Log("marche depuis la classe personnage");
    }

    public void Defence()
    {
        Debug.Log("défence depuis la classe personnage");
    }
}

