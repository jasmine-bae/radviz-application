using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamvNeu : MonoBehaviour
{
    public GameObject gam;
    public GameObject neu;
    public Button apply;
    public Toggle gamToggle;
    public Toggle neuToggle;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = apply.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        gam.transform.gameObject.SetActive(gamToggle.isOn);
        neu.transform.gameObject.SetActive(neuToggle.isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
