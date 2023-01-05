using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb2d;
    public float  runSpeed;
    private  int jumpCount = 0;
   private bool canJump = true;
    Animator anim;
    public bool isGameOver = false;
    public GameObject GameOverPanel, scoreText;
    public TMP_Text FinalScoreText, HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        StartCoroutine("IncreaseGameSpeed");
    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameOver)
        {
            transform.position = Vector3.right * runSpeed * Time.deltaTime + transform.position;
        }

        

        if (jumpCount == 2)
        {
            canJump = false;
        }

        if(Input .GetKeyDown ("space") && canJump && !isGameOver )
        {
            rb2d.velocity = Vector3.up * 7.5f;
            //rb2d.AddForce(Vector2.up * 50f, ForceMode2D.Impulse);
            anim.SetTrigger("Jump");
            jumpCount += 1 ;
        }
    }

    public void GameOver()
    {
        isGameOver = true;
        anim.SetTrigger("Death");
        StopCoroutine("IncreaseGameSpeed");

        StartCoroutine("ShownGameOverPanel");

        FindObjectOfType<SoundManager>().DeathSound();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumpCount = 0;
            canJump = true;
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }

        if (collision.gameObject.CompareTag("BottomDetector"))
        {
            GameOver();
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
        }
    }

    IEnumerator IncreaseGameSpeed()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            if (runSpeed < 7)
            {
                runSpeed += 0.5f;
            }
            if (runSpeed >= 7 && runSpeed < 16)
            {
                //runSpeed  += 0.2f;
                runSpeed += 1f;
            }
            if (runSpeed >= 16 && runSpeed < 20)
            {
                //runSpeed  += 0.2f;
                runSpeed += 1.5f;
            }
            //if (runSpeed < 480)
            //{
            //    //runSpeed  += 0.2f;
            //    runSpeed += 1f;
            //}

            if (GameObject.Find("GroundSpawner").GetComponent<ObstacleSpawner>().obstacleSpawnInterval > 1)
            {
                GameObject.Find("GroundSpawner").GetComponent<ObstacleSpawner>().obstacleSpawnInterval -= 0.1f;
            }
           
        }

    }

    IEnumerator ShownGameOverPanel()
    {
        yield return new WaitForSeconds(2);
        GameOverPanel.SetActive(true);
        scoreText.SetActive(false);

        FinalScoreText.text = "Score: " + GameObject.Find("ScoreDetector").GetComponent<ScoreSystem>().score;

        HighScoreText.text = "Highscore: " + PlayerPrefs.GetInt("HighScore");

    }

    public void JumpButtom()
    {
        if (canJump && !isGameOver)
        {
            rb2d.velocity = Vector3.up * 7f;
            anim.SetTrigger("Jump");
            jumpCount += 1;
        }
    }
}
