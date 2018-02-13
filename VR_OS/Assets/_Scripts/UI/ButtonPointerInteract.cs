using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//generic button class to handle VRTK pointer interaction
public class ButtonPointerInteract : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GetComponent<VRTK_DestinationMarker>() == null)
        {
            VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerPointerEvents_ListenerExample", "VRTK_DestinationMarker", "the Controller Alias"));
            return;
        }

        //Setup controller event listeners - need to listen for selection button pressed, UI pointer element enter and UI pointer element released


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
