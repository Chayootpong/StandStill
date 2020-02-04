using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

    public static int sc = 0;
    int comboUI = 1;
    bool isEnd = false;

    public Text score, resscore, combo, names;

    public GameObject[] central, potrait, player, ui;
    public GameObject res, wombo, spawnPoint, hero, sb;

    // Use this for initialization
    void Start () {

        InfoSet();
		
	}
	
	// Update is called once per frame
	void Update () {

        ComboCount();
        if(!isEnd) Result();
        score.text = sc.ToString();
	}

    public void InfoSet()
    {
        if (HeroStats.heroType == 1) { potrait[0].SetActive(true); names.text = "Swordman";}
        else if (HeroStats.heroType == 2) { potrait[1].SetActive(true); names.text = "Magician";}
        else if (HeroStats.heroType == 3) { potrait[2].SetActive(true); names.text = "Gladiator";}

        for(int i = 0; i < player.Length; i++)
        {
            if (HeroStats.heroType - 1 != i) { player[i].SetActive(false); ui[i].SetActive(false); }
        }

        sc = 0; comboUI = 1; isEnd = false;
    }

    public void ComboCount()
    {
        if (comboUI != Collide.combo)
        {
            if (comboUI < Collide.combo && Collide.combo >= 2)
            {
                comboUI++; combo.text = " ";
                StartCoroutine("ShiftCombo");
                wombo.SetActive(true);
            }
            else
            {
                comboUI = 1;
                wombo.SetActive(false);
            }
        }
    }

    public void Result()
    {
        if (HeroStats.hp <= 0)
        {
            hero.SetActive(false);
            sb.SetActive(false);
            spawnPoint.GetComponent<Spawn>().enabled = false;
            isEnd = true;
            res.SetActive(true);
            central[0].SetActive(false);
            central[1].SetActive(true);
            resscore.text = sc.ToString();
        }
    }

    IEnumerator ShiftCombo()
    {
        yield return new WaitForSeconds(0);
        combo.text = "x" + comboUI + " Combo";
    }
}
