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
    private Ghoule ghoule;
    private Skelton skelton;
    private Zombie zombie;

    public Text NomJoueur,ClasseJoueur, oVie, ofor, oEnd, oInt, oFoi;
    public Text TextHumain,TextEnemy;

    public Dropdown m_Dropdown;
    public string m_Message;
    public Text m_Text;
    public int m_DropdownValue;

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
        ghoule = GameObject.Find("Ghoule").GetComponent<Ghoule>();
        skelton = GameObject.Find("Skelton").GetComponent<Skelton>();
        zombie = GameObject.Find("Zombie").GetComponent<Zombie>();

        m_Text.text = "Ghoule";

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

    public void ChooseEnnemy()
    {
        //Keep the current index of the Dropdown in a variable
        m_DropdownValue = m_Dropdown.value;
        //Change the message to say the name of the current Dropdown selection using the value
        m_Message = m_Dropdown.options[m_DropdownValue].text;
        //Change the onscreen Text to reflect the current Dropdown selection
        m_Text.text = m_Message;
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
    public void Emarcher()
    {
        if (m_Text.text == "Ghoule")
            TextEnemy.text = ghoule.Walk("Ghoule");
        else if (m_Text.text == "Skelton")
            TextEnemy.text = skelton.Walk("Skelton");
        else if (m_Text.text == "Zombie")
            TextEnemy.text = zombie.Walk("Zombie");


    }

    public void Eattaque()
    {
        if (m_Text.text == "Ghoule")
            TextEnemy.text = ghoule.Attaque("Ghoule");
        else if (m_Text.text == "Skelton")
            TextEnemy.text = skelton.Attaque("Skelton");
        else if (m_Text.text == "Zombie")
            TextEnemy.text = zombie.Attaque("Zombie");
    }

    public void Esauter()
    {
        if (m_Text.text == "Ghoule")
            TextEnemy.text = ghoule.Jump("Ghoule");
        else if (m_Text.text == "Skelton")
            TextEnemy.text = skelton.Jump("Skelton");
        else if (m_Text.text == "Zombie")
            TextEnemy.text = zombie.Jump("Zombie");


    }

    public void Edefendre()
    {
        if (m_Text.text == "Ghoule")
            TextEnemy.text = ghoule.Defence("Ghoule");
        else if (m_Text.text == "Skelton")
            TextEnemy.text = skelton.Defence("Skelton");
        else if (m_Text.text == "Zombie")
            TextEnemy.text = zombie.Defence("Zombie");


    }

}
