using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//stores jsonStrings of each object(beside coins) in game
public struct Level{
    public string[] walls;
    public string[] floors;
    public string player;

    public Level(string[] walls, string[] floors, string player){
        this.walls = walls;
        this.floors = floors;
        this.player = player;
    }
}