using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PawnMovement : Movement
{
    bool isMoved = false;

    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8,8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;

        if (isWhite)
        {
            var temp = tm.GetTile<Tile>(new Vector3Int(x, y + 1, z));
            if(temp == null) result[x, y + 1] = true;
            
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 1, z));
            if(temp != null)
            {
                if (temp.sprite.name.Split('_')[0] != "white") result[x + 1, y + 1] = true;
            }
            else if(isMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y, z));
                if(temp != null)
                {
                    var name = temp.sprite.name.Split('_');
                    if (name[0] != "white" && name[1] == "pawn") result[x + 1, y + 1] = true;
                }
            }

            temp = tm.GetTile<Tile>(new Vector3Int(x -1, y + 1, z));
            if (temp != null)
            {
                if (temp.sprite.name.Split('_')[0] != "white") result[x - 1, y + 1] = true;
            }
            else if (isMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y, z));
                if (temp != null)
                {
                    var name = temp.sprite.name.Split('_');
                    if (name[0] != "white" && name[1] == "pawn") result[x - 1, y + 1] = true;
                }
            }
        }
        else
        {
            var temp = tm.GetTile<Tile>(new Vector3Int(x, y - 1, z));
            if (temp == null) result[x, y - 1] = true;

            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y - 1, z));
            if (temp != null)
            {
                if (temp.sprite.name.Split('_')[0] == "white") result[x + 1, y - 1] = true;
            }
            else if (isMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y, z));
                if (temp != null)
                {
                    var name = temp.sprite.name.Split('_');
                    if (name[0] == "white" && name[1] == "pawn") result[x + 1, y - 1] = true;
                }
            }

            temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y - 1, z));
            if (temp != null)
            {
                if (temp.sprite.name.Split('_')[0] == "white") result[x - 1, y - 1] = true;
            }
            else if (isMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y, z));
                if (temp != null)
                {
                    var name = temp.sprite.name.Split('_');
                    if (name[0] == "white" && name[1] == "pawn") result[x - 1, y - 1] = true;
                }
            }
        }

        return result;
    }

    public void HasMoved(bool moved)
    {
        isMoved = moved;
    }

    //TODO: Implement en pasant & Promotion
}
