using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBox : MonoBehaviour {

    public AudioSource au;
    public AudioClip[] music;
    int checkswap = 0, swap = 0;

	// Use this for initialization
	void Start () {

        au.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if (HeroStats.hp > HeroStats.Stat[HeroStats.heroType - 1, 1] / 5) swap = 0;
        else swap = 1;

        if (checkswap != swap)
        {
            checkswap = swap;
            au.Stop();
            if (!au.isPlaying) au.PlayOneShot(music[swap]);
        }

    }
}
