using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionHandler : MonoBehaviour
{

    public Material startColor;
    public Material mouseOverColor;
    //bool mouseOver = false;

    void OnMouseEnter()
	{
        //Debug.Log("entered");
        //mouseOver = true;
        GetComponent<Renderer>().material = mouseOverColor;
	}

    void OnMouseExit()
	{
        //mouseOver = false;
        GetComponent<Renderer>().material = startColor;
	}

}
