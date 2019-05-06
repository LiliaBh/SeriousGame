using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

[System.Serializable]
public class LevelLoader : MonoBehaviour
{
    public string pathToFile;
    public string jsonString;
    public GameObject wall, wall1, wall2, wall3;
    public GameObject Floor;
    public GameObject Player;
    static Level level1, level2, level3;
    static Level currentLevel = level1;
    //StreamReader levelRead = new StreamReader(Application.streamingAssetsPath);

    [System.Serializable]
    public struct Level
    {
        public string[] walls;
        public string[] floors;
        public string player;

        public Level(string[] walls, string[] floors, string player)
        {
            this.walls = walls;
            this.floors = floors;
            this.player = player;
        }
    }

    [System.Serializable]
    public struct ObjectData
    {
        public Vector3 position;
        public Vector3 scale;
        public ObjectData(Vector3 position, Vector3 scale)
        {
            this.position = position;
            this.scale = scale;
        }
    }

    public void Awake()
    {
        Application.LoadLevel("Startmenue");
        initializeLevels();
        instantiateFromJson();
    }

    // Update is called once per frame
    public void Update()
    {
        if (CoinSpawner.score>5)
        {
            this.loadNextLevel();
        }
    }

    public void initializeLevels()
    {
        setLevel(level1, "Level01.json");
        setLevel(level2, "Level02.json");
        setLevel(level3, "Level03.json");
    }

    public void setLevel(Level level, string fileName)
    {
        pathToFile = Path.Combine(Application.streamingAssetsPath, fileName);
        //levelRead = new StreamReader(pathToFile);
        jsonString = File.ReadAllText(pathToFile);
        level = JsonUtility.FromJson<Level>(jsonString);
    }

    public void loadNextLevel()
    {
        if( currentLevel.Equals(level1))
        {
            currentLevel = level2;
            instantiateFromJson();
        }
        else if (currentLevel.Equals(level2))
        {
            currentLevel = level3;
            instantiateFromJson();
        }
    }

    public void instantiateFromJson()
    {
        //adapt Xiao's to read from level
    }

}



