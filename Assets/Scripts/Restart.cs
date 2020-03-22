using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    // Start is called before the first frame update
    public void RestartMethod()
    {
        GM.score = 0;

        Time.timeScale = 1;
        Application.LoadLevel("SampleScene");
        
    }
}
