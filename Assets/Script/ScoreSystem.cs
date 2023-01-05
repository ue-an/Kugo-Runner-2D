using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public int coins = 0;
    public TMP_Text scoretext;
    public TMP_Text coinScoreText;
    //public double timeSinceStarted;
    float addToZeroFromHero;
    float newInitHeroPosition;

    // Start is called before the first frame update
    void Start()
    {
        addToZeroFromHero = 0 - GameObject.Find("Hero").GetComponent<Transform>().position.x; //6.988527
        newInitHeroPosition = (GameObject.Find("Hero").GetComponent<Transform>().position.x + addToZeroFromHero);
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject .FindGameObjectWithTag ("Player").GetComponent<PlayerMovement >().isGameOver )
        {
            if(PlayerPrefs .GetInt ("HighScore") < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
                Debug.Log("New High Score is " + score);
            }
        }
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isGameOver == false)
        {

            //float round = MathF.Round(GameObject.Find("Hero").GetComponent<Transform>().position.x);
            double newHeroPosition = newInitHeroPosition+0.001;
            float calcScore = MathF.Round((float)newHeroPosition) - (float)Math.Round(newHeroPosition / 1.5);
            scoretext.text = calcScore.ToString();


            //int decimalPlaces = 2;
            //double rounded = Math.Round(Convert.ToDouble(Time.deltaTime), decimalPlaces);
            //timeSinceStarted += rounded;
            //if (timeSinceStarted < 10)
            //{
            //    coinScoreText.text = "" + timeSinceStarted;
            //}
            //else if (timeSinceStarted > 11 && timeSinceStarted < 25)
            //{
            //    coinScoreText.text = "" + (timeSinceStarted+3);
            //}
            //else if (timeSinceStarted > 26)
            //{
            //    coinScoreText.text = "" + (timeSinceStarted + 6);
            //}
            Debug.Log("playing");
        }
    }
     
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            score = score + 1;
            scoretext.text = "" + score;

        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            coinScoreText.text = "" + coins;
        }
    }
}
