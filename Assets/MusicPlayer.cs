﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour
{



    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }


    void Start()
    {
        Invoke("LoadFirstScene", 3f);
        
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }

}