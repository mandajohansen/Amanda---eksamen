using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RoomInfo : MonoBehaviour
{

    public string roomNavn;

    public string roomType;

    public string dato≈bning;

    public acessType cleareance;
    
    public TMP_Text textNavn;

    public TMP_Text textType;

    public TMP_Text textAccess;

    public TMP_Text text≈bning;

    public enum acessType 
    {
        FriAdgang = 0,
        BegrÊnsetAdgang = 1,
        IngenAdgang = 2
       


    }

    public void Start()
    {

        string accessText = "";
        if (cleareance == acessType.FriAdgang)
        {
            accessText = "Adgang";

        }
        if (cleareance == acessType.BegrÊnsetAdgang)
        {
            accessText = "BegrÊnset adgang";

        }
        if (cleareance == acessType.IngenAdgang)
        {
            accessText = "Ingen adgang";

        }


        textAccess.text = accessText;

        textNavn.text = "Lokale: " + roomNavn;

        textType.text = roomType;

        text≈bning.text = dato≈bning;
    }

}
