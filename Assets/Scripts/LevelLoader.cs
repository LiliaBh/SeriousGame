using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
//using JsonUtility;

public class LevelLoader : MonoBehaviour
{

    public void Awake()
    {
        Application.LoadLevel("Startmenue");
    }

}
/*private string file = Path.Combine(Application.streamingAssetsPath, "/Level01.json");
private string jsonString = File.ReadAllText(file);
public List<GameObjects> GameObjects { get; set; }*/

/* private void Awake()
 {
     //StreamReader levelRead = new StreamReader(Application.streamingAssetsPath);
 }

 // Start is called before the first frame update
 void Start()
 {

 }

 // Update is called once per frame
 void Update()
 {
   //  JsonUtility.FromJsonOverwrite(jsonString, objects);
 }
}

/*public class Level : Monobehaviour
{

 public void Load(string savedData)
 {
     JsonUtility.FromJsonOverwrite(savedData, this);
 }
}

public class ObjectData : Monobehaviour
{
 Walls walls;
 Floor floor;
 Player player;
 Coin coins;
}
*/


