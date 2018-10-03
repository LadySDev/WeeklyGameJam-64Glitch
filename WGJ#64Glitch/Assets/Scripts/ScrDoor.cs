using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrDoor : MonoBehaviour {

    [SerializeField]
    private Sprite openDoor;

    private SpriteRenderer sprRenderer;

    private bool didABombCollide;
    public void SetDidABombCollide(bool didCollide) { didABombCollide = didCollide; }

    private GameObject collidedBomb;
    public void SetCollidedBomb(GameObject bomb) { if (didABombCollide == false) collidedBomb = bomb; }

    private Vector3 posUp;
    private Vector3 posLeft;
    private Vector3 posRight;
    private Vector3 posDown;

    // Use this for initialization
    void Start () {
        sprRenderer = gameObject.GetComponent<SpriteRenderer>();

        didABombCollide = false;

        posUp = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 1, gameObject.transform.position.z);
        posLeft = new Vector3(gameObject.transform.position.x - 1, gameObject.transform.position.y, gameObject.transform.position.z);
        posRight = new Vector3(gameObject.transform.position.x + 1, gameObject.transform.position.y + 1, gameObject.transform.position.z);
        posDown = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z);
       
    }
	
	// Update is called once per frame
	void Update () {

        if (didABombCollide == true && collidedBomb == null)
        {
            OpenDoor();            

            didABombCollide = false;            

        }

	}
           
    public void OpenDoor()
    {
        sprRenderer.sprite = openDoor;

        BoxCollider2D boxColl = gameObject.GetComponent<BoxCollider2D>();
        boxColl.isTrigger = true;

        foreach (Transform child in Resources.FindObjectsOfTypeAll<Transform>())
        {            
            if (child.gameObject.tag == "Door" && (child.gameObject.transform.position == posUp || child.gameObject.transform.position == posLeft || child.gameObject.transform.position == posRight || child.gameObject.transform.position == posDown))
            {
                child.gameObject.GetComponent<ScrDoor>().OpenDoor();
            }
                        
        }
    }

}
