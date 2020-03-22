using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    

    public bool BigPaddle;
    public bool BigBall;
    public bool SlowerTime;

    public bool smallPaddle;
    public bool smallBall;
    public bool fasterTime;

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player" && BigPaddle)
        {
            GameObject paddle = GameObject.FindGameObjectWithTag("Player");
            paddle.GetComponent<Transform>().localScale = new Vector3(5, 1, 1);
            GM.score += 5;
            
        }
        else if (col.tag == "Player" && BigBall)
        {
            GameObject ball = GameObject.FindGameObjectWithTag("Ball");
            ball.GetComponent<Transform>().localScale = new Vector3(2, 2, 2);
            GM.score += 5;
        }
        else if (col.tag == "Player" && SlowerTime)
        {
            Time.timeScale = .75f;
            GM.score += 5;
        }
        if (col.tag == "Player" && smallPaddle)
        {
            GameObject paddle = GameObject.FindGameObjectWithTag("Player");
            paddle.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
            GM.score += 5;
        }
        else if (col.tag == "Player" && smallBall)
        {
            GameObject ball = GameObject.FindGameObjectWithTag("Ball");
            ball.GetComponent<Transform>().localScale = new Vector3(.5f, .5f, .5f);
            GM.score += 5;
        }
        else if (col.tag == "Player" && fasterTime)
        {
            Time.timeScale = 1.25f;
            GM.score += 5;
        }


    }
}
