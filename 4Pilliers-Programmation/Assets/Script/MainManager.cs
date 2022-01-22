using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance { get; private set; }

    public string NomPlayer;
    public string ClassePlayer;

    private void Awake()
    {

        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }


    public void setClasse(string Classe)
    {
        ClassePlayer = Classe;
    }

    public void setName(string Name)
    {
        NomPlayer = Name;
    }


    [System.Serializable]
    class SaveData
    {
        public string NomPlayer;
        public string ClassePlayer;
    }

    public void SavePlayer()
    {
        SaveData data = new SaveData();

        data.NomPlayer = NomPlayer;
        data.ClassePlayer = ClassePlayer;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadChampion()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            NomPlayer = data.NomPlayer;
            ClassePlayer = data.ClassePlayer;
        }
    }
}
