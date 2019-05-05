using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Text highscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.highscore.text = "Highscore:" + CoinSpawner.score;
    }
}
