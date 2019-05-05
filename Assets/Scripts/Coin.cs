using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextMesh numberDisplay; //our own TextMesh display
    public int correspondingNumber; //set by the spawner
    CoinSpawner coinSpawner; //our spawner

    //the coin has to be initialized by the spawner. Since its a Monobehaviour, we cant call a constructor.
    public Coin Init(int correspondingNumber, CoinSpawner coinSpawner){
        this.correspondingNumber = correspondingNumber;
        this.coinSpawner = coinSpawner;
        this.numberDisplay.text = this.correspondingNumber.ToString();
        return this;
    }
    void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag == "Player"){       //Check if colliding with player
            this.coinSpawner.CoinHit(this);     //tell Coinspawner wich coin was hit (this)
            Destroy(this.gameObject);        //destroy if true

        }else{
                    //do nothing if false
        }
    }

}
