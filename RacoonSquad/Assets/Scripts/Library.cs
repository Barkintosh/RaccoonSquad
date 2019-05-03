﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Library : MonoBehaviour
{
    public static Library instance;

    [Header("Scenes")]
    public Object lobbyScene;
    public List<Object> levels;

    [Header("Prefabs")]
    public GameObject racoonPrefab;

    [Header("Particles")]
    public GameObject sweatParticle;
    public GameObject hitFX;
    public List<Color> playersColors;

    [Header("Materials")]
    public Material boardMaterial;

    [Header("Sounds")]
    public List<SoundPlayer.Sound> sounds;

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
