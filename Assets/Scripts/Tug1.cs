using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tug1 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool side = true, start = false;
    public float tugged = 0;
    public float realscore;
    public GameObject left, right, barob;
    public Image bar;
    private int strength;
    public AudioSource aud;
    void Start()
    {
        left.SetActive(true);
        right.SetActive(false);
        bar = barob.GetComponent<Image>();
        bar.fillAmount = 0;
        strength = 3;
    }

    // Update is called once per frame
    void Update()
    {
        aud.pitch = Random.Range(0f, 3f);
        if(Input.GetKeyUp(KeyCode.F)&& side)
        {
            tugged += strength;
            Debug.Log(tugged);
            side = false;
            left.SetActive(false);
            right.SetActive(true);
            if(!start)
            {
                start = true;
            }
            aud.Play();
        }else if(Input.GetKeyDown(KeyCode.J)&& !side)
        {
            tugged += strength;
            Debug.Log(tugged);
            side = true;
            right.SetActive(false);
            left.SetActive(true);
            aud.Play();
        }
        else if (!Input.GetKeyDown(KeyCode.J)&&!Input.GetKeyUp(KeyCode.F)&&start)
        {
            if (tugged > 0)
            {
                tugged -= (25f * Time.deltaTime);
            }
        }
        realscore = tugged / 200;
        bar.fillAmount = (realscore);
        Debug.Log(bar.fillAmount);
        if(bar.fillAmount == 1)
        {
            SceneManager.LoadScene("Game 2");
        }
    }
}
