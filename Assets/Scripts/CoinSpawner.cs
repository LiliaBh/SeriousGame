using UnityEngine;
using UnityEngine.SceneManagement;

//This class will spawn a new coin each time the old one is destroyed
public class CoinSpawner : MonoBehaviour
{

    [SerializeField] Transform floor; //to drag the floor cube into. The transform will be taken automatically
    [SerializeField] Coin coin; //the prefab with coin script attached to it
    Coin spawnedCoin; // private variable to hold track of current spawned coin
    public Operation operation{get; private set;}
    public static int score;

    public Scene scene;
    public static float p = .5f; //p probability value
  
    void Start()
    {
        this.Respawn(); //spawn new Coin
        scene = SceneManager.GetActiveScene();
    }

    //Increase the probability of the sum operation
    public void increaseProSum()
    {
        if (p > 0f) { p = p - .05f; }
        Debug.Log("Increase probability of the sum operation. p= ");
        Debug.Log((1-p).ToString());
    }

    //Increase the probability of the substraction operation
    public void increaseProSub()
    {
        if (p < 1f) { p = p + .05f; }
        Debug.Log("Increase probability of the substraction operation. p= ");
        Debug.Log(p.ToString());
    }

    //Change the probability of the corresponding operation
    public void updateProbability()
    {
        if (this.operation.operationSymbol == "+")
        {
            this.increaseProSum();
        }
        else
        {
            this.increaseProSub();
        }
    }

    //when a coin gets hit, it has to call this method
    public void CoinHit(Coin coin){
        bool firstTrial = true;
        if (coin.correspondingNumber == this.operation.Result())
        {
            score++;
            if (scene.name == "Exercise 2")
            {
                //Reset probability of the corresponding operation
                if (!(p == .5f) && firstTrial)
                {
                    this.updateProbability();
                }
            }
            this.Respawn(); //if it was the correct coin => Respawn
        }
        else
        {
            if (score > 0)
            {
                score--;
            }

            if (scene.name == "Exercise 2")
            {
                this.updateProbability();
            }
        }
    }

    void Respawn(){
        foreach(Coin coin in FindObjectsOfType<Coin>()){
            Destroy(coin.gameObject); //Destroy all remaining coins on the field;
        }

        if(Random.Range(0f, 1f) > p){ //Decide wich operation should be generated
            this.operation = new Sum(Random.Range(0, 50), Random.Range(0, 50));
        }else{
            this.operation = new Substract(Random.Range(0,50), Random.Range(0, 50));
        }

        this.Spawn(this.operation.Result()); //spawn the correct coin
        for(int i = 0; i < 3; i++){ //spawn 3 maybe false coins (no check for doubled correct coins here)
            this.Spawn(Random.Range(-50, 100));
        }
    }

    void Spawn(int correspondingNumber){
        float x = Random.Range(this.floor.position.x - this.floor.lossyScale.x/2,
                                this.floor.position.x + this.floor.lossyScale.x/2); //get range of floor to spawn new coin

        float y = Random.Range(this.floor.position.y - this.floor.lossyScale.y/2,
                                this.floor.position.y + this.floor.lossyScale.y/2);

        this.spawnedCoin = Instantiate(this.coin, new Vector2(x, y), Quaternion.identity).Init(correspondingNumber, this); //actually spawn a new coin
    }
}
