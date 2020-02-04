using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddVars : MonoBehaviour {

    public int AMG, type = 1;
    public static int RAG = 0;
    public bool isEnable = true;

    bool shift = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

    void OnEnable()
    {
        if (shift && type == 1) { HeroStats.Stat[HeroStats.heroType - 1, 4] /= 2; shift = false; Collide.isEye = true; }
        RAG = AMG;  isEnable = false;
    }

    void OnDisable()
    {
        if (!shift && type == 1) { HeroStats.Stat[HeroStats.heroType - 1, 4] *= 2; shift = true; Collide.isEye = false; }
        RAG = 0;  isEnable = true;
    }
}
