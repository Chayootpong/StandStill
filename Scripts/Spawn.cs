using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    float timer, trigger = 1.5f;
    public GameObject[] enemy;

	// Use this for initialization
	void Start () {

        Invoke("CreateEnermy", trigger); //เรียกใช้ Function โดย Delay เวลา

    }
	
	// Update is called once per frame
	void Update () {

        timer = (int)Time.timeSinceLevelLoad; //จับเวลา

    }

    public void CreateEnermy()
    {

        if (timer > 180) Forward.addspeed = 2f;
        else if (timer > 150) trigger = Random.Range(0.2f, 0.35f);
        else if (timer > 120) trigger = Random.Range(0.35f, 0.5f); Collide.adddmg = 3;

        if (timer > 90)
        {
            if (Random.Range(0, 5) == 0)
            {
                Instantiate(enemy[2], new Vector3(-Random.Range(15, 20), -2.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[2].GetComponent<Forward>().isMoveLeft = true;
            }
            else if (Random.Range(0, 5) == 1)
            {
                Instantiate(enemy[2], new Vector3(Random.Range(15, 20), -2.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[2].GetComponent<Forward>().isMoveLeft = false;
            }

            if (Random.Range(0, 3) == 0)
            {
                Instantiate(enemy[1], new Vector3(-Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[1].GetComponent<Forward>().isMoveLeft = true;
            }
            else if (Random.Range(0, 3) == 1)
            {
                Instantiate(enemy[1], new Vector3(Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[1].GetComponent<Forward>().isMoveLeft = false;
            }

            Instantiate(enemy[0], new Vector3(-Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = true;

            Instantiate(enemy[0], new Vector3(Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = false;

            trigger = Random.Range(0.5f, 0.75f); Forward.addspeed = 1.5f; Collide.adddmg = 2;
        }
        else if (timer > 60)
        {
            if (Random.Range(0, 4) == 0)
            {
                Instantiate(enemy[1], new Vector3(-Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[1].GetComponent<Forward>().isMoveLeft = true;
            }
            else if (Random.Range(0, 4) == 1)
            {
                Instantiate(enemy[1], new Vector3(Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[1].GetComponent<Forward>().isMoveLeft = false;
            }

            Instantiate(enemy[0], new Vector3(-Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = true;

            Instantiate(enemy[0], new Vector3(Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = false;

            trigger = Random.Range(0.75f, 1f); Forward.addspeed = 1f; Collide.adddmg = 1;
        }
        else if (timer > 30)
        {
            if(Random.Range(0, 5) == 0)
            {
                 Instantiate(enemy[1], new Vector3(-Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                 enemy[1].GetComponent<Forward>().isMoveLeft = true;                                   
            }
            else if(Random.Range(0, 5) == 1)
            {
                Instantiate(enemy[1], new Vector3(Random.Range(15, 20), -3.35f, 0), Quaternion.Euler(0, 0, 0));
                enemy[1].GetComponent<Forward>().isMoveLeft = false;
            }

            Instantiate(enemy[0], new Vector3(-Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = true;

            Instantiate(enemy[0], new Vector3(Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = false;

            trigger = Random.Range(1f, 1.25f); Forward.addspeed = 0.5f;
        }
        else
        {
            Instantiate(enemy[0], new Vector3(-Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = true;

            Instantiate(enemy[0], new Vector3(Random.Range(15, 20), -3, 0), Quaternion.Euler(0, 0, 0));
            enemy[0].GetComponent<Forward>().isMoveLeft = false;

            trigger = 1.25f;
        }

        Invoke("CreateEnermy", trigger);
    }

}
