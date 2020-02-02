using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class toscene2 : MonoBehaviour
{
   
    
  public void NextGame()//点击“回到游戏”时执行此方法
    {
        SceneManager.LoadScene("SampleScene",LoadSceneMode.Single);

    }
}
