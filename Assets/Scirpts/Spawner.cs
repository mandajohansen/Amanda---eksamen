using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
    /// <summary>
    /// This script, handles how the popup messages appear, 
    ///with the use of the new input system.
    /// </summary>


//This are all the gameobject, which represent the 3 different possible messages
// which can appear on the screen
    public GameObject AdgangPopup;
    public GameObject IngenadgangPopup;
    public GameObject BegrænsetadgangPopup;
 
    
// bool gør at den enten kan være true eller false.
    //bool isEnabled = false;


//Awake means, what ever is in the method gets called when the application starts.
        private void Awake()
        {
           Reset();
        }

///<summary>
//These three methods calls upon the action Adgang, Ingenadgang 
//and Begrænset from the new input system.
//In those method the Adgangmessage, Ingenadgangmessage and Begrænsetadgangmessage
//Gets called, which is defined later in the script.
/// </summary>


         public void Adgang()
        {
            
            //Shows of the action is done in the console
            Debug.Log("Adgang");
            Adgangmessage();
        
            
        }
    
        public void Ingenadgang()
        {
            Debug.Log("Ingen adgang");
            Ingenadgangmessage();
           
        }

        public void Begrænset()
        {
            Debug.Log("Begrænset adgang");
            Begrænsetadgangmessage();
        }
    

//These are the methods that defines the messages
        public void Adgangmessage()
            {
           
            if(AdgangPopup == true)
                {
                bool isActive = AdgangPopup.activeSelf;
                AdgangPopup.SetActive(! isActive);
                SoundManager.Instance.PlayAdgangSound(); 
                }
            }

      public void Ingenadgangmessage()
      {
          
           if(IngenadgangPopup == true)
        {
            bool isActive = IngenadgangPopup.activeSelf;
            IngenadgangPopup.SetActive(! isActive);
            SoundManager.Instance.PlayIngenSound();
        }
      }

      public void Begrænsetadgangmessage()
      {
          
           if(BegrænsetadgangPopup == true)
        {
            bool isActive = BegrænsetadgangPopup.activeSelf;
            BegrænsetadgangPopup.SetActive(! isActive);
            SoundManager.Instance.PlayBegrænsetSound();
        }
      }
     public void Reset()
      {
        AdgangPopup.SetActive(false);
        IngenadgangPopup.SetActive(false);
        BegrænsetadgangPopup.SetActive(false);

      }

}




    
    

    