using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class total : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("this is a " + tag + " position:" + transform.position.x + "," + transform.position.y);
    }
}
