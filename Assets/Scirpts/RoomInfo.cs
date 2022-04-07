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

    public TMP_ColorGradient farve;

    public enum acessType 
    {
        Adgang = 0,
        BegrÊnsetAdgang = 1,
        IngenAdgang = 2
       


    }

    public void Start()
    {

        string accessText = "";
        if (cleareance == acessType.Adgang)
        {
            accessText = "Alle har Adgang";
            textAccess.color = Color.green;
        }
        if (cleareance == acessType.BegrÊnsetAdgang)
        {
            accessText = "BegrÊnset adgang";
            textAccess.color = Color.yellow;

        }
        if (cleareance == acessType.IngenAdgang)
        {
            accessText = "Ingen adgang";
            textAccess.color = new Color(1, 0, 0);

        }


        textAccess.text = accessText;

        textNavn.text = "Lokale: " + roomNavn;

        textType.text = roomType;

        text≈bning.text = dato≈bning;

        

        
    }

}
