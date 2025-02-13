﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Pause : ScreenElement
{
    [SerializeField]
    private GameObject MsgGameOver;
    [SerializeField]
    private GameObject MsgPaused;

    public void Button_RestartPressed()
    {
        UIManager.instance.RestartLevel();

    }

    public void Button_ContinuePressed()
    {
        if (GameManager.instance.GetShipRef().GetComponent<Stats>().IsAlive() )
            UIManager.instance.Resume();
    }

    public void Button_QuitToMenuPressed()
    {
        UIManager.instance.EndLevel();

    }
    public void Button_OptionsPressed()
    {
        UIManager.instance.OptionsButton();
    }
    public void setMessage(bool isPlayerDead)
    {
        if (isPlayerDead)
        {
            MsgGameOver.SetActive(true);
            MsgPaused.SetActive(false);
        }
        else
        {
            MsgGameOver.SetActive(false);
            MsgPaused.SetActive(true);
        }
    }
}