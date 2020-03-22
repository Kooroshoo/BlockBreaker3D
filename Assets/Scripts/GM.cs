using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GM : MonoBehaviour
{
    public int lives = 3;
    public static int bricks = 0;
    public static int score = 0;
    public static int levelNumber = 0;
    public Text livesText;
    public Text scoreText;
    public GameObject gameover;
    public GameObject youWon;
    public GameObject paddle;
    public GameObject deathParticles;
    public static GM instance = null;
    public Vector3 paddlePos = new Vector3(0, 0, 0);

    

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (true)
        {
            Destroy(gameObject);
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        Debug.Log(bricks);
    }

    
    void CheckGameOver()
    {
        if (bricks<1)
        {
            youWon.SetActive(true);
            levelNumber++;
            Application.LoadLevel(levelNumber);
            
        }
        if (lives<1)
        {
            gameover.SetActive(true);
            Time.timeScale = .25f;
            

        } 
    }


    public void LoseLife()
    {
        lives--;
        livesText.text = "Lives: " + lives;
        CheckGameOver();
        Instantiate(paddle, paddlePos, Quaternion.identity);
        Instantiate(deathParticles, paddle.transform.position, Quaternion.identity);
    }

    

    public void DestroyBrick()
    {
        bricks--;
        score++;
        scoreText.text = "Score: " + score; 
        CheckGameOver();
    }
}
