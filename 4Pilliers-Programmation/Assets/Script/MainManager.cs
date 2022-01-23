using UnityEngine;
using System.IO;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance { get; private set; }

    public string NomPlayer, ClassePlayer;
    public int ViePlayer, ForcePlayer, EnduroPlayer, IntelloPlayer, FoiPlayer;

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


    public void setClasse(string Classe, int Vie, int For, int End, int Int, int Foi)
    {
        ClassePlayer = Classe;
        ViePlayer = Vie;
        ForcePlayer = For;
        EnduroPlayer = End;
        IntelloPlayer = Int;
        FoiPlayer = Foi;

    }

    public void setName(string Name)
    {
        NomPlayer = Name;
    }

   
    [System.Serializable]
    class SaveData
    {
        public string NomPlayer,ClassePlayer;
        public int Vie, Force, Enduro, Intello, Foi;
    }

    public void SavePlayer()
    {
        SaveData data = new SaveData();

        data.NomPlayer = NomPlayer;
        data.ClassePlayer = ClassePlayer;
        data.Vie = ViePlayer;
        data.Force = ForcePlayer;
        data.Enduro = EnduroPlayer;
        data.Intello = IntelloPlayer;
        data.Foi = FoiPlayer;

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
            ViePlayer = data.Vie ;
            ForcePlayer = data.Force;
            EnduroPlayer = data.Enduro;
            IntelloPlayer = data.Intello;
            FoiPlayer = data.Foi;

           
        }
    }
}
