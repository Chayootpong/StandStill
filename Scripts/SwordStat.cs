using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SwordStat : MonoBehaviour {

    public void LoadByIndex(int sceneIndex)
    {
        HeroStats.heroType = 1;
        //SceneManager.LoadScene(sceneIndex);
    }
}
