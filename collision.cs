using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class collision : MonoBehaviour
{
    public GameObject text;
    public GameObject text1;
    // Start is called before the first frame update
    public int TotalTime = 20;
    private bool pd = true;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "little boy")
        {
            text1.GetComponent<Text>().text = "<color=#7444c1>P1 WINS!</color>";
            text1.GetComponent<Text>().transform.position = new Vector2(500, 200);
            text1.GetComponent<Text>().transform.localScale *= 2; 
            Destroy(this.gameObject);
            pd = false;
           
            
        }
    }
    void Start()
    {
        if(pd)
        StartCoroutine(CountDown());

    }
    IEnumerator CountDown()
    {
        if (!pd) yield return text.GetComponent<Text>().text = "<color=#7444c1>P1 WINS!</color>"; 
        while (TotalTime >= 0 && pd)
        {
                text.GetComponent<Text>().text =TotalTime.ToString();
                yield return new WaitForSeconds(1);
                TotalTime--;
            
        }
        text.GetComponent<Text>().text = "<color=#7444c1>P2 WINS!</color>";
        text.GetComponent<Text>().transform.position = new Vector2(290, 80);
        text.GetComponent<Text>().transform.localScale *= 1;
    }

  
   
    void Update()
    {
    }


}