using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//struct for one single object
public struct ObjectData{
    public Vector3 position;
    public Vector3 scale;
    public ObjectData(Vector3 position, Vector3 scale){
        this.position = position;
        this.scale = scale;
    }
}
