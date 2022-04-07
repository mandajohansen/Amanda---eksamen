using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
   public GameObject objectsToSpawn;
        // Liste over objekterne der kan spawne i banen
    void Update() 
    {
        if(Input.GetButtonDown("Jump"))
        {
           // SpawnObject();
        }
    }

        //Dette er koden vi rent faktisk bruger når vi skal spawne objekterne
    public void SpawnObject()
    {
    
        Instantiate(objectsToSpawn, transform.position, Quaternion.identity);
    }
}