using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenMovement : Movement
{
    public override bool[,] PossibleMoves(Vector3Int pos, bool isWhite)
    {
        bool[,] result = new bool[8,8];

        var b = new BishopMovement().PossibleMoves(pos, isWhite);
        var r = new RookMovement().PossibleMoves(pos, isWhite);

        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                result[i,j] = b[i,j];
                result[i,j] = r[i,j];
            }
        }

        return result;
    }
}
