using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ball : MonoBehaviour
{

    public Rigidbody2D rg;
    public float speed;
    private int score, score2;
    public TextMeshProUGUI textR, textL;
    int inc = 1;

    // Start is called before the first frame update
    void Start()
    {
        lanunch();
    }
    void lanunch()
    {
        transform.position = Vector2.zero;
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-0.3f, 0.3f);
        rg.velocity = new Vector2(x * speed, y * speed);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "link 2")
        {
            score++;
            textR.text = score.ToString();
            lanunch();
        }
        else if (collision.gameObject.tag == "link 1")
        {
            score2++;
            textL.text = score2.ToString();
            lanunch();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }

}