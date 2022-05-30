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


//This method calls upon the action Adgang from the new input system.
//This method consists on calling the method Adgangmessage
//which is defined later in the script.
         public void Adgang()
        {
            //Shows of the action is done in the console
            Debug.Log("Adgang");

            
            Adgangmessage();

            //isEnabled=true;
            //}
            //Then if the Adgangmessage is true it should Reset and be false
            //else
            //{
             //  Reset();
             //   isEnabled=false;
            //}
            
        }
    
        public void Ingenadgang()
        {
            Debug.Log("Ingen adgang");
            //if(isEnabled == false)
            //{
            Ingenadgangmessage();
           // isEnabled=true;
            //}
        }

        public void Begrænset()
        {
            Debug.Log("Begrænset adgang");
             //if(isEnabled == false)
            //{
            Begrænsetadgangmessage();
            //isEnabled=true;
            //}
        }
    

        public void Adgangmessage()
            {
           
            if(AdgangPopup != null)
                {
                bool isActive = AdgangPopup.activeSelf;
                AdgangPopup.SetActive(! isActive);
                SoundManager.Instance.PlayAdgangSound(); 
                }
            }

      public void Ingenadgangmessage()
      {
          
           if(IngenadgangPopup != null)
        {
            bool isActive = IngenadgangPopup.activeSelf;
            IngenadgangPopup.SetActive(! isActive);
            SoundManager.Instance.PlayIngenSound();
        }
      }

      public void Begrænsetadgangmessage()
      {
          
           if(BegrænsetadgangPopup != null)
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




    
    

    