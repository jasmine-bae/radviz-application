using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorVals : MonoBehaviour
{
    Vector3 worldPosition;
    Text txt;

    private void Start()
    {
        txt = gameObject.GetComponent<Text>();
        txt.text = "X: 0.0" + "\n" + "Y: 0.0" + "\n" + "Z: 0.0" + "\n" + "No File Inputed.";
    }
    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitData;

        if (Physics.Raycast(ray, out hitData, 1000))
        {
            worldPosition = hitData.point;
            txt.text = "X: " + worldPosition.x + "\n" + "Y: " + worldPosition.y + "\n" + "Z: " + worldPosition.z + "\n" + hitData.collider.gameObject.name;
        }
     
        
    }
}
