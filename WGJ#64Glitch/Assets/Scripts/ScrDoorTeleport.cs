using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrDoorTeleport : MonoBehaviour {

    [SerializeField]
    private bool upDirection;

    [SerializeField]
    private bool leftDirection;

    [SerializeField]
    private bool rightDirection;

    [SerializeField]
    private bool downDirection;

    [SerializeField]
    private float roomWeight;

    [SerializeField]
    private float roomHeight;

    private GameObject room;

    // Use this for initialization
    void Start () {
        GameObject door = gameObject.transform.parent.gameObject;
        GameObject goDoors = door.transform.parent.gameObject;
        room = goDoors.transform.parent.gameObject;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        print("any coll");
        if (coll.gameObject.tag == "Player")
        {
            print("player coll");
            if (upDirection == true)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, room.transform.position.y + roomHeight, Camera.main.transform.position.z);
            }
            else if (downDirection == true)
            {
                Camera.main.transform.position = new Vector3(Camera.main.transform.position.x, room.transform.position.y - roomHeight, Camera.main.transform.position.z);
            }
            else if (leftDirection == true)
            {
                Camera.main.transform.position =new Vector3(room.transform.position.x - roomWeight, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
            else if (rightDirection == true)
            {
                Camera.main.transform.position = new Vector3(room.transform.position.x + roomWeight, Camera.main.transform.position.y, Camera.main.transform.position.z);
            }
                        
        }
    }

}
