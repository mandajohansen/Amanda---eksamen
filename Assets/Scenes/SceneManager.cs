using System.Collections;
using System.Collections.Generic;
using UnityEngine
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Switchscene(int scenetype)
    {
       StartCoroutine("scenecontroller", scenetype);
    }

    IEnumerator scenecontroller(int scenetype)
    {
        AsyncOperation status = SceneManager.LoadSceneAsync(scenetype);
        

        while (!status.isDone)
        {
            print("he status of load" + status.progress);
            yield return null;

        }

    }
}
