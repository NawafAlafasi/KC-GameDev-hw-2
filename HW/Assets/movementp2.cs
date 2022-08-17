using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementp2 : MonoBehaviour
{

    Rigidbody2D RB;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.UpArrow))
        {
            RB.velocity = new Vector2(0, speed);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            RB.velocity = new Vector2(0, -speed);
        }
        else
        {
            RB.velocity = new Vector2 (0, 0);
        }

    }
}