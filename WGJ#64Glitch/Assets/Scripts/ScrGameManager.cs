using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrGameManager : MonoBehaviour {

    [SerializeField]
    private GameObject panelTutoMoves;

    private void SetResolutionsSettings()
    {
        Screen.SetResolution(800, 600, false);
    }

    private void Awake()
    {
        SetResolutionsSettings();
    }

    // Use this for initialization
    void Start () {

        SetResolutionsSettings();

        LaunchTutorial();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void LaunchTutorial()
    {
        ScrTutorial scrTuto = gameObject.AddComponent<ScrTutorial>();
        scrTuto.SetPanelTutoMoves(panelTutoMoves);
    }

}
