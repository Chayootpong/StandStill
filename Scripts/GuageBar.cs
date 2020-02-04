using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuageBar : MonoBehaviour {

    public int guageType = 1;

    public Image bar;
    float maxGuage, nowGuage, calc_guage;

    // Use this for initialization
    void Start () {

        if(guageType == 1) maxGuage = HeroStats.Stat[HeroStats.heroType - 1, 1];
        else if(guageType == 2) maxGuage = HeroStats.Stat[HeroStats.heroType - 1, 2];
    }
	
	// Update is called once per frame
	void Update () {

        if (guageType == 1) nowGuage = HeroStats.hp;
        else if (guageType == 2) nowGuage = HeroStats.guage;
        calc_guage = nowGuage / maxGuage;
        bar.fillAmount = Mathf.Lerp(bar.fillAmount, calc_guage, Time.deltaTime * 5);
    }
}
