using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandSetActive : MonoBehaviour {

    public GameObject[] obj;
    public float rate;
    public bool isInvoke = true;

	// Use this for initialization
	void Awake () {

        if(isInvoke) Invoke("Spawn", rate);
        else { Spawn(); }

    }
	
	// Update is called once per frame
	void Update () {    

    }

    public void Spawn()
    {
        obj[Random.Range(0, obj.Length)].SetActive(true);
        if (isInvoke) Invoke("Spawn", rate);
    }
}
