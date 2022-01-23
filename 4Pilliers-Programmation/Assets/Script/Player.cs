using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private Archer archer;
    private Guerrier guerrier;
    private Magicien magicien;

    public Text NomJoueur,ClasseJoueur, oVie, ofor, oEnd, oInt, oFoi;
    public Text TextHumain;


    [SerializeField]
    private int PlayerLife, PlayerStrong, PlayerEnduro;

    [SerializeField]
    private string NamePlayer, ClassePlayer;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Classe Player lancée");        

        archer = GameObject.Find("Archer").GetComponent<Archer>();
        guerrier = GameObject.Find("Guerrier").GetComponent<Guerrier>();
        magicien = GameObject.Find("Magicien").GetComponent<Magicien>();

        FillCartouche();

    }

    private void FillCartouche()
    {
        NomJoueur.text = MainManager.Instance.NomPlayer;
        ClasseJoueur.text = MainManager.Instance.ClassePlayer;
        oVie.text = MainManager.Instance.ViePlayer.ToString();
        ofor.text = MainManager.Instance.ForcePlayer.ToString();
        oEnd.text = MainManager.Instance.EnduroPlayer.ToString();
        oInt.text = MainManager.Instance.IntelloPlayer.ToString();
        oFoi.text = MainManager.Instance.FoiPlayer.ToString();
    }

    public void CreatePlayer(int Qty)
    {

    }

    public void BackMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void marcher()
    {
        if (ClasseJoueur.text == "Archer")
            TextHumain.text = archer.Walk("Archer");
        else if (ClasseJoueur.text == "Guerrier")
            TextHumain.text = guerrier.Walk("Guerrier");
        else
            TextHumain.text = magicien.Walk("Magicien");


    }

    public void attaque()
    {
        if (ClasseJoueur.text == "Archer")
            TextHumain.text = archer.Attaque("Archer");
        else if (ClasseJoueur.text == "Guerrier")
            TextHumain.text = guerrier.Attaque("Guerrier");
        else
            TextHumain.text = magicien.Attaque("Magicien");


    }

    public void sauter()
    {
        if (ClasseJoueur.text == "Archer")
            TextHumain.text = archer.Jump("Archer");
        else if (ClasseJoueur.text == "Guerrier")
            TextHumain.text = guerrier.Jump("Guerrier");
        else
            TextHumain.text = magicien.Jump("Magicien");


    }

    public void defendre()
    {
        if (ClasseJoueur.text == "Archer")
            TextHumain.text = archer.Defence("Archer");
        else if (ClasseJoueur.text == "Guerrier")
            TextHumain.text = guerrier.Defence("Guerrier");
        else
            TextHumain.text = magicien.Defence("Magicien");


    }

    public void findTarget()
    {

        //Humain humain = GameObject.Find("Humain").GetComponent<Humain>();
        //humain.fi
    }


}
