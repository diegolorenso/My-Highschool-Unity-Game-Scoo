﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private bool gameStarted;

    public void loadGame()
    { 

    SceneManager.LoadScene("SampleScene");
         
    }
}
