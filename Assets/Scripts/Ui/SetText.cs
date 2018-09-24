using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {

    public void newText(string nt)
    {
        gameObject.GetComponent<Text>().text = nt;
    }
}
