using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject paddle;
    public GameObject paddleClone;
    public GameObject ball;
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball");
    }
    void OnTriggerEnter(Collider col )
    {
        if (col.tag == "Ball")
        {
            paddle = GameObject.Find("Paddle");
            paddleClone = GameObject.Find("Paddle(Clone)");
            Destroy(paddle);
            Destroy(paddleClone);
            Destroy(ball);
            GM.instance.LoseLife();
        }
        

    }

    void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
    }
}
