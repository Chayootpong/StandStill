using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpellStat : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        HeroStats.heroType = 2;
        //SceneManager.LoadScene(sceneIndex);
    }
}
