using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

    private Enemy PlayerTarget;
    private Guerrier PlayerChoice;
    private Personnage Perso;

    [SerializeField]
    private int PlayerLife, PlayerStrong, PlayerEnduro;

    [SerializeField]
    private string NamePlayer, ClassePlayer;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Classe Player lancée");

        NamePlayer = MainManager.Instance.NomPlayer;
        ClassePlayer = MainManager.Instance.ClassePlayer;

    }






}
