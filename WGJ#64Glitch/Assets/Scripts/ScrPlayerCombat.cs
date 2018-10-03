using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrPlayerCombat : MonoBehaviour {

    [SerializeField]
    private GameObject bomb;

    private GameObject currentObject;    

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            GameObject instanceBomb = Instantiate(bomb);
            instanceBomb.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.2f, gameObject.transform.position.z);
        }
	}
}
