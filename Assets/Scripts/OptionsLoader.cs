using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsLoader : MonoBehaviour
{
    private OptionsLoader ole = null;
    public Options.players playerType;
    public Options.GameMode gameMode;
    public GameObject startPanel;
    public GameObject modePanel;
    public GameObject playerPanel;

    private void Awake()
    {
        if (ole == null)
        {
            ole = this;
            DontDestroyOnLoad(this);
        }
    }

    public void StartButton()
    {
        startPanel.SetActive(false);
        modePanel.SetActive(true);
    }
    public void SelectGameMode(Options.GameMode g)
    {
        gameMode = g;
        modePanel.SetActive(false);
        playerPanel.SetActive(true);
    }
    public void SelectPlayerType(Options.players p)
    {
        playerType = p;
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}


public class Options : MonoBehaviour
{
    public enum players
    {
        pvp,
        dumbAi,
        smartAi
    }
    public enum GameMode
    {
        Normal,
        RandomSetup,
        RandomPieces
    }
}