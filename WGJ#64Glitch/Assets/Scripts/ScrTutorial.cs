using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrTutorial : MonoBehaviour {

    private GameObject canvas;

    private GameObject panelTutoMoves;
    public void SetPanelTutoMoves(GameObject panel) { panelTutoMoves = panel; }

    private GameObject instancePanelTutoMoves;

    private string zValue, zValueRed, zValueGreen;
    private string qValue, qValueRed, qValueGreen;
    private string sValue, sValueRed, sValueGreen;
    private string dValue, dValueRed, dValueGreen;

    private Text txtTutoMoves;

    private bool isItTutoMoves;

	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Canvas");

        instancePanelTutoMoves = Instantiate(panelTutoMoves, canvas.transform);

        zValueRed = "<color=#ff0000ff>Z</color>";
        qValueRed = "<color=#ff0000ff>Q</color>";
        sValueRed = "<color=#ff0000ff>S</color>";
        dValueRed = "<color=#ff0000ff>D</color>";

        zValueGreen = "<color=#008000ff>Z</color>";
        qValueGreen = "<color=#008000ff>Q</color>";
        sValueGreen = "<color=#008000ff>S</color>";
        dValueGreen = "<color=#008000ff>D</color>";

        zValue = zValueRed;
        qValue = qValueRed;
        sValue = sValueRed;
        dValue = dValueRed;

        txtTutoMoves = instancePanelTutoMoves.GetComponentInChildren<Text>();
        txtTutoMoves.text = "Push "+ zValue + " " + qValue + " " + sValue + " " + dValue + " to move Up Left Down and Right";

        isItTutoMoves = true;
    }
	
	// Update is called once per frame
	void Update () {

        if (isItTutoMoves == true && Input.GetKey("z"))
        {
            zValue = zValueGreen;
        }
        else if (isItTutoMoves == true && Input.GetKey("q"))
        {
            qValue = qValueGreen;
        }
        else if (isItTutoMoves == true && Input.GetKey("s"))
        {
            sValue = sValueGreen;
        }
        else if (isItTutoMoves == true && Input.GetKey("d"))
        {
            dValue = dValueGreen;
        }

        if (isItTutoMoves == true) {
            txtTutoMoves.text = "Push " + zValue + " " + qValue + " " + sValue + " " + dValue + " to move Up Left Down and Right";
        }

        if (zValue == zValueGreen && qValue == qValueGreen && sValue == sValueGreen && dValue == dValueGreen)
        {
            isItTutoMoves = false;
            Invoke("DestroyPanelTutoMoves", 2);
        }
    }
    
    private void DestroyPanelTutoMoves()
    {
        Destroy(instancePanelTutoMoves);
    }

}
