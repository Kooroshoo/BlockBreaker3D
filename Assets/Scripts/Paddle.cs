using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float paddleSpeed = 1;
    private Vector3 playerPos = new Vector3(0, -13f, 0);
    public ShakeCamera shakeCamera;

    void Start()
    {
        shakeCamera = GameObject.FindObjectOfType<ShakeCamera>();
    }

    
    

    // Update is called once per frame
    void Update()
    {
        float xPox = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);
        playerPos = new Vector3(Mathf.Clamp(xPox, -13.3f, 15), -13f, 0);
        transform.position = playerPos;
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Ball")
        {
            shakeCamera.shouldShake = true;
        }
    }

    
}
