using UnityEngine;

public class Player : MonoBehaviour
{
    public int speed = 10; //public variables are shown in inspector to be set by the designer/developer

    //should be the only Camera in scene
    //camerasettings: Projection Orthographic
    [SerializeField] Camera mainCamera; //SerializeField Attribute: shown in inspector, but still a private variable


    void Start()
    {
        //if camera not set, try to find one
        if(!this.mainCamera) //for Components and GameObject this is a short form for a null Check (this.mainCamera != null)
            this.mainCamera = FindObjectOfType<Camera>(); //Get the first(!) found Object of given type  
    }

    void Update()
    {
        this.Move();   
    }

    void Move(){
        
        Vector2 movement = (mainCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position); //convert the screenposition to a world-vector and get directionvector
        movement = movement.normalized    //normalize to a range 0-1
            * this.speed //our speed set here
                * Time.deltaTime; //always multiply with deltatime (time since last frame), so high framerates don't result in faster player

        this.transform.Translate(movement); //actually move our player
    }
}
