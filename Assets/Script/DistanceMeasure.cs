using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DistanceMeasure : MonoBehaviour
{
    // Reference to checkpoint position
    [SerializeField]
    private Transform checkpoint;

    // Reference to UI text that shows the distance value
    [SerializeField]
    public TMP_Text distanceText;

    [SerializeField]
    private GameObject heroPosition;

    // Calculated distance value
    private float distance;
    float addToZeroFromHero;
    float newInitHeroPosition;

    private void Start()
    {
        addToZeroFromHero = 0 - heroPosition.transform.position.x; //6.988527
        newInitHeroPosition = (heroPosition.transform.position.x + addToZeroFromHero);
    }

    // Update is called once per frame
    private void Update()
    {
        float initPos = 0-checkpoint.transform.position.x; //11.03
        float removeNegative = checkpoint.transform.position.x + initPos; //0
        float newHeroPosition = newInitHeroPosition++;
        if (!GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isGameOver)
        {
            // Calculate distance value by X axis
            distance = (removeNegative + newHeroPosition);
            Debug.Log(newHeroPosition);

            // Display distance value via UI text
            distanceText.text = distance.ToString("F1") + " meters";

        }

    }
}
