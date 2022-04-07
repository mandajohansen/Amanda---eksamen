using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneChanger : MonoBehaviour
{
    
    public static SceneChanger instance;
    
    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void LoadSceneAsync(string TestingScene)
    {
    SceneManager.LoadSceneAsync("TestingScene");
    Debug.Log("Changed");
    
    }
}
