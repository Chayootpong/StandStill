using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forward : MonoBehaviour {

    public bool isMoveLeft, isStay;
    public int speed = 5;
    public float duration;
    public static float addspeed = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (isStay) StartCoroutine(StopMove(duration));
        transform.Translate(Vector2.left * Time.deltaTime * (speed + addspeed)); //อยากได้ความเร็วเพิ่มขึ้นให้เปลี่ยนค่าคงที่
        if (!isMoveLeft) { transform.Rotate(0, 180, 0); isMoveLeft = true; }

    }

    IEnumerator StopMove(float duration)
    {
        yield return new WaitForSeconds(duration);
        GetComponent<Forward>().enabled = false;
    }
}
