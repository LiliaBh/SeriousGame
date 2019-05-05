using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FormulaDisplay : MonoBehaviour
{
    public Text display; //corresponding Text display (UI -> Text)
    public CoinSpawner coinSpawner; //our Coinspawner with the current formula to solve

    void Update(){
        this.display.text = this.coinSpawner.operation.formula; //draw the formula. Could be optimized via callback/events
    }
}
