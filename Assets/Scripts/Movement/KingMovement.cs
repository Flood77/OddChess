using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class KingMovement : Movement
{
    private bool isMoved = false;
    private bool leftRookMoved = false;
    private bool rightRookMoved = false;
    private GameManager manager;

    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8, 8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;
        var color = isWhite ? "white" : "black";

        bool up = (y+1 <= 7), 
            down = (y-1 >= 0), 
            right = (x+1 <= 7), 
            left = (x-1 >= 0);

        Tile temp;
        if (up)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x, y + 1, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x, y + 1] = true;
            if (right)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y + 1, z));
                if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x + 1, y + 1] = true;
            }
            if (left)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y + 1, z));
                if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x - 1, y + 1] = true;
            }
        }

        if (down)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x, y - 1, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x, y - 1] = true;
            if (right)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y - 1, z));
                if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x + 1, y - 1] = true;
            }
            if (left)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y - 1, z));
                if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x - 1, y - 1] = true;
            }
        }

        if (right)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x + 1, y] = true;
        }

        if (left)
        {
            temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y, z));
            if (temp == null || temp.sprite.name.Split('_')[0] != color) result[x - 1, y] = true;
        }

        if (!isMoved)
        {
            if (!rightRookMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + 1, y, z));
                if(temp == null)
                {
                    temp = tm.GetTile<Tile>(new Vector3Int(x + 2, y, z));
                    if(temp == null)
                    {
                        result[x + 2, y] = true;
                    }
                }
            }

            if (!leftRookMoved)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - 1, y, z));
                if (temp == null)
                {
                    temp = tm.GetTile<Tile>(new Vector3Int(x - 2, y, z));
                    if (temp == null)
                    {
                        temp = tm.GetTile<Tile>(new Vector3Int(x - 3, y, z));
                        if(temp == null)
                        {
                            result[x - 3, y] = true;
                        }
                    }
                }
            }
        }

        return result;
    }

    public void GetVar(bool hasMoved, bool rightMoved, bool leftMoved, GameManager man)
    {
        manager = man;
        isMoved = hasMoved;
        leftRookMoved = leftMoved;
        rightRookMoved = rightMoved;
    }


    //TODO: Implement Castling
}
