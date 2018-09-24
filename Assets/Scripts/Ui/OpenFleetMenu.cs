using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenFleetMenu : MonoBehaviour {

    public GameObject FleetMenu;
    public GameObject MainCamera;

    public void InstatiateMenu()
    {
        FleetMenu.transform.position = new Vector3(478, 170.5f, 0);
        MainCamera.GetComponent<CameraScroll>().SetCameraMovement(false);
        //this.gameObject.GetComponent<Button>().interactable = false;
    }
}
