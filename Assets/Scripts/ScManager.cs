using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class ScManager : MonoBehaviour
{

    public static ScManager Instance;
    public string playerName;
    public string highscoreName;
    public int r_Points;

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



    // Start is called before the first frame update
    void Start()
    {      
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    [System.Serializable]
    class SaveData
    {
        public string saveName;
        public int savePoints;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.saveName = highscoreName;
        data.savePoints = r_Points;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);    
    }


    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            highscoreName = data.saveName;
            r_Points = data.savePoints;
        }
    }




}
