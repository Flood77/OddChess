using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingMovement : Movement
{
    private bool isMoved = false;
    private GameManager manager;

    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8, 8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;
        var color = isWhite ? "white" : "black";



        return result;
    }

    public void GetVar(bool hasMoved, GameManager man)
    {
        manager = man;
        isMoved = hasMoved;
    }
}
