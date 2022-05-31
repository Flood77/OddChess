using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class RookMovement : Movement
{
    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8, 8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;
        var color = isWhite ? "white" : "black";

        Tile temp;
        bool up = true, down = true, left = true, right = true;

        for (int i = 0; i < 8; i++)
        {
            if (y + i <= 7 && up)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x, y + i, z));
                if (temp == null)
                {
                    result[x, y + i] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x, y + i] = true;
                    up = false;
                }
            }

            if ( y - i <= 7 && down)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x, y - i, z));
                if (temp == null)
                {
                    result[x, y - i] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x, y - i] = true;
                    down = false;
                }
            }

            if (x + i <= 7 && right)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + i, y, z));
                if (temp == null)
                {
                    result[x + i, y] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x + i, y] = true;
                    right = false;
                }
            }

            if (x + i <= 7 && left)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - i, y, z));
                if (temp == null)
                {
                    result[x - i, y] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x - i, y] = true;
                    left = false;
                }
            }

            if (!up && !down && !left && !right) i = 10;
        }

        return result;
    }
}
