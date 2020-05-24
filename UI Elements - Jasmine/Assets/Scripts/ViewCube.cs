using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCube : MonoBehaviour
{
    public GameObject viewCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                switch (hit.transform.name)
                {
                    case "Cube222":
                        viewCube.transform.eulerAngles = new Vector3(0, 0, 0);
                        break;
                    case "Cube202":
                        viewCube.transform.eulerAngles = new Vector3(0, -90, 0);
                        break;
                    default:
                        break;
                }
                
                if (hit.transform.name == "MyObjectName"){
                    Debug.Log("My object is clicked by mouse");
                }
            }
        }

    }
}
