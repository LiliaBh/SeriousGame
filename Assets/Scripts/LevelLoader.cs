using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelLoader : MonoBehaviour
{

    private void Awake()
    {
        StreamReader levelRead = new StreamReader(Application.streamingAssetsPath);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
