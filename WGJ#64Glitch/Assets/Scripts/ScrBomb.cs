using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrBomb : MonoBehaviour {

    private Animator bombAnimator;

    private float bombTimer;

	// Use this for initialization
	void Start () {
        bombAnimator = gameObject.GetComponent<Animator>();

        bombTimer = 0;
    }
	
	// Update is called once per frame
	void Update () {
        bombTimer = bombTimer + Time.deltaTime;

        bombAnimator.SetFloat("bombTimer", bombTimer);

        if (bombTimer >= 4)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Door")
        {            
            ScrDoor scrDoor = coll.gameObject.GetComponent<ScrDoor>();
            
            scrDoor.SetCollidedBomb(gameObject);
            scrDoor.SetDidABombCollide(true);
        }
    }

}
