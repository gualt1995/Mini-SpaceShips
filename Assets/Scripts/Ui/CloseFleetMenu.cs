using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseFleetMenu : MonoBehaviour {

    public GameObject MainCamera;

    public void CloseMenu()
    {
        transform.parent.gameObject.transform.position = new Vector3(738,170.5f,0);
        MainCamera.GetComponent<CameraScroll>().SetCameraMovement(true);

    }
}
