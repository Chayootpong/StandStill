using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroStats : MonoBehaviour {

    public static int heroType = 1, hp = 1000, guage = 0, def = 0;
    public static int[,] Stat = { { 95, 25, 96, 25, 5 } , { 100, 15, 120, 30, 16}  , { 90, 40, 108, 0, 7} };

    public GameObject defense;

	// Use this for initialization
	void Start () {

        hp = Stat[heroType - 1, 1];
        guage = 0;
        def = 0;

	}
	
	// Update is called once per frame
	void Update () {

        if (def > 0) defense.SetActive(true);
        else { defense.SetActive(false); def = 0; }
        if (hp > Stat[heroType - 1, 1]) hp = Stat[heroType - 1, 1];
        if (guage > Stat[heroType - 1, 2]) guage = Stat[heroType - 1, 2];

    }
}
