using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D bgCollider;
    private float bgHoizontalLength;
    // Start is called before the first frame update
    void Awake()
    {
        bgCollider = GetComponent<BoxCollider2D>();
        bgHoizontalLength = bgCollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -bgHoizontalLength)
        {
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        Vector2 bgOffset = new Vector2(bgHoizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + bgOffset;

    }
}
