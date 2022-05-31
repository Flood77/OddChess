using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BishopMovement : Movement
{
    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8, 8];
        var x = pos.x;
        var y = pos.y;
        var z = pos.z;
        var color = isWhite ? "white" : "black";

        Tile temp;
        bool ur = true, ul = true, dr = true, dl = true;

        for(int i = 0; i < 8; i++)
        {
            if(x + i <= 7 && y + i <= 7 && ur)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + i, y + i, z));
                if(temp == null)
                {
                    result[x + i, y + i] = true;
                }
                else if(temp.sprite.name.Split('_')[0] != color)
                {
                    result[x + i, y + i] = true;
                    ur = false;
                }
            }

            if (x - i <= 7 && y + i <= 7 && ul)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - i, y + i, z));
                if (temp == null)
                {
                    result[x - i, y + i] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x - i, y + i] = true;
                    ul = false;
                }
            }

            if (x - i <= 7 && y - i <= 7 && dl)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x - i, y - i, z));
                if (temp == null)
                {
                    result[x - i, y - i] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x - i, y - i] = true;
                    dl = false;
                }
            }

            if (x + i <= 7 && y - i <= 7 && dr)
            {
                temp = tm.GetTile<Tile>(new Vector3Int(x + i, y - i, z));
                if (temp == null)
                {
                    result[x + i, y - i] = true;
                }
                else if (temp.sprite.name.Split('_')[0] != color)
                {
                    result[x + i, y - i] = true;
                    dr = false;
                }
            }

            if (!ur && !ul && !dr && !dl) i = 10;
        }

        return result;
    }
}
