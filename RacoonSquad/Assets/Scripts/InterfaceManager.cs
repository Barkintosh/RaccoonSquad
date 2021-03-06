﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    public static InterfaceManager instance;
    public GameObject lobbyPrefab;
    public Slider completionSlider;

    void Awake()
    {
        instance = this;
    }

    public void CreateLobby()
    {
        Instantiate(lobbyPrefab, transform);
    }

    private void Update()
    {
        if (!GameManager.instance.IsInLobby()) {
            completionSlider.value = (float)GameManager.instance.level.GetScore() / GameManager.instance.level.GetGoldTier();
        }
    }
}
