using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class Movement : MonoBehaviour
{
    protected Tilemap tm;
    protected Tilemap board;

    private void Start()
    {
        tm = GameObject.FindGameObjectWithTag("Pieces").GetComponent<Tilemap>();
        board = GameObject.FindGameObjectWithTag("Board").GetComponent<Tilemap>();
    }

    public abstract bool[,] PossibleMoves(Vector3Int pos, bool isWhite);
}