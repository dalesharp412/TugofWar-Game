using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour
{
    public Image bar;
    int tugpower;
    
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.GetComponent<Image>();
        bar.fillAmount = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        bar.fillAmount += .01f;
    }
    void GetCurrentFill()
    {

    }
}
