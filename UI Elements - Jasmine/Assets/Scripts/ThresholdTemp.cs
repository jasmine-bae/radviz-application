using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThresholdTemp : MonoBehaviour
{

    public GameObject object0;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    public GameObject object4;
    public GameObject object5;
    public Button apply;
    public Toggle level0;
    public Toggle level1;
    public Toggle level2;
    public Toggle level3;
    public Toggle level4;
    public Toggle level5;


    void Start()
    {
        Button btn = apply.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        object0.transform.gameObject.SetActive(level0.isOn);
        object1.transform.gameObject.SetActive(level1.isOn);
        object2.transform.gameObject.SetActive(level2.isOn);
        object3.transform.gameObject.SetActive(level3.isOn);
        object4.transform.gameObject.SetActive(level4.isOn);
        object5.transform.gameObject.SetActive(level5.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
