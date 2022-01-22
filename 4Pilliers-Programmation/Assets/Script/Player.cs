using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    private Archer archer;
    private Guerrier guerrier;
    private Magicien magicien;

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

    }

    public void CreatePlayer(int Qty)
    {
        archer.Afficher();
        archer.Jump();
        archer.Walk();

        guerrier.Afficher();
        guerrier.Jump();
        guerrier.Walk();

        //archer.NameControle = MainManager.Instance.NomPlayer;
        //archer.ClasseControle = MainManager.Instance.ClassePlayer;


        //archer.Walk();
    }




}
