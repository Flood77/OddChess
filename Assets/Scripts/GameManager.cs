using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private OptionsLoader ol;
    GameObject PiecePrefab;

    void Start()
    {
        ol = FindObjectOfType<OptionsLoader>();
    }

    void Update()
    {
        
    }

    private void SetupBoard()
    {
        if(ol.gameMode == Options.GameMode.Normal)
        {

        }
    }
}
