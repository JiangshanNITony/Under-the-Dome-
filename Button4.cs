﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Button4 : MonoBehaviour {

    //the ButtonPauseMenu
    void Start() {

    }
    void Update() {
        
    }
    
    public GameObject ingameMenu;

        
    
    public void KeepGoing(){
        Time.timeScale = 1;
    }

    public void NextGame()//点击“回到游戏”时执行此方法
    {
        SceneManager.LoadScene("last photo",LoadSceneMode.Single);
    }

    public void OnRestart()//点击“重新开始”时执行此方法
    {
        //Loading Scene0
        UnityEngine.SceneManagement.SceneManager.LoadScene(5);
        Time.timeScale = 1f;
    }
    public void quit() {
        Application.Quit();
    }
}