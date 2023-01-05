using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBG : MonoBehaviour
{
    private Rigidbody2D rb2d;
    //from scrolling script
    //public GameObject camera;
    //public float parallaxEffect;
    //private float width, positionX;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(-9f, 0);
        //from scrolling script
        //width = GetComponent<SpriteRenderer>().bounds.size.x;
        //positionX = transform.position.x;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
