using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

    public int type = 1, dmg = 1, mulGuage = 1; //type 1 = atk ของเรา type 2 = atk อีกฝ่าย
    public static int adddmg = 0, combo = 1;
    public bool isFade = false;
    public static bool isEye = false;
    GameObject enm;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter2D(Collider2D col)
    {       
        if (col.gameObject.name == "Hit_Enm_Box" && (type == 1 || type == 3))
        {
            enm = col.gameObject;
            UI.sc += combo;
            combo++;
            HeroStats.guage += 1 * (mulGuage + AddVars.RAG);
            if (enm.GetComponent<OppHP>().enmHP > 0 && type == 1)
            {
                enm.GetComponent<OppHP>().enmHP -= 1;
            }
            else
            {
                Destroy(col.transform.parent.gameObject);
            }
            if(isFade) Destroy(gameObject);

            /*if (isFade) //Ranged Attack
            {
                //if (isEye || (Random.Range(0, 99) > 10 && !isEye))
                //{
                    //UI.sc += combo;
                    //combo++;
                    //HeroStats.guage += 1 * (mulGuage + AddVars.RAG);

                    if (enm.GetComponent<OppHP>().enmHP > 0 && type == 1)
                    {
                        enm.GetComponent<OppHP>().enmHP -= 1;
                        Destroy(gameObject);
                    }
                    else
                    {
                        Destroy(col.transform.parent.gameObject);
                        Destroy(gameObject);
                    }
                //}
                
            }
            else //Melee Attack
            {
                
                if (enm.GetComponent<OppHP>().enmHP > 0 && type == 1) enm.GetComponent<OppHP>().enmHP -= 1;
                else Destroy(col.transform.parent.gameObject);         
            }*/
            
        }

        if (col.gameObject.name == "Hit_Hero_Box" && type == 2)
        {
            if (HeroStats.Stat[HeroStats.heroType - 1, 3] < Random.Range(0, 99))
            {
                if (HeroStats.def > 0) HeroStats.def--;
                else { HeroStats.hp -= dmg + adddmg; combo = 1; }
                HeroStats.guage += 3;
            }
            Destroy(transform.parent.gameObject);
        }
        
    }
}
