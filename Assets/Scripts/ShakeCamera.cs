using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{

    public float power = 0.2f;
    public float duration = 0.1f;
    public Transform camerat;
    public float slowDownAmount = 1.0f;
    public bool shouldShake = false;

    Vector3 StartPosition;
    float initialDuration;

    // Start is called before the first frame update
    void Start()
    {
        camerat = Camera.main.transform;
        StartPosition = camerat.localPosition;
        initialDuration = duration;

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldShake)
        {
            if (duration > 0)
            {
                camerat.localPosition = StartPosition + Random.insideUnitSphere * power;
                duration -= Time.deltaTime * slowDownAmount;
            }
            else
            {
                shouldShake = false;
                duration = initialDuration;
                camerat.localPosition = StartPosition;
            }
        }
    }


    

    

        
}
