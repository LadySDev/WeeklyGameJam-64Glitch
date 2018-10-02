using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayerMoves : MonoBehaviour {

    [SerializeField]
    private float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey("z"))
        {
            gameObject.transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }
        else if(Input.GetKey("s"))
        {
            gameObject.transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("q"))
        {
            gameObject.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        else if (Input.GetKey("d"))
        {
            gameObject.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

    }
}
