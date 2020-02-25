using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationcontroller : MonoBehaviour
{
    public Camera camerah;
    public void Update()
    {
        RaycastHit hit;
        Ray ray = camerah.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetMouseButtonUp(0))
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("peepeepoopoo");
        }
    }

    void OnMouseDown()
    {
        
    }
}
