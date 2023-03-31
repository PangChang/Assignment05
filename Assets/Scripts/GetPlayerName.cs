using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetPlayerName : MonoBehaviour
{
    public InputField PlayerName;
    public static string myPlayerName;
    public Text ShowName;


    public void UpdateName()
    {
        myPlayerName = PlayerName.text;
        Debug.Log(PlayerName);
        ShowName.text = myPlayerName;

    }

    public void DisplayName()
    {
        myPlayerName = PlayerName.text; // assign input to string
        ShowName.text = "Welcome " + myPlayerName; //assign string to textbox
    }
}
