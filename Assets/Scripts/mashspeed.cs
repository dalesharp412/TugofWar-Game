using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mashspeed : MonoBehaviour
{
    private Text display;
    private float start, ent, time = .5000f, settime = .49f, speed = 0.00f;
    public int count = 0;
    private bool first, second;
    public GameObject part;
    public ParticleSystem party;
    // Start is called before the first frame update
    void Start()
    {
        display = GetComponent<Text>();
        display.text = "0";
        first = true;
        party = part.GetComponent<ParticleSystem>();
        party.Stop();
        //party.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        start = 0;
        if(Input.GetKeyDown(KeyCode.F)  || Input.GetKeyDown(KeyCode.J))
        {
            count++;
        }

 
        if (time > 0)
        {
            time -= (Time.deltaTime);
        }

        if (time <= 0)
        {
            time = settime;
            speed = (count / settime) + (speed * Random.Range(0, .2f));
            Debug.Log(speed);
            
            display.text = speed.ToString("F2");
            count = 0;
  

        }
        
        if(speed >= 12f)
        {
            party.Play();
        }
        else
        {
            party.Stop();
        }
        
       
    }
}
