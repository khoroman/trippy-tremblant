using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickLogger : MonoBehaviour
{

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicked");
        }
    }
}
