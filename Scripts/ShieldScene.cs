﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShieldScene : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        HeroStats.heroType = 3;
        SceneManager.LoadScene(1);
    }
}
