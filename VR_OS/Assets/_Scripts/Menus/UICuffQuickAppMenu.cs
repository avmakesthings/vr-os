using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICuffQuickAppMenu : MonoBehaviour {

    private static bool menuState = false; //menu active or inactive .. can use visibility 
    //reference to the child meshes for layout


	// Use this for initialization
	void Start () {
        //add layout logic 
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //toggle menu visibility
    public void toggleMenu()
    {
        menuState = !menuState;
        this.gameObject.SetActive(menuState);
        print(menuState);
    }


}
