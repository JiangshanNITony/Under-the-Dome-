using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMove : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    private float speedR;
    private bool dri = true;
    void Start()
    {
        speed = 9f; //initialize
        speedR = 10000f;
    }

    // Update is called once per frame
    void Flip()
    {
        dri = !dri;
        Vector2 ren = transform.localScale;
        ren.x *= -1;
        transform.localScale = ren;
    }
    void Update()
    {
        if (dri)
        {
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                transform.Translate(Vector2.right * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                Flip();
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);
                Flip();
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                Flip();
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                transform.Translate(Vector2.left * speed * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * speed * Time.deltaTime);

            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * speed * Time.deltaTime);
                Flip();
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
            }
        }
    }
}