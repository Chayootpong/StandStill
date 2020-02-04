using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBTN : MonoBehaviour {

    bool isCheck = true, isTurnLeft = true;
    public GameObject[] swordman, magician, gladiator;
    public GameObject[] subOBJ;
    float interval = 0f;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update() {

        if (isCheck != isTurnLeft) {transform.Rotate(0, 180, 0); isCheck = isTurnLeft; }

        /*if (HeroStats.heroType == 3 && !subOBJ[2].GetComponent<AddVars>().isEnable)
        {
            if (Input.GetKey(KeyCode.LeftArrow)) { gladiator[3].SetActive(true); gladiator[4].SetActive(false); isTurnLeft = true; }
            else if (Input.GetKey(KeyCode.RightArrow)) { gladiator[3].SetActive(false); gladiator[4].SetActive(true); isTurnLeft = false; }
            else { gladiator[3].SetActive(false); gladiator[4].SetActive(false); }
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow)) { isTurnLeft = true; AttackTarget(); }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) { isTurnLeft = false; AttackTarget(); }

        if (Input.GetKeyDown(KeyCode.Z)) Skill_1();
        else if (Input.GetKeyDown(KeyCode.X)) Skill_2();
        else if (Input.GetKeyDown(KeyCode.C)) Skill_3();*/

    }

    public void AttackTarget()
    {
        if(HeroStats.heroType == 1 && Random.Range(0, 99) < HeroStats.Stat[HeroStats.heroType - 1, 0] && Time.time * 100 >= interval)
        {
            SoundManager.PlaySfx((int)SoundManager.SoundEnum.swordAttack);

            interval = Time.time * 100 + HeroStats.Stat[HeroStats.heroType - 1, 4];
            if (isTurnLeft) swordman[0].SetActive(true);
            else swordman[1].SetActive(true);
        }

        else if (HeroStats.heroType == 2 && Random.Range(0, 99) < HeroStats.Stat[HeroStats.heroType - 1, 0] && Time.time * 100 >= interval)
        {
            SoundManager.PlaySfx((int)SoundManager.SoundEnum.wizardAttack);

            interval = Time.time * 100 + HeroStats.Stat[HeroStats.heroType - 1, 4];
            if (isTurnLeft)
            {
                magician[0].GetComponent<Forward>().isMoveLeft = true;
                Instantiate(magician[0], new Vector3(-1, Random.Range(-3.5f, -3f), 0), Quaternion.Euler(0, 0, 0));
            }
            else
            {
                magician[0].GetComponent<Forward>().isMoveLeft = false;
                Instantiate(magician[0], new Vector3(1, Random.Range(-3.5f, -3f), 0), Quaternion.Euler(0, 0, 0));
            }
        }

        if (HeroStats.heroType == 3 && Random.Range(0, 99) < HeroStats.Stat[HeroStats.heroType - 1, 0] && Time.time * 100 >= interval)
        {
            SoundManager.PlaySfx((int)SoundManager.SoundEnum.shieldAttack);

            interval = Time.time * 100 + HeroStats.Stat[HeroStats.heroType - 1, 4];
            if (isTurnLeft) gladiator[0].SetActive(true);
            else gladiator[1].SetActive(true);
        }
    }

    public void Skill_1()
    {
        if (HeroStats.guage > HeroStats.Stat[HeroStats.heroType - 1, 2] * 1 / 3 )
        {
            HeroStats.guage -= HeroStats.Stat[HeroStats.heroType - 1, 2] * 1 / 3;

            if (HeroStats.heroType == 1) //Bladewave
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.swordSpell1);

                if (isTurnLeft)
                {
                    swordman[2].GetComponent<Forward>().isMoveLeft = true;
                    Instantiate(swordman[2], new Vector3(-2, -2.5f, 0), Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    swordman[2].GetComponent<Forward>().isMoveLeft = false;
                    Instantiate(swordman[2], new Vector3(2, -2.5f, 0), Quaternion.Euler(0, 0, 0));
                }

                HeroStats.guage += HeroStats.Stat[HeroStats.heroType - 1, 2] * 1 / 6;
            }

            if (HeroStats.heroType == 2) //Orb;
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.wizardSpell1);

                if (isTurnLeft)
                {
                    magician[1].GetComponent<Forward>().isMoveLeft = true;
                    Instantiate(magician[1], new Vector3(0, -2.5f, 0), Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    magician[1].GetComponent<Forward>().isMoveLeft = false;
                    Instantiate(magician[1], new Vector3(0, -2.5f, 0), Quaternion.Euler(0, 0, 0));
                }
            }

            if (HeroStats.heroType == 3) //Shield;
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.shieldSpell1);

                if (isTurnLeft)
                {
                    gladiator[2].GetComponent<Forward>().isMoveLeft = true;
                    Instantiate(gladiator[2], new Vector3(-2, -3, 0), Quaternion.Euler(0, 0, 0));
                }
                else
                {
                    gladiator[2].GetComponent<Forward>().isMoveLeft = false;
                    Instantiate(gladiator[2], new Vector3(2, -3, 0), Quaternion.Euler(0, 0, 0));
                }
            }

        }
            
    }

    public void Skill_2()
    {
        if (HeroStats.guage > HeroStats.Stat[HeroStats.heroType - 1, 2] * 2 / 3)
        {
            HeroStats.guage -= HeroStats.Stat[HeroStats.heroType - 1, 2] * 2 / 3;

            if (HeroStats.heroType == 1) //Healing
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.swordSpell2);

                HeroStats.hp += 10; swordman[3].SetActive(true);
            }

            if (HeroStats.heroType == 2 && subOBJ[0].GetComponent<AddVars>().isEnable) //Rapid Fire
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.wizardSpell2);

                magician[2].SetActive(true);
            }

            if (HeroStats.heroType == 3) //Defense
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.shieldSpell2);

                HeroStats.def += 4;
            }

        } 

    }

    public void Skill_3()
    {
        if (HeroStats.guage == HeroStats.Stat[HeroStats.heroType - 1, 2])
        {
            HeroStats.guage = 0;

            if(HeroStats.heroType == 1)
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.swordSpell3);

                swordman[4].SetActive(true);
                StartCoroutine(DelayCast(1, 1)); //Dragon's Call
            }

            if (HeroStats.heroType == 2 && subOBJ[1].GetComponent<AddVars>().isEnable) //Lightning
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.wizardSpell3);

                //magician[3].SetActive(true);
                Instantiate(magician[3], new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
            }

            if (HeroStats.heroType == 3 && subOBJ[2].GetComponent<AddVars>().isEnable) //Fury
            {
                SoundManager.PlaySfx((int)SoundManager.SoundEnum.shieldSpell3);

                gladiator[5].SetActive(true);
            }

        }
        
    }

    IEnumerator DelayCast(int type, int time)
    {
        yield return new WaitForSeconds(time);

        if(type == 1) //Swordman Ulti
        {
            if (isTurnLeft)
            {
                swordman[5].GetComponent<Forward>().isMoveLeft = true;
                Instantiate(swordman[5], new Vector3(24, 1.75f, 0), Quaternion.Euler(0, 0, 0));              
            }
            else
            {
                swordman[5].GetComponent<Forward>().isMoveLeft = false;
                Instantiate(swordman[5], new Vector3(-24, 1.75f, 0), Quaternion.Euler(0, 0, 0));               
            }
        }
    }

    public void LeftAttack()
    {
        isTurnLeft = true; AttackTarget();
    }

    public void RightAttack()
    {
        isTurnLeft = false; AttackTarget();
    }
}
