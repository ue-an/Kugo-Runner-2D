using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coin;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("GenerateCoins");
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().isGameOver)
        {
            StopCoroutine("GenerateCoins");
        }
    }

    private void GenerateCoin()
    {
        int random = Random.Range(1, 3);
        if (random == 1)
        {
            Instantiate(coin, new Vector3(transform.position.x + 2, 0f,0), (Quaternion.identity));
        }
        else if (random == 2)
        {
            Instantiate(coin, new Vector3(transform.position.x + 2, 1f,0), (Quaternion.identity));
        }
        else if (random == 3)
        {
            Instantiate(coin, new Vector3(transform.position.x + 2, 2f,0), (Quaternion.identity));
        }
    }

    IEnumerator GenerateCoins()
    {
        while (true)
        {
            int random = Random.Range(1, 5);
            GenerateCoin();
            yield return new WaitForSeconds((float)random);
        }
    }
}
