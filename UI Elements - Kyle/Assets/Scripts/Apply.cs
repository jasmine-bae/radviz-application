using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Apply : MonoBehaviour
{
    public Button apply;
    public InputField transx;
    public InputField transy;
    public InputField transz;
    public InputField rotx;
    public InputField roty;
    public InputField rotz;
    public Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = apply.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        float xt = float.Parse(transx.text.ToString());
        float yt = float.Parse(transy.text.ToString());
        float zt = float.Parse(transz.text.ToString());
        float xr = float.Parse(rotx.text.ToString());
        float yr = float.Parse(roty.text.ToString());
        float zr = float.Parse(rotx.text.ToString());
        cam.transform.position = new Vector3(xt, yt, zt);
        cam.transform.eulerAngles = new Vector3(xr, yr, zr);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
