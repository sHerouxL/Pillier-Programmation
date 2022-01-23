using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


#if UNITY_EDITOR
using UnityEditor;
#endif


[DefaultExecutionOrder(1000)]

public class MenuUIHandeler : MonoBehaviour
{
    // Start is called before the first frame update

    public delegate void OnGameReady(bool value);
    public static event OnGameReady onGameReady;

    public InputField inputName;
    public Text ClasseName;

    //private Dictionary<int, (string, int)> SetupPerso = new Dictionary<int, (string, int)>();
    ////private List<(string, int)> SetupPerso = new List<(string myString, int monInt)>();
    private int Vie, Force, Enduro, Intello, Foi  = 10;
    public Text oVie, oForce, oEnduro, oIntello, oFoi;
    
    [SerializeField]
    private int valDefault = 10;

    void Start()
    {
        //SceneManager.UnloadSceneAsync(0);

    }


    public void ValiderNom()    {
        
      
    }

    private void setValeuClasse(int iVie, int iForce, int iEnduro, int iIntello, int iFoi)
    {
        Vie += iVie;
        Force += iForce;
        Enduro += iEnduro;
        Intello += iIntello;
        Foi += iFoi;        
    }

    public void ResetClassePlayer()
    {
        Vie = Force = Enduro = Intello = Foi = valDefault;

    }


    public void ValeurClasse(int indice)
    {
        ResetClassePlayer();

        if (indice == 1)
        {
            ClasseName.text = "Guerrier";
            setValeuClasse(3, 5, 0, -3, -5);

        }
        
        if (indice == 2)
        {
            ClasseName.text = "Archer";
            setValeuClasse(5, -3, -1, 3, 4);

        }

        if (indice == 3)
        {
            ClasseName.text = "Magicien";
            setValeuClasse(-2, -2, -1, 5, 5);
        }

        Debug.Log(Vie);

        oVie.text = Vie.ToString();
        oForce.text = Force.ToString();
        oEnduro.text = Enduro.ToString();
        oIntello.text = Intello.ToString();
        oFoi.text = Foi.ToString();

    }


    public void startGame()
    {
        MainManager.Instance.setName(inputName.text);
        MainManager.Instance.setClasse(ClasseName.text, Vie, Force, Enduro, Intello, Foi);
        MainManager.Instance.SavePlayer();

        SceneManager.LoadScene(0);
        onGameReady?.Invoke(true); ;
    }

    public void Exit()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }

}

public class Track
{    
    public int Vie { get; set; }
    public int Force { get; set; }
    public int Enduro { get; set; }
    public int Intello { get; set; }
    public int Foi { get; set; }
}
