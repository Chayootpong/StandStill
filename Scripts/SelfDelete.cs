using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDelete : MonoBehaviour {

    public float interval = 1f;
    public bool isNormal = false;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        StartCoroutine("Delete");
	}

    IEnumerator Delete()
    {
        yield return new WaitForSeconds(interval);
        if(isNormal) gameObject.SetActive(false);
        else Destroy(gameObject);
    }
}
