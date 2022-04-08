using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject[] objectsToSpawn;
        // Liste over objekterne der kan spawne i banen

    public int popupCounter;

    bool isEnabled = false;

    private void Start() {
       Reset();
    }
    void Update() 
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(isEnabled == false)
            {
                SpawnObject();
                isEnabled=true;
               
            }
            else
            {
                Reset();
                isEnabled=false;
            }
                
        }
    }

    public void Reset()
    {
        foreach (GameObject obj in objectsToSpawn)
        {
            obj.SetActive(false);
        }
    }
        //Dette er koden vi rent faktisk bruger når vi skal spawne objekterne
    public void SpawnObject()
    {
        objectsToSpawn[popupCounter].SetActive(true);

        if(popupCounter == 0)
        {
         SoundManager.Instance.PlayAdgangSound();

        }
        else if(popupCounter == 1)
        {
         SoundManager.Instance.PlayIngenSound();

        }
        else if(popupCounter == 2)
        {
         SoundManager.Instance.PlayBegrænsetSound();

        }
        //Instantiate(objectsToSpawn, transform.position, Quaternion.identity);
    }
}