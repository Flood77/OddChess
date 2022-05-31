using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KnightMovement : Movement
{
    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8, 8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;
        var color = isWhite ? "white" : "black";

        Tile temp;
        if(x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if(temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        if (x + 1 <= 7 && y + 2 <= 7)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 2, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color)
            {
                result[x + 1, y + 2] = true;
            }
        }

        return result;
    }

}
