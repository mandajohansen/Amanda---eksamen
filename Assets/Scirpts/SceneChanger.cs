using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class SceneChanger : MonoBehaviour
{
    public void LoadSceneAsync(string TestingScene)
    {
    SceneManager.LoadSceneAsync("TestingScene");
    Debug.Log("Changed");
    
    }
}
