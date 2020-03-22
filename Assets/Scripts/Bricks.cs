using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour
{

    public GameObject brickParticle;
    public int brickLives=1;
    public AudioSource audioSource;

    public Material[] material;

    private int randomNumber;
    public GameObject[] powerUps;

    public Explosion explosion;
    



    void Start()
    {
        explosion = GetComponent<Explosion>();
        GM.bricks++;
        
        
    }
    void OnCollisionEnter(Collision other)
    {
        audioSource.Play();
        Instantiate(brickParticle, transform.position, Quaternion.identity);
        
        if (brickLives<= 1)
        {
            GM.instance.DestroyBrick();
            explosion.explode();
            Destroy(gameObject);
            randomNumber = Random.Range(1, 4);
            if (randomNumber == 1)
            {
                Instantiate(powerUps[Random.Range(0,7)], transform.position, Quaternion.identity);
            }

        }
        else if (brickLives > 1)
        {
            brickLives--;
            GetComponent<Renderer>().material = material[brickLives-1];
        }
        
    }
}
