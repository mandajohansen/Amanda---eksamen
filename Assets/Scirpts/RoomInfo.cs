using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomInfo : MonoBehaviour
{
    public acessType acess;
    public Text text;
    public enum acessType
    {
        FreeAccess = 0,
        LimitedAccess = 1,
        NoAccess = 2,
        OneTimeAccess = 3


    }

    public void Start()
    {
        text.text = acess.ToString();


    }

}
