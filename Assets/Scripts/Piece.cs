using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public enum pieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }

    public pieceType type;
    public KeyValuePair<int, int> position;
    public bool isWhite;

    public Piece(pieceType pt, KeyValuePair<int, int> p, bool color)
    {
        type = pt;
        position = p;
        isWhite = color;
    }

}
