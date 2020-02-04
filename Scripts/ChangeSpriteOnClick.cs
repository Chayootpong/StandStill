using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpriteOnClick : MonoBehaviour {

    public Sprite[] costume;
    public SpriteRenderer hero;
    int random = 0, get = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {           
            while(get == random)
            {
                random = Random.Range(0, costume.Length);
            }

            get = random;
            hero.sprite = costume[random];
        }
		
	}
}
