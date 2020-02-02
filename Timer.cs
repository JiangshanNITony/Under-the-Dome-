using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject text;
    public int TotalTime = 60;

    void Start()
    {

        StartCoroutine(CountDown());
        
    }

    IEnumerator CountDown()
    {
        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
        }
        text.GetComponent<Text>().text = "<color=#7444c1>P2 WINS!</color>";
        text.GetComponent<Text>().transform.position = new Vector2(290, -200);
        text.GetComponent<Text>().transform.localScale *= 2;
        Application.Quit();
    }
}
