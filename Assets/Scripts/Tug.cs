using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tug : MonoBehaviour
{
    // Start is called before the first frame update
    public bool side = true, start = false;
    public float tugged = 0;
    public float realscore;
    public GameObject left, right, barob;
    public Image bar;
    public GameObject part;
    public ParticleSystem party;
    public AudioSource aud;
    private int strength;
    void Start()
    {
        left.SetActive(true);
        right.SetActive(false);
        bar = barob.GetComponent<Image>();
        bar.fillAmount = 0;
        strength = 3;
        party = part.GetComponent<ParticleSystem>();
        party.Stop();
    }

    // Update is called once per frame
    void Update()
    {


        aud.pitch = Random.Range(.1f, 3f);
        if (Input.GetKeyUp(KeyCode.F)&& side)
        {
            tugged += strength;
            //Debug.Log(tugged);
            side = false;
            left.SetActive(false);
            right.SetActive(true);
            if(!start)
            {
                start = true;
            }
            aud.Play();

        }
        else if(Input.GetKeyDown(KeyCode.J)&& !side)
        {
            tugged += strength;
            //Debug.Log(tugged);
            side = true;
            right.SetActive(false);
            left.SetActive(true);
            aud.Play();

        }
        else if (!Input.GetKeyDown(KeyCode.J)&&!Input.GetKeyUp(KeyCode.F)&&start)
        {
            //tugged-= .02f;
            if (tugged > 0)
            {
                tugged -= (15f * Time.deltaTime);
                
            }
        }
        realscore = tugged / 150;
        bar.fillAmount = (realscore);
       // Debug.Log(bar.fillAmount);
        if(bar.fillAmount == 1)
        {
            SceneManager.LoadScene("Game 1");
        }
    }
}
