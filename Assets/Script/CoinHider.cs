using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinHider : MonoBehaviour
{
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (this.GetComponent<Renderer>().enabled == true)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                this.gameObject.SetActive(false);
            }
        }
        //else if (this.GetComponent<Renderer>().enabled == false)
        //{
        //        this.gameObject.SetActive(true);
        //}
    }
}
