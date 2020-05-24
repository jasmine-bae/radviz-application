using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorTable : MonoBehaviour { 

    public GameObject obj;
    public Button apply;
    public Slider red;
    public Slider green;
    public Slider blue;
    public Slider alpha;
    public Toggle trigger;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = apply.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        //create a new material
        Material materialColored = new Material(Shader.Find("Standard"));
        materialColored.color = new Color(red.value, green.value, blue.value, alpha.value);
        obj.GetComponent<Renderer>().material = materialColored;
        ColorBlock cb = trigger.GetComponent<Toggle>().colors;
        cb.normalColor = materialColored.color;
        trigger.colors = cb;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
