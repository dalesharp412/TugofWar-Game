using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitScript : MonoBehaviour
{

    public void exit()
    {
      
        Application.Quit();
        Debug.Log("Has quit the game.");
    }


}
