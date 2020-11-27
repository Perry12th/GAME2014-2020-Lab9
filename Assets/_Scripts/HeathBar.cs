using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class HeathBar : MonoBehaviour
{
    public Transform bar;
    public int value;
    public int maxValue;
    public Transform character;
    
    // Start is called before the first frame update
    void Start()
    {
        value = 100;
        maxValue = 100;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = character.position + new Vector3(-0.40f, 0.8f, 0.0f);
    }

    public void SetValue(int newValue)
    {
        value = newValue;
        bar.localScale = new Vector3((float)((double)value / (double)maxValue), 1.0f, 1.0f);
        if(bar.localScale.x < 0)
        {
            bar.localScale = new Vector3(0.0f, 1.0f, 1.0f);
        }
    }

}
