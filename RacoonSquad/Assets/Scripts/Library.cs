﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    public static Library instance;

    [Header("Scenes")]
    public string lobbyScene;
    public string winScene;
    public List<string> levels;

    [Header("Prefabs")]
    public GameObject racoonPrefab;
    public GameObject humanPrefab;
    public GameObject gameOverPrefab;
    public GameObject winPrefab;
    public GameObject displayerPrefab;

    [Header("Particles")]
    public GameObject sweatParticle;
    public GameObject hitFX;
    public List<Color> playersColors;

    [Header("Materials")]
    public Material boardMaterial;

    [Header("Sounds")]
    public List<SoundPlayer.Sound> sounds;

    [Header("Props")]
    public List<GameObject> props;

    [Header("Cosmetics")]
    public List<GameObject> cosmetics;
	
    [Header("Meshs")]
    public Mesh primitiveQuadMesh;

    [Header("Colors")]
    public Color[] tierColors;

    void Awake()
    {
        instance = this;
    }
}
