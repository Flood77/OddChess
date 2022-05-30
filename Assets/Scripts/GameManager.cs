using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{
    public Tilemap pieces;
    public Tilemap board;

    private OptionsLoader ol;

    private Dictionary<string, Dictionary<Vector2, bool>> hasMovedData = new Dictionary<string, Dictionary<Vector2, bool>>();

    void Start()
    {
        ol = FindObjectOfType<OptionsLoader>();

        SetupBoard();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var mousPos = Input.mousePosition;
            mousPos.z = 10;
            var pos = pieces.WorldToCell(Camera.main.ScreenToWorldPoint(mousPos));
            var newPos = new Vector3Int(pos.x + 1, pos.y, pos.z);

            if (pieces.GetTile(pos) != null)
            {
                pieces.SetTile(newPos, Instantiate(pieces.GetTile(pos)));

                Debug.Log(pieces.GetTile<Tile>(pos).sprite.name);

                pieces.SetTile(pos, null);
            }
        }
    }

    private void SetupBoard()
    {
        switch (ol.gameMode)
        {
            case Options.GameMode.Normal:
                hasMovedData.Add("Pawn", new Dictionary<Vector2, bool>() { { new Vector2(1, 2), false } });//Holds each pawn 
                hasMovedData.Add("King", new Dictionary<Vector2, bool>() { { new Vector2(1, 2), false } });//Holds each king 
                hasMovedData.Add("Rook", new Dictionary<Vector2, bool>() { { new Vector2(1, 2), false } });//Holds each rook 

                break;
            case Options.GameMode.RandomPieces:
                break;
            case Options.GameMode.RandomSetup:
                break;
        }
    }
}
