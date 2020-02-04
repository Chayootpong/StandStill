using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAsteroid : MonoBehaviour {

    public GameObject asteroid;
    public float rate = 0;

	// Use this for initialization
	void Start () {

        Invoke("CreateAsteroid", rate);

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CreateAsteroid()
    {
        float random = Random.Range(0.25f, 0.45f);
        asteroid.transform.localScale = new Vector3(random, random, random);
        Instantiate(asteroid, new Vector3(Random.Range(-10, 20), 6, 0), Quaternion.Euler(0, 0, 45));
        Invoke("CreateAsteroid", rate);
    }

    void OnDisable()
    {
        CancelInvoke("CreateAsteroid");
    }
}
