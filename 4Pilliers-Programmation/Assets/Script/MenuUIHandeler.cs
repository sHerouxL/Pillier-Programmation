using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
    private string mClasse;

    void Start()
    {
        mClasse = "Champion";
        SceneManager.UnloadSceneAsync(0);
    }

    public void ValiderNom()
    {

    }


    public void startGame()
    {
        MainManager.Instance.setName(inputName.text);
        MainManager.Instance.setClasse(mClasse);
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
